using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecretNest.KeyboardEventCaptor
{
    /// <summary>
    /// Represents an key event.
    /// </summary>
    public class InputEventArgs : EventArgs
    {
        internal InputEventArgs(byte[] time, ushort type, ushort code, uint value)
        {
            Time = time;
            Type = type;
            Code = code;
            Value = value;
        }

        internal InputEventArgs(byte[] buffer)
        {
            Time = new byte[16];
            Array.Copy(buffer, Time, 16);
            Type = BitConverter.ToUInt16(buffer, 16);
            Code = BitConverter.ToUInt16(buffer, 18);
            Value = BitConverter.ToUInt32(buffer, 20);
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
        /// Gets the value of this input event.
        /// </summary>
        /// <remarks>0 is key up. 1 is key down.</remarks>
        public uint Value { get; private set;}

        /// <summary>
        /// Converts into <see cref="KeyUpDownEventArgs"/>.
        /// </summary>
        /// <returns>Returns <see langword="null" /> when the event is not Key Up nor Key Down.</returns>
#pragma warning disable CS8632
        public KeyUpDownEventArgs? ToKeyUpDownEventArgs()
#pragma warning restore CS8632
        {
            if (Type == 1)
            {
                if (Value == 0)
                {
                    return new KeyUpDownEventArgs(Time, Type, Code, KeyUpDownEventArgs.KeyUpDown.Up);
                }
                else if (Value == 1)
                {
                    return new KeyUpDownEventArgs(Time, Type, Code, KeyUpDownEventArgs.KeyUpDown.Down);
                }
            }

            return null;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"Type:{Type} Code:{Code} Value:{Value}";
        }
    }
}
