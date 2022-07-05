using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecretNest.KeyboardEventCaptor
{
    /// <summary>
    /// Represents an input device found in system.
    /// </summary>
    public class Device
    {
        /// <summary>
        /// Gets the raw data provided from system.
        /// </summary>
        public IReadOnlyList<string> RawData { get; private set; }
        /// <summary>
        /// Gets the name of this device.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Gets the first event name of this device.
        /// </summary>
        public string EventName => EventNames[0];
        /// <summary>
        /// Gets all event names of this device.
        /// </summary>
        public string[] EventNames { get; private set; }

        internal static Device CreateInstance(IEnumerator<string> devices, out bool isFinished)
        {
            var rawData = new List<string>();
            var device = new Device
            {
                RawData = rawData
            };

            isFinished = true;
            while (devices.MoveNext())
            {
                var line = devices.Current;
                if (line == string.Empty)
                {
                    isFinished = false;
                    break;
                }
                rawData.Add(line);

                if (line.StartsWith(Const.PrefixOfName))
                {
                    var name = line.Substring(Const.PrefixOfName.Length);
                    if (name.StartsWith("\"") && name.EndsWith("\""))
                    {
                        name = name.Substring(1, name.Length - 2);
                    }

                    device.Name = name;
                }
                else if (line.StartsWith(Const.PrefixOfHandlers))
                {
                    var names = line.Substring(Const.PrefixOfHandlers.Length).Split(' ');
                    device.EventNames = names.Where(i => i.StartsWith(Const.PrefixOfEvent)).ToArray();
                }
            }
            return device;
        }
    }
}
