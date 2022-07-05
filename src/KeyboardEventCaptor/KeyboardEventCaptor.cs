using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace SecretNest.KeyboardEventCaptor
{
    /// <summary>
    /// 
    /// </summary>
    public class KeyboardEventCaptor : IDisposable
    {
        private string _fileName;
#pragma warning disable CS8632
        private FileStream? _stream;
#pragma warning restore CS8632
        private bool _working;
        private Thread _job;

        #region Constructors

        /// <summary>
        /// Initializes an instance of KeyboardEventCaptor using the event name specified.
        /// </summary>
        /// <param name="eventName">The event name of the input device.</param>
        public KeyboardEventCaptor(string eventName)
        {
            _fileName = Const.PathOfEvents + eventName;
        }

        /// <summary>
        /// Initializes an instance of KeyboardEventCaptor using the event index specified.
        /// </summary>
        /// <param name="eventIndex">The event index of the input device.</param>
        public KeyboardEventCaptor(int eventIndex) : this(string.Format(Const.FormatOfEvent, eventIndex))
        {
        }

        /// <summary>
        /// Initializes an instance of KeyboardEventCaptor on the device specified.
        /// </summary>
        /// <param name="device">The specified input device.</param>
        public KeyboardEventCaptor(Device device) : this(device.EventName)
        {
        }

        #endregion

        /// <summary>
        /// Gets the captor working status.
        /// </summary>
        public bool Working => _working;

        /// <summary>
        /// Starts listening this keyboard.
        /// </summary>
        public void Start()
        {
            if (_stream == null)
            {
                _stream = new FileStream(_fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                _working = true;
                _job = new Thread(Read)
                {
                    IsBackground = true
                };
                _job.Start();
            }
        }

        /// <summary>
        /// Stops listening.
        /// </summary>
        public void Stop()
        {
            if (_stream != null)
            {
                _working = false;
                _stream.Dispose();

                _job.Join();
                _stream = null;
                _job = null;
            }
        }

        /// <summary>
        /// Raises when keyboard event received.
        /// </summary>
        public event EventHandler<InputEventArgs> KeyboardEventCaptured;

        /// <summary>
        /// Raises when key down event received.
        /// </summary>
        public event EventHandler<KeyUpDownEventArgs> KeyDownCaptured;

        /// <summary>
        /// Raises when key up event received.
        /// </summary>
        public event EventHandler<KeyUpDownEventArgs> KeyUpCaptured;

        void Read()
        {
            while (_working)
            {
                try
                {
                    var buffer = new byte[24];
                    var count = _stream!.Read(buffer, 0, 24);
                    if (count != 24)
                    {
                        throw new InvalidDataException("Event size is illegal.");
                    }

                    var inputEvent = new InputEventArgs(buffer);
                    if (KeyUpCaptured != null || KeyDownCaptured != null)
                    {
                        var keyUpDownEvent = inputEvent.ToKeyUpDownEventArgs();
                        if (keyUpDownEvent != null)
                        {
                            if (keyUpDownEvent.Action == KeyUpDownEventArgs.KeyUpDown.Up)
                            {
                                KeyUpCaptured?.Invoke(this, keyUpDownEvent);
                            }
                            else if (keyUpDownEvent.Action == KeyUpDownEventArgs.KeyUpDown.Down)
                            {
                                KeyDownCaptured?.Invoke(this, keyUpDownEvent);
                            }
                        }
                    }

                    KeyboardEventCaptured?.Invoke(this, inputEvent);
                }
                catch
                {
                    if (_working) throw;
                }
            }
        }

        #region Disposing
        private bool _disposedValue;

        /// <summary>
        /// Disposes the instance of KeyboardEventCaptor.
        /// </summary>
        /// <param name="disposing">Disposing managed resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    Stop();
                }

                _disposedValue = true;
            }
        }

        /// <inheritdoc />>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
