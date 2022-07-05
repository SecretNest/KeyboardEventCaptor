using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SecretNest.KeyboardEventCaptor
{
    /// <summary>
    /// Contains method for enumerate devices from system. This is a static class.
    /// </summary>
    public static class Devices
    {
        /// <summary>
        /// Enumerates input devices from system.
        /// </summary>
        /// <returns>Input devices found in system.</returns>
        public static IEnumerable<Device> GetDevices()
        {
            var fs = ((IEnumerable<string>)File.ReadAllLines(Const.PathOfDevices)).GetEnumerator();
            bool isFinished;
            do
            {
                var device = Device.CreateInstance(fs, out isFinished);
                if (device.RawData.Any())
                    yield return device;
            } while (!isFinished);
        }
    }
}
