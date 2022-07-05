using System;
using System.Collections.Generic;
using System.Text;

namespace SecretNest.KeyboardEventCaptor
{
    static class Const
    {
        public const string PathOfDevices = "/proc/bus/input/devices";
        public const string PrefixOfName = "N: Name="; //contains quotes
        public const string PrefixOfHandlers = "H: Handlers=";
        public const string PrefixOfEvent = "event";

        public const string PathOfEvents = "/dev/input/";
        public const string FormatOfEvent = "event{0}";
    }
}
