using System;
using System.Collections.Generic;
using System.Text;

namespace SecretNest.KeyboardEventCaptor
{
    /// <summary>
    /// Represents a key up or down event.
    /// </summary>
    public class KeyUpDownEventArgs : EventArgs
    {
        internal KeyUpDownEventArgs(byte[] time, ushort type, ushort code, KeyUpDown action)
        {
            Time = time;
            Type = type;
            Code = code;
            Action = action;
        }

        /// <summary>
        /// Gets the time of this input event in timeval format.
        /// </summary>
        public byte[] Time { get; private set; }
        /// <summary>
        /// Gets the type of this input event.
        /// </summary>
        public ushort Type { get; private set; }
        /// <summary>
        /// Gets the code of this input event.
        /// </summary>
        public ushort Code { get; private set; }
        /// <summary>
        /// Gets the key of this input event from <see cref="Code"/>.
        /// </summary>
        public Key Key => (Key)Code;

        /// <summary>
        /// Gets the key action.
        /// </summary>
        public KeyUpDown Action { get; private set; }

        /// <summary>
        /// Defines the value of key up and down.
        /// </summary>
        public enum KeyUpDown : uint
        {
            /// <summary>
            /// Key up.
            /// </summary>
            Up = 0,
            /// <summary>
            /// Key down
            /// </summary>
            Down = 1
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"Key{Action}: {Key} Type:{Type}";
        }
    }
}
