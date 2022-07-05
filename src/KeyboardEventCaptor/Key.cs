using System;
using System.Collections.Generic;
using System.Text;

namespace SecretNest.KeyboardEventCaptor
{
    /// <summary>
    /// Defines the key codes.
    /// </summary>
    public enum Key
    {
        ///<summary>
        ///Reserved
        ///</summary>
        Reserved = 0,

        ///<summary>
        ///Esc
        ///</summary>
        Esc = 1,

        ///<summary>
        ///Key1
        ///</summary>
        Key1 = 2,

        ///<summary>
        ///Key2
        ///</summary>
        Key2 = 3,

        ///<summary>
        ///Key3
        ///</summary>
        Key3 = 4,

        ///<summary>
        ///Key4
        ///</summary>
        Key4 = 5,

        ///<summary>
        ///Key5
        ///</summary>
        Key5 = 6,

        ///<summary>
        ///Key6
        ///</summary>
        Key6 = 7,

        ///<summary>
        ///Key7
        ///</summary>
        Key7 = 8,

        ///<summary>
        ///Key8
        ///</summary>
        Key8 = 9,

        ///<summary>
        ///Key9
        ///</summary>
        Key9 = 10,

        ///<summary>
        ///Key0
        ///</summary>
        Key0 = 11,

        ///<summary>
        ///Minus
        ///</summary>
        Minus = 12,

        ///<summary>
        ///Equal
        ///</summary>
        Equal = 13,

        ///<summary>
        ///Backspace
        ///</summary>
        Backspace = 14,

        ///<summary>
        ///Tab
        ///</summary>
        Tab = 15,

        ///<summary>
        ///Q
        ///</summary>
        Q = 16,

        ///<summary>
        ///W
        ///</summary>
        W = 17,

        ///<summary>
        ///E
        ///</summary>
        E = 18,

        ///<summary>
        ///R
        ///</summary>
        R = 19,

        ///<summary>
        ///T
        ///</summary>
        T = 20,

        ///<summary>
        ///Y
        ///</summary>
        Y = 21,

        ///<summary>
        ///U
        ///</summary>
        U = 22,

        ///<summary>
        ///I
        ///</summary>
        I = 23,

        ///<summary>
        ///O
        ///</summary>
        O = 24,

        ///<summary>
        ///P
        ///</summary>
        P = 25,

        ///<summary>
        ///LeftBrace
        ///</summary>
        LeftBrace = 26,

        ///<summary>
        ///RightBrace
        ///</summary>
        RightBrace = 27,

        ///<summary>
        ///Enter
        ///</summary>
        Enter = 28,

        ///<summary>
        ///LeftControl
        ///</summary>
        LeftControl = 29,

        ///<summary>
        ///A
        ///</summary>
        A = 30,

        ///<summary>
        ///S
        ///</summary>
        S = 31,

        ///<summary>
        ///D
        ///</summary>
        D = 32,

        ///<summary>
        ///F
        ///</summary>
        F = 33,

        ///<summary>
        ///G
        ///</summary>
        G = 34,

        ///<summary>
        ///H
        ///</summary>
        H = 35,

        ///<summary>
        ///J
        ///</summary>
        J = 36,

        ///<summary>
        ///K
        ///</summary>
        K = 37,

        ///<summary>
        ///L
        ///</summary>
        L = 38,

        ///<summary>
        ///Semicolon
        ///</summary>
        Semicolon = 39,

        ///<summary>
        ///Apostrophe
        ///</summary>
        Apostrophe = 40,

        ///<summary>
        ///Grave
        ///</summary>
        Grave = 41,

        ///<summary>
        ///LeftShift
        ///</summary>
        LeftShift = 42,

        ///<summary>
        ///BackSlash
        ///</summary>
        BackSlash = 43,

        ///<summary>
        ///Z
        ///</summary>
        Z = 44,

        ///<summary>
        ///X
        ///</summary>
        X = 45,

        ///<summary>
        ///C
        ///</summary>
        C = 46,

        ///<summary>
        ///V
        ///</summary>
        V = 47,

        ///<summary>
        ///B
        ///</summary>
        B = 48,

        ///<summary>
        ///N
        ///</summary>
        N = 49,

        ///<summary>
        ///M
        ///</summary>
        M = 50,

        ///<summary>
        ///Comma
        ///</summary>
        Comma = 51,

        ///<summary>
        ///Dot
        ///</summary>
        Dot = 52,

        ///<summary>
        ///Slash
        ///</summary>
        Slash = 53,

        ///<summary>
        ///RightShift
        ///</summary>
        RightShift = 54,

        ///<summary>
        ///KPAsterisk
        ///</summary>
        KPAsterisk = 55,

        ///<summary>
        ///LeftAlt
        ///</summary>
        LeftAlt = 56,

        ///<summary>
        ///Space
        ///</summary>
        Space = 57,

        ///<summary>
        ///CapsLock
        ///</summary>
        CapsLock = 58,

        ///<summary>
        ///F1
        ///</summary>
        F1 = 59,

        ///<summary>
        ///F2
        ///</summary>
        F2 = 60,

        ///<summary>
        ///F3
        ///</summary>
        F3 = 61,

        ///<summary>
        ///F4
        ///</summary>
        F4 = 62,

        ///<summary>
        ///F5
        ///</summary>
        F5 = 63,

        ///<summary>
        ///F6
        ///</summary>
        F6 = 64,

        ///<summary>
        ///F7
        ///</summary>
        F7 = 65,

        ///<summary>
        ///F8
        ///</summary>
        F8 = 66,

        ///<summary>
        ///F9
        ///</summary>
        F9 = 67,

        ///<summary>
        ///F10
        ///</summary>
        F10 = 68,

        ///<summary>
        ///NumLock
        ///</summary>
        NumLock = 69,

        ///<summary>
        ///ScrollLock
        ///</summary>
        ScrollLock = 70,

        ///<summary>
        ///KP7
        ///</summary>
        KP7 = 71,

        ///<summary>
        ///KP8
        ///</summary>
        KP8 = 72,

        ///<summary>
        ///KP9
        ///</summary>
        KP9 = 73,

        ///<summary>
        ///KPMinus
        ///</summary>
        KPMinus = 74,

        ///<summary>
        ///KP4
        ///</summary>
        KP4 = 75,

        ///<summary>
        ///KP5
        ///</summary>
        KP5 = 76,

        ///<summary>
        ///KP6
        ///</summary>
        KP6 = 77,

        ///<summary>
        ///KPPlus
        ///</summary>
        KPPlus = 78,

        ///<summary>
        ///KP1
        ///</summary>
        KP1 = 79,

        ///<summary>
        ///KP2
        ///</summary>
        KP2 = 80,

        ///<summary>
        ///KP3
        ///</summary>
        KP3 = 81,

        ///<summary>
        ///KP0
        ///</summary>
        KP0 = 82,

        ///<summary>
        ///KPDot
        ///</summary>
        KPDot = 83,

        ///<summary>
        ///Zenkaku_Hankaku
        ///</summary>
        Zenkaku_Hankaku = 85,

        ///<summary>
        ///102nd
        ///</summary>
        Key102nd = 86,

        ///<summary>
        ///F11
        ///</summary>
        F11 = 87,

        ///<summary>
        ///F12
        ///</summary>
        F12 = 88,

        ///<summary>
        ///RO
        ///</summary>
        RO = 89,

        ///<summary>
        ///Katakana
        ///</summary>
        Katakana = 90,

        ///<summary>
        ///HIRAGANA
        ///</summary>
        HIRAGANA = 91,

        ///<summary>
        ///Henkan
        ///</summary>
        Henkan = 92,

        ///<summary>
        ///Katakana_Hiragana
        ///</summary>
        Katakana_Hiragana = 93,

        ///<summary>
        ///Muhenkan
        ///</summary>
        Muhenkan = 94,

        ///<summary>
        ///KPJpComma
        ///</summary>
        KPJpComma = 95,

        ///<summary>
        ///KPEnter
        ///</summary>
        KPEnter = 96,

        ///<summary>
        ///RightControl
        ///</summary>
        RightControl = 97,

        ///<summary>
        ///KPSlash
        ///</summary>
        KPSlash = 98,

        ///<summary>
        ///SysRq
        ///</summary>
        SysRq = 99,

        ///<summary>
        ///RightAlt
        ///</summary>
        RightAlt = 100,

        ///<summary>
        ///LineFeed
        ///</summary>
        LineFeed = 101,

        ///<summary>
        ///Home
        ///</summary>
        Home = 102,

        ///<summary>
        ///Up
        ///</summary>
        Up = 103,

        ///<summary>
        ///PageUp
        ///</summary>
        PageUp = 104,

        ///<summary>
        ///Left
        ///</summary>
        Left = 105,

        ///<summary>
        ///Right
        ///</summary>
        Right = 106,

        ///<summary>
        ///End
        ///</summary>
        End = 107,

        ///<summary>
        ///Down
        ///</summary>
        Down = 108,

        ///<summary>
        ///PageDown
        ///</summary>
        PageDown = 109,

        ///<summary>
        ///Insert
        ///</summary>
        Insert = 110,

        ///<summary>
        ///Delete
        ///</summary>
        Delete = 111,

        ///<summary>
        ///Macro
        ///</summary>
        Macro = 112,

        ///<summary>
        ///Mute
        ///</summary>
        Mute = 113,

        ///<summary>
        ///VolumeDown
        ///</summary>
        VolumeDown = 114,

        ///<summary>
        ///VolumeUp
        ///</summary>
        VolumeUp = 115,

        ///<summary>
        ///SC System Power Down
        ///</summary>
        Power = 116,

        ///<summary>
        ///KPEqual
        ///</summary>
        KPEqual = 117,

        ///<summary>
        ///KPPlusMinus
        ///</summary>
        KPPlusMinus = 118,

        ///<summary>
        ///Pause
        ///</summary>
        Pause = 119,

        ///<summary>
        ///AL Compiz Scale (Expose)
        ///</summary>
        Scale = 120,

        ///<summary>
        ///KPComma
        ///</summary>
        KPComma = 121,

        ///<summary>
        ///Hanguel
        ///</summary>
        Hanguel = 122,

        ///<summary>
        ///Hanja
        ///</summary>
        Hanja = 123,

        ///<summary>
        ///Yen
        ///</summary>
        Yen = 124,

        ///<summary>
        ///LeftMeta
        ///</summary>
        LeftMeta = 125,

        ///<summary>
        ///RightMeta
        ///</summary>
        RightMeta = 126,

        ///<summary>
        ///Compose
        ///</summary>
        Compose = 127,

        ///<summary>
        ///AC Stop
        ///</summary>
        Stop = 128,

        ///<summary>
        ///Again
        ///</summary>
        Again = 129,

        ///<summary>
        ///AC Properties
        ///</summary>
        Props = 130,

        ///<summary>
        ///AC Undo
        ///</summary>
        Undo = 131,

        ///<summary>
        ///Front
        ///</summary>
        Front = 132,

        ///<summary>
        ///AC Copy
        ///</summary>
        Copy = 133,

        ///<summary>
        ///AC Open
        ///</summary>
        Open = 134,

        ///<summary>
        ///AC Paste
        ///</summary>
        Paste = 135,

        ///<summary>
        ///AC Search
        ///</summary>
        Find = 136,

        ///<summary>
        ///AC Cut
        ///</summary>
        Cut = 137,

        ///<summary>
        ///AL Integrated Help Center
        ///</summary>
        Help = 138,

        ///<summary>
        ///Menu (show menu)
        ///</summary>
        Menu = 139,

        ///<summary>
        ///AL Calculator
        ///</summary>
        Calc = 140,

        ///<summary>
        ///Setup
        ///</summary>
        Setup = 141,

        ///<summary>
        ///SC System Sleep
        ///</summary>
        Sleep = 142,

        ///<summary>
        ///System Wake Up
        ///</summary>
        WakeUp = 143,

        ///<summary>
        ///AL Local Machine Browser
        ///</summary>
        File = 144,

        ///<summary>
        ///SendFile
        ///</summary>
        SendFile = 145,

        ///<summary>
        ///DeleteFile
        ///</summary>
        DeleteFile = 146,

        ///<summary>
        ///X-fer
        ///</summary>
        Xfer = 147,

        ///<summary>
        ///Prog1
        ///</summary>
        Prog1 = 148,

        ///<summary>
        ///Prog2
        ///</summary>
        Prog2 = 149,

        ///<summary>
        ///AL Internet Browser
        ///</summary>
        WWW = 150,

        ///<summary>
        ///MSDOS
        ///</summary>
        MSDOS = 151,

        ///<summary>
        ///AL Terminal Lock/Screensaver
        ///</summary>
        Coffee = 152,

        ///<summary>
        ///ScreenLock
        ///</summary>
        ScreenLock = 152,

        ///<summary>
        ///Display orientation for e.g. tablets
        ///</summary>
        RotateDisplay = 153,

        ///<summary>
        ///Direction
        ///</summary>
        Direction = 153,

        ///<summary>
        ///CycleWindows
        ///</summary>
        CycleWindows = 154,

        ///<summary>
        ///Mail
        ///</summary>
        Mail = 155,

        ///<summary>
        ///AC Bookmarks
        ///</summary>
        Bookmarks = 156,

        ///<summary>
        ///Computer
        ///</summary>
        Computer = 157,

        ///<summary>
        ///AC Back
        ///</summary>
        Back = 158,

        ///<summary>
        ///AC Forward
        ///</summary>
        Forward = 159,

        ///<summary>
        ///CloseCD
        ///</summary>
        CloseCD = 160,

        ///<summary>
        ///EjectCD
        ///</summary>
        EjectCD = 161,

        ///<summary>
        ///EjectCloseCD
        ///</summary>
        EjectCloseCD = 162,

        ///<summary>
        ///NextSong
        ///</summary>
        NextSong = 163,

        ///<summary>
        ///PlayPause
        ///</summary>
        PlayPause = 164,

        ///<summary>
        ///PreviousSong
        ///</summary>
        PreviousSong = 165,

        ///<summary>
        ///StopCD
        ///</summary>
        StopCD = 166,

        ///<summary>
        ///Record
        ///</summary>
        Record = 167,

        ///<summary>
        ///Rewind
        ///</summary>
        Rewind = 168,

        ///<summary>
        ///Media Select Telephone
        ///</summary>
        Phone = 169,

        ///<summary>
        ///ISO
        ///</summary>
        ISO = 170,

        ///<summary>
        ///AL Consumer Control Configuration
        ///</summary>
        Config = 171,

        ///<summary>
        ///AC Home
        ///</summary>
        HomePage = 172,

        ///<summary>
        ///AC Refresh
        ///</summary>
        Refresh = 173,

        ///<summary>
        ///AC Exit
        ///</summary>
        Exit = 174,

        ///<summary>
        ///Move
        ///</summary>
        Move = 175,

        ///<summary>
        ///Edit
        ///</summary>
        Edit = 176,

        ///<summary>
        ///ScrollUp
        ///</summary>
        ScrollUp = 177,

        ///<summary>
        ///ScrollDown
        ///</summary>
        ScrollDown = 178,

        ///<summary>
        ///KPLeftParenthesis
        ///</summary>
        KPLeftParenthesis = 179,

        ///<summary>
        ///KPRightParenthesis
        ///</summary>
        KPRightParenthesis = 180,

        ///<summary>
        ///AC New
        ///</summary>
        New = 181,

        ///<summary>
        ///AC Redo/Repeat
        ///</summary>
        Redo = 182,

        ///<summary>
        ///F13
        ///</summary>
        F13 = 183,

        ///<summary>
        ///F14
        ///</summary>
        F14 = 184,

        ///<summary>
        ///F15
        ///</summary>
        F15 = 185,

        ///<summary>
        ///F16
        ///</summary>
        F16 = 186,

        ///<summary>
        ///F17
        ///</summary>
        F17 = 187,

        ///<summary>
        ///F18
        ///</summary>
        F18 = 188,

        ///<summary>
        ///F19
        ///</summary>
        F19 = 189,

        ///<summary>
        ///F20
        ///</summary>
        F20 = 190,

        ///<summary>
        ///F21
        ///</summary>
        F21 = 191,

        ///<summary>
        ///F22
        ///</summary>
        F22 = 192,

        ///<summary>
        ///F23
        ///</summary>
        F23 = 193,

        ///<summary>
        ///F24
        ///</summary>
        F24 = 194,

        ///<summary>
        ///PlayCD
        ///</summary>
        PlayCD = 200,

        ///<summary>
        ///PauseCD
        ///</summary>
        PauseCD = 201,

        ///<summary>
        ///Prog3
        ///</summary>
        Prog3 = 202,

        ///<summary>
        ///Prog4
        ///</summary>
        Prog4 = 203,

        ///<summary>
        ///AC Desktop Show All Applications
        ///</summary>
        AllApplications = 204,

        ///<summary>
        ///Dashboard
        ///</summary>
        Dashboard = 204,

        ///<summary>
        ///Suspend
        ///</summary>
        Suspend = 205,

        ///<summary>
        ///AC Close
        ///</summary>
        Close = 206,

        ///<summary>
        ///Play
        ///</summary>
        Play = 207,

        ///<summary>
        ///FastForward
        ///</summary>
        FastForward = 208,

        ///<summary>
        ///BassBoost
        ///</summary>
        BassBoost = 209,

        ///<summary>
        ///AC Print
        ///</summary>
        Print = 210,

        ///<summary>
        ///HP
        ///</summary>
        HP = 211,

        ///<summary>
        ///Camera
        ///</summary>
        Camera = 212,

        ///<summary>
        ///Sound
        ///</summary>
        Sound = 213,

        ///<summary>
        ///Question
        ///</summary>
        Question = 214,

        ///<summary>
        ///Email
        ///</summary>
        Email = 215,

        ///<summary>
        ///Chat
        ///</summary>
        Chat = 216,

        ///<summary>
        ///Search
        ///</summary>
        Search = 217,

        ///<summary>
        ///Connect
        ///</summary>
        Connect = 218,

        ///<summary>
        ///AL Checkbook/Finance
        ///</summary>
        Finance = 219,

        ///<summary>
        ///Sport
        ///</summary>
        Sport = 220,

        ///<summary>
        ///Shop
        ///</summary>
        Shop = 221,

        ///<summary>
        ///AlternateErase
        ///</summary>
        AlternateErase = 222,

        ///<summary>
        ///AC Cancel
        ///</summary>
        Cancel = 223,

        ///<summary>
        ///BrightnessDown
        ///</summary>
        BrightnessDown = 224,

        ///<summary>
        ///BrightnessUp
        ///</summary>
        BrightnessUp = 225,

        ///<summary>
        ///Media
        ///</summary>
        Media = 226,

        ///<summary>
        ///Cycle between available video outputs (Monitor/LCD/TV-out/etc)
        ///</summary>
        SwitchVideoMode = 227,

        ///<summary>
        ///KBDIllumToggle
        ///</summary>
        KBDIllumToggle = 228,

        ///<summary>
        ///KBDIllumDown
        ///</summary>
        KBDIllumDown = 229,

        ///<summary>
        ///KBDIllumUp
        ///</summary>
        KBDIllumUp = 230,

        ///<summary>
        ///AC Send
        ///</summary>
        Send = 231,

        ///<summary>
        ///AC Reply
        ///</summary>
        Reply = 232,

        ///<summary>
        ///AC Forward Msg
        ///</summary>
        ForwardMail = 233,

        ///<summary>
        ///AC Save
        ///</summary>
        Save = 234,

        ///<summary>
        ///Documents
        ///</summary>
        Documents = 235,

        ///<summary>
        ///Battery
        ///</summary>
        Battery = 236,

        ///<summary>
        ///BlueTooth
        ///</summary>
        BlueTooth = 237,

        ///<summary>
        ///Wlan
        ///</summary>
        WLan = 238,

        ///<summary>
        ///UWB
        ///</summary>
        UWB = 239,

        ///<summary>
        ///Unknown
        ///</summary>
        Unknown = 240,

        ///<summary>
        ///drive next video source
        ///</summary>
        VideoNext = 241,

        ///<summary>
        ///drive previous video source
        ///</summary>
        VideoPrev = 242,

        ///<summary>
        ///brightness up, after max is min
        ///</summary>
        BrightnessCycle = 243,

        ///<summary>
        ///Set Auto Brightness: manual brightness control is off, rely on ambient
        ///</summary>
        BrightnessAuto = 244,

        ///<summary>
        ///BrightnessZero
        ///</summary>
        BrightnessZero = 244,

        ///<summary>
        ///display device to off state
        ///</summary>
        DisplayOff = 245,

        ///<summary>
        ///Wireless WAN (LTE, UMTS, GSM, etc.)
        ///</summary>
        WWan = 246,

        ///<summary>
        ///WiMAX
        ///</summary>
        WiMAX = 246,

        ///<summary>
        ///Key that controls all radios
        ///</summary>
        RFKill = 247,

        ///<summary>
        ///Mute / unmute the microphone
        ///</summary>
        MicMute = 248,
    }
}
