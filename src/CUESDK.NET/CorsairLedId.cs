// Licensed to the Chroma Control Contributors under one or more agreements.
// The Chroma Control Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace CUESDK
{
    /// <summary>
    /// Contains shared list of all leds on all devices (keyboard, mouse, mouse mat, headset, headset stand, DIY, memory module, cooler) and all models/physical layouts.
    /// </summary>
    public enum CorsairLedId
    {
        /// <summary>
        /// Dummy value.
        /// </summary>
        Invalid = 0,

        /// <summary>
        /// For keyboard escape led.
        /// </summary>
        KeyboardEscape = 1,

        /// <summary>
        /// For keyboard F1 led.
        /// </summary>
        KeyboardF1 = 2,

        /// <summary>
        /// For keyboard F2 led.
        /// </summary>
        KeyboardF2 = 3,

        /// <summary>
        /// For keyboard F3 led.
        /// </summary>
        KeyboardF3 = 4,

        /// <summary>
        /// For keyboard F4 led.
        /// </summary>
        KeyboardF4 = 5,

        /// <summary>
        /// For keyboard F5 led.
        /// </summary>
        KeyboardF5 = 6,

        /// <summary>
        /// For keyboard F6 led.
        /// </summary>
        KeyboardF6 = 7,

        /// <summary>
        /// For keyboard F7 led.
        /// </summary>
        KeyboardF7 = 8,

        /// <summary>
        /// For keyboard F8 led.
        /// </summary>
        KeyboardF8 = 9,

        /// <summary>
        /// For keyboard F9 led.
        /// </summary>
        KeyboardF9 = 10,

        /// <summary>
        /// For keyboard F10 led.
        /// </summary>
        KeyboardF10 = 11,

        /// <summary>
        /// For keyboard F11 led.
        /// </summary>
        KeyboardF11 = 12,

        /// <summary>
        /// For keyboard grave accent and tilde led.
        /// </summary>
        KeyboardGraveAccentAndTilde = 13,

        /// <summary>
        /// For keyboard 1 led.
        /// </summary>
        Keyboard1 = 14,

        /// <summary>
        /// For keyboard 2 led.
        /// </summary>
        Keyboard2 = 15,

        /// <summary>
        /// For keyboard 3 led.
        /// </summary>
        Keyboard3 = 16,

        /// <summary>
        /// For keyboard 4 led.
        /// </summary>
        Keyboard4 = 17,

        /// <summary>
        /// For keyboard 5 led.
        /// </summary>
        Keyboard5 = 18,

        /// <summary>
        /// For keyboard 6 led.
        /// </summary>
        Keyboard6 = 19,

        /// <summary>
        /// For keyboard 7 led.
        /// </summary>
        Keyboard7 = 20,

        /// <summary>
        /// For keyboard 8 led.
        /// </summary>
        Keyboard8 = 21,

        /// <summary>
        /// For keyboard 9 led.
        /// </summary>
        Keyboard9 = 22,

        /// <summary>
        /// For keyboard 0 led.
        /// </summary>
        Keyboard0 = 23,

        /// <summary>
        /// For keyboard minus and underscore led.
        /// </summary>
        KeyboardMinusAndUnderscore = 24,

        /// <summary>
        /// For keyboard tab led.
        /// </summary>
        KeyboardTab = 25,

        /// <summary>
        /// For keyboard q led.
        /// </summary>
        KeyboardQ = 26,

        /// <summary>
        /// For keyboard w led.
        /// </summary>
        KeyboardW = 27,

        /// <summary>
        /// For keyboard e led.
        /// </summary>
        KeyboardE = 28,

        /// <summary>
        /// For keyboard r led.
        /// </summary>
        KeyboardR = 29,

        /// <summary>
        /// For keyboard t led.
        /// </summary>
        KeyboardT = 30,

        /// <summary>
        /// For keyboard y led.
        /// </summary>
        KeyboardY = 31,

        /// <summary>
        /// For keyboard u led.
        /// </summary>
        KeyboardU = 32,

        /// <summary>
        /// For keyboard i led.
        /// </summary>
        KeyboardI = 33,

        /// <summary>
        /// For keyboard o led.
        /// </summary>
        KeyboardO = 34,

        /// <summary>
        /// For keyboard p led.
        /// </summary>
        KeyboardP = 35,

        /// <summary>
        /// For keyboard bracket(left) led.
        /// </summary>
        KeyboardBracketLeft = 36,

        /// <summary>
        /// For keyboard caps lock led.
        /// </summary>
        KeyboardCapsLock = 37,

        /// <summary>
        /// For keyboard a led.
        /// </summary>
        KeyboardA = 38,

        /// <summary>
        /// For keyboard s led.
        /// </summary>
        KeyboardS = 39,

        /// <summary>
        /// For keyboard d led.
        /// </summary>
        KeyboardD = 40,

        /// <summary>
        /// For keyboard f led.
        /// </summary>
        KeyboardF = 41,

        /// <summary>
        /// For keyboard g led.
        /// </summary>
        KeyboardG = 42,

        /// <summary>
        /// For keyboard h led.
        /// </summary>
        KeyboardH = 43,

        /// <summary>
        /// For keyboard j led.
        /// </summary>
        KeyboardJ = 44,

        /// <summary>
        /// For keyboard k led.
        /// </summary>
        KeyboardK = 45,

        /// <summary>
        /// For keyboard l led.
        /// </summary>
        KeyboardL = 46,

        /// <summary>
        /// For keyboard semicolon and colon led.
        /// </summary>
        KeyboardSemicolonAndColon = 47,

        /// <summary>
        /// For keyboard apostrophe and double quote led.
        /// </summary>
        KeyboardApostropheAndDoubleQuote = 48,

        /// <summary>
        /// For keyboard left shift led.
        /// </summary>
        KeyboardLeftShift = 49,

        /// <summary>
        /// For keyboard non-US backslash led.
        /// </summary>
        KeyboardNonUsBackslash = 50,

        /// <summary>
        /// For keyboard z led.
        /// </summary>
        KeyboardZ = 51,

        /// <summary>
        /// For keyboard x led.
        /// </summary>
        KeyboardX = 52,

        /// <summary>
        /// For keyboard c led.
        /// </summary>
        KeyboardC = 53,

        /// <summary>
        /// For keyboard v led.
        /// </summary>
        KeyboardV = 54,

        /// <summary>
        /// For keyboard b led.
        /// </summary>
        KeyboardB = 55,

        /// <summary>
        /// For keyboard n led.
        /// </summary>
        KeyboardN = 56,

        /// <summary>
        /// For keyboard m led.
        /// </summary>
        KeyboardM = 57,

        /// <summary>
        /// For keyboard comma and less than led.
        /// </summary>
        KeyboardCommaAndLessThan = 58,

        /// <summary>
        /// For keyboard period and Bigger than led.
        /// </summary>
        KeyboardPeriodAndBiggerThan = 59,

        /// <summary>
        /// For keyboard slash and question mark led.
        /// </summary>
        KeyboardSlashAndQuestionMark = 60,

        /// <summary>
        /// For keyboard left ctrl led.
        /// </summary>
        KeyboardLeftCtrl = 61,

        /// <summary>
        /// For keyboard left gui led.
        /// </summary>
        KeyboardLeftGui = 62,

        /// <summary>
        /// For keyboard left alt led.
        /// </summary>
        KeyboardLeftAlt = 63,

        /// <summary>
        /// For keyboard lang 2 led.
        /// </summary>
        KeyboardLang2 = 64,

        /// <summary>
        /// For keyboard space led.
        /// </summary>
        KeyboardSpace = 65,

        /// <summary>
        /// For keyboard lang 1 led.
        /// </summary>
        KeyboardLang1 = 66,

        /// <summary>
        /// For keyboard international 2 led.
        /// </summary>
        KeyboardInternational2 = 67,

        /// <summary>
        /// For keyboard right alt led.
        /// </summary>
        KeyboardRightAlt = 68,

        /// <summary>
        /// For keyboard right gui led.
        /// </summary>
        KeyboardRightGui = 69,

        /// <summary>
        /// For keyboard application led.
        /// </summary>
        KeyboardApplication = 70,

        /// <summary>
        /// For keyboard led programming led.
        /// </summary>
        KeyboardLedProgramming = 71,

        /// <summary>
        /// For keyboard brightness led.
        /// </summary>
        KeyboardBrightness = 72,

        /// <summary>
        /// For keyboard F12 led.
        /// </summary>
        KeyboardF12 = 73,

        /// <summary>
        /// For keyboard print screen led.
        /// </summary>
        KeyboardPrintScreen = 74,

        /// <summary>
        /// For keyboard scroll lock led.
        /// </summary>
        KeyboardScrollLock = 75,

        /// <summary>
        /// For keyboard pause break led.
        /// </summary>
        KeyboardPauseBreak = 76,

        /// <summary>
        /// For keyboard insert led.
        /// </summary>
        KeyboardInsert = 77,

        /// <summary>
        /// For keyboard home led.
        /// </summary>
        KeyboardHome = 78,

        /// <summary>
        /// For keyboard page up led.
        /// </summary>
        KeyboardPageUp = 79,

        /// <summary>
        /// For keyboard bracket(right) led.
        /// </summary>
        KeyboardBracketRight = 80,

        /// <summary>
        /// For keyboard backslash led.
        /// </summary>
        KeyboardBackslash = 81,

        /// <summary>
        /// For keyboard non-US tilde led.
        /// </summary>
        KeyboardNonUsTilde = 82,

        /// <summary>
        /// For keyboard enter led.
        /// </summary>
        KeyboardEnter = 83,

        /// <summary>
        /// For keyboard international 1 led.
        /// </summary>
        KeyboardInternational1 = 84,

        /// <summary>
        /// For keyboard equals and plus led.
        /// </summary>
        KeyboardEqualsAndPlus = 85,

        /// <summary>
        /// For keyboard international 3 led.
        /// </summary>
        KeyboardInternational3 = 86,

        /// <summary>
        /// For keyboard backspace led.
        /// </summary>
        KeyboardBackspace = 87,

        /// <summary>
        /// For keyboard delete led.
        /// </summary>
        KeyboardDelete = 88,

        /// <summary>
        /// For keyboard end led.
        /// </summary>
        KeyboardEnd = 89,

        /// <summary>
        /// For keyboard page down led.
        /// </summary>
        KeyboardPageDown = 90,

        /// <summary>
        /// For keyboard right shift led.
        /// </summary>
        KeyboardRightShift = 91,

        /// <summary>
        /// For keyboard right ctrl led.
        /// </summary>
        KeyboardRightCtrl = 92,

        /// <summary>
        /// For keyboard up arrow led.
        /// </summary>
        KeyboardUpArrow = 93,

        /// <summary>
        /// For keyboard left arrow led.
        /// </summary>
        KeyboardLeftArrow = 94,

        /// <summary>
        /// For keyboard down arrow led.
        /// </summary>
        KeyboardDownArrow = 95,

        /// <summary>
        /// For keyboard right arrow led.
        /// </summary>
        KeyboardRightArrow = 96,

        /// <summary>
        /// For keyboard win lock led.
        /// </summary>
        KeyboardWinLock = 97,

        /// <summary>
        /// For keyboard mute led.
        /// </summary>
        KeyboardMute = 98,

        /// <summary>
        /// For keyboard stop led.
        /// </summary>
        KeyboardStop = 99,

        /// <summary>
        /// For keyboard scan previous track led.
        /// </summary>
        KeyboardScanPreviousTrack = 100,

        /// <summary>
        /// For keyboard play/pause led.
        /// </summary>
        KeyboardPlayPause = 101,

        /// <summary>
        /// For keyboard scan next track led.
        /// </summary>
        KeyboardScanNextTrack = 102,

        /// <summary>
        /// For keyboard num lock led.
        /// </summary>
        KeyboardNumLock = 103,

        /// <summary>
        /// For keyboard keypad slash led.
        /// </summary>
        KeyboardKeypadSlash = 104,

        /// <summary>
        /// For keyboard keypad asterisk led.
        /// </summary>
        KeyboardKeypadAsterisk = 105,

        /// <summary>
        /// For keyboard keypad minus led.
        /// </summary>
        KeyboardKeypadMinus = 106,

        /// <summary>
        /// For keyboard keypad plus led.
        /// </summary>
        KeyboardKeypadPlus = 107,

        /// <summary>
        /// For keyboard keypad enter led.
        /// </summary>
        KeyboardKeypadEnter = 108,

        /// <summary>
        /// For keyboard keypad 7 led.
        /// </summary>
        KeyboardKeypad7 = 109,

        /// <summary>
        /// For keyboard keypad 8 led.
        /// </summary>
        KeyboardKeypad8 = 110,

        /// <summary>
        /// For keyboard keypad 9 led.
        /// </summary>
        KeyboardKeypad9 = 111,

        /// <summary>
        /// For keyboard keypad comma led.
        /// </summary>
        KeyboardKeypadComma = 112,

        /// <summary>
        /// For keyboard keypad 4 led.
        /// </summary>
        KeyboardKeypad4 = 113,

        /// <summary>
        /// For keyboard keypad 5 led.
        /// </summary>
        KeyboardKeypad5 = 114,

        /// <summary>
        /// For keyboard keypad 6 led.
        /// </summary>
        KeyboardKeypad6 = 115,

        /// <summary>
        /// For keyboard keypad 1 led.
        /// </summary>
        KeyboardKeypad1 = 116,

        /// <summary>
        /// For keyboard keypad 2 led.
        /// </summary>
        KeyboardKeypad2 = 117,

        /// <summary>
        /// For keyboard keypad 3 led.
        /// </summary>
        KeyboardKeypad3 = 118,

        /// <summary>
        /// For keyboard keypad 0 led.
        /// </summary>
        KeyboardKeypad0 = 119,

        /// <summary>
        /// For keyboard keypad period and delete led.
        /// </summary>
        KeyboardKeypadPeriodAndDelete = 120,

        /// <summary>
        /// For keyboard G1 led.
        /// </summary>
        KeyboardG1 = 121,

        /// <summary>
        /// For keyboard G2 led.
        /// </summary>
        KeyboardG2 = 122,

        /// <summary>
        /// For keyboard G3 led.
        /// </summary>
        KeyboardG3 = 123,

        /// <summary>
        /// For keyboard G4 led.
        /// </summary>
        KeyboardG4 = 124,

        /// <summary>
        /// For keyboard G5 led.
        /// </summary>
        KeyboardG5 = 125,

        /// <summary>
        /// For keyboard G6 led.
        /// </summary>
        KeyboardG6 = 126,

        /// <summary>
        /// For keyboard G7 led.
        /// </summary>
        KeyboardG7 = 127,

        /// <summary>
        /// For keyboard G8 led.
        /// </summary>
        KeyboardG8 = 128,

        /// <summary>
        /// For keyboard G9 led.
        /// </summary>
        KeyboardG9 = 129,

        /// <summary>
        /// For keyboard G10 led.
        /// </summary>
        KeyboardG10 = 130,

        /// <summary>
        /// For keyboard volume up led.
        /// </summary>
        KeyboardVolumeUp = 131,

        /// <summary>
        /// For keyboard volume down led.
        /// </summary>
        KeyboardVolumeDown = 132,

        /// <summary>
        /// For keyboard MR led.
        /// </summary>
        KeyboardMR = 133,

        /// <summary>
        /// For keyboard M1 led.
        /// </summary>
        KeyboardM1 = 134,

        /// <summary>
        /// For keyboard M2 led.
        /// </summary>
        KeyboardM2 = 135,

        /// <summary>
        /// For keyboard M3 led.
        /// </summary>
        KeyboardM3 = 136,

        /// <summary>
        /// For keyboard G11 led.
        /// </summary>
        KeyboardG11 = 137,

        /// <summary>
        /// For keyboard G12 led.
        /// </summary>
        KeyboardG12 = 138,

        /// <summary>
        /// For keyboard G13 led.
        /// </summary>
        KeyboardG13 = 139,

        /// <summary>
        /// For keyboard G14 led.
        /// </summary>
        KeyboardG14 = 140,

        /// <summary>
        /// For keyboard G15 led.
        /// </summary>
        KeyboardG15 = 141,

        /// <summary>
        /// For keyboard G16 led.
        /// </summary>
        KeyboardG16 = 142,

        /// <summary>
        /// For keyboard G17 led.
        /// </summary>
        KeyboardG17 = 143,

        /// <summary>
        /// For keyboard G18 led.
        /// </summary>
        KeyboardG18 = 144,

        /// <summary>
        /// For keyboard international 5 led.
        /// </summary>
        KeyboardInternational5 = 145,

        /// <summary>
        /// For keyboard international 4 led.
        /// </summary>
        KeyboardInternational4 = 146,

        /// <summary>
        /// For keyboard fn led.
        /// </summary>
        KeyboardFn = 147,

        /// <summary>
        /// For mouse 1 led.
        /// </summary>
        Mouse1 = 148,

        /// <summary>
        /// For mouse 2 led.
        /// </summary>
        Mouse2 = 149,

        /// <summary>
        /// For mouse 3 led.
        /// </summary>
        Mouse3 = 150,

        /// <summary>
        /// For mouse 4 led.
        /// </summary>
        Mouse4 = 151,

        /// <summary>
        /// For headset left logo led.
        /// </summary>
        HeadsetLeftLogo = 152,

        /// <summary>
        /// For headset right logo led.
        /// </summary>
        HeadsetRightLogo = 153,

        /// <summary>
        /// For keyboard logo led.
        /// </summary>
        KeyboardLogo = 154,

        /// <summary>
        /// For mouse mat zone 1 led.
        /// </summary>
        MouseMatZone1 = 155,

        /// <summary>
        /// For mouse mat zone 2 led.
        /// </summary>
        MouseMatZone2 = 156,

        /// <summary>
        /// For mouse mat zone 3 led.
        /// </summary>
        MouseMatZone3 = 157,

        /// <summary>
        /// For mouse mat zone 4 led.
        /// </summary>
        MouseMatZone4 = 158,

        /// <summary>
        /// For mouse mat zone 5 led.
        /// </summary>
        MouseMatZone5 = 159,

        /// <summary>
        /// For mouse mat zone 6 led.
        /// </summary>
        MouseMatZone6 = 160,

        /// <summary>
        /// For mouse mat zone 7 led.
        /// </summary>
        MouseMatZone7 = 161,

        /// <summary>
        /// For mouse mat zone 8 led.
        /// </summary>
        MouseMatZone8 = 162,

        /// <summary>
        /// For mouse mat zone 9 led.
        /// </summary>
        MouseMatZone9 = 163,

        /// <summary>
        /// For mouse mat zone 10 led.
        /// </summary>
        MouseMatZone10 = 164,

        /// <summary>
        /// For mouse mat zone 11 led.
        /// </summary>
        MouseMatZone11 = 165,

        /// <summary>
        /// For mouse mat zone 12 led.
        /// </summary>
        MouseMatZone12 = 166,

        /// <summary>
        /// For mouse mat zone 13 led.
        /// </summary>
        MouseMatZone13 = 167,

        /// <summary>
        /// For mouse mat zone 14 led.
        /// </summary>
        MouseMatZone14 = 168,

        /// <summary>
        /// For mouse mat zone 15 led.
        /// </summary>
        MouseMatZone15 = 169,

        /// <summary>
        /// For keyboard light pipe zone 1 led.
        /// </summary>
        KeyboardLightPipeZone1 = 170,

        /// <summary>
        /// For keyboard light pipe zone 2 led.
        /// </summary>
        KeyboardLightPipeZone2 = 171,

        /// <summary>
        /// For keyboard light pipe zone 3 led.
        /// </summary>
        KeyboardLightPipeZone3 = 172,

        /// <summary>
        /// For keyboard light pipe zone 4 led.
        /// </summary>
        KeyboardLightPipeZone4 = 173,

        /// <summary>
        /// For keyboard light pipe zone 5 led.
        /// </summary>
        KeyboardLightPipeZone5 = 174,

        /// <summary>
        /// For keyboard light pipe zone 6 led.
        /// </summary>
        KeyboardLightPipeZone6 = 175,

        /// <summary>
        /// For keyboard light pipe zone 7 led.
        /// </summary>
        KeyboardLightPipeZone7 = 176,

        /// <summary>
        /// For keyboard light pipe zone 8 led.
        /// </summary>
        KeyboardLightPipeZone8 = 177,

        /// <summary>
        /// For keyboard light pipe zone 9 led.
        /// </summary>
        KeyboardLightPipeZone9 = 178,

        /// <summary>
        /// For keyboard light pipe zone 10 led.
        /// </summary>
        KeyboardLightPipeZone10 = 179,

        /// <summary>
        /// For keyboard light pipe zone 11 led.
        /// </summary>
        KeyboardLightPipeZone11 = 180,

        /// <summary>
        /// For keyboard light pipe zone 12 led.
        /// </summary>
        KeyboardLightPipeZone12 = 181,

        /// <summary>
        /// For keyboard light pipe zone 13 led.
        /// </summary>
        KeyboardLightPipeZone13 = 182,

        /// <summary>
        /// For keyboard light pipe zone 14 led.
        /// </summary>
        KeyboardLightPipeZone14 = 183,

        /// <summary>
        /// For keyboard light pipe zone 15 led.
        /// </summary>
        KeyboardLightPipeZone15 = 184,

        /// <summary>
        /// For keyboard light pipe zone 16 led.
        /// </summary>
        KeyboardLightPipeZone16 = 185,

        /// <summary>
        /// For keyboard light pipe zone 17 led.
        /// </summary>
        KeyboardLightPipeZone17 = 186,

        /// <summary>
        /// For keyboard light pipe zone 18 led.
        /// </summary>
        KeyboardLightPipeZone18 = 187,

        /// <summary>
        /// For keyboard light pipe zone 19 led.
        /// </summary>
        KeyboardLightPipeZone19 = 188,

        /// <summary>
        /// For mouse 5 led.
        /// </summary>
        Mouse5 = 189,

        /// <summary>
        /// For mouse 6 led.
        /// </summary>
        Mouse6 = 190,

        /// <summary>
        /// For headset stand zone 1 led.
        /// </summary>
        HeadsetStandZone1 = 191,

        /// <summary>
        /// For headset stand zone 2 led.
        /// </summary>
        HeadsetStandZone2 = 192,

        /// <summary>
        /// For headset stand zone 3 led.
        /// </summary>
        HeadsetStandZone3 = 193,

        /// <summary>
        /// For headset stand zone 4 led.
        /// </summary>
        HeadsetStandZone4 = 194,

        /// <summary>
        /// For headset stand zone 5 led.
        /// </summary>
        HeadsetStandZone5 = 195,

        /// <summary>
        /// For headset stand zone 6 led.
        /// </summary>
        HeadsetStandZone6 = 196,

        /// <summary>
        /// For headset stand zone 7 led.
        /// </summary>
        HeadsetStandZone7 = 197,

        /// <summary>
        /// For headset stand zone 8 led.
        /// </summary>
        HeadsetStandZone8 = 198,

        /// <summary>
        /// For headset stand zone 9 led.
        /// </summary>
        HeadsetStandZone9 = 199,

        /// <summary>
        /// For first channel of the DIY-devices led 1.
        /// </summary>
        DIYChannel1Led1 = 200,

        /// <summary>
        /// For first channel of the DIY-devices led 2.
        /// </summary>
        DIYChannel1Led2 = 201,

        /// <summary>
        /// For first channel of the DIY-devices led 3.
        /// </summary>
        DIYChannel1Led3 = 202,

        /// <summary>
        /// For first channel of the DIY-devices led 4.
        /// </summary>
        DIYChannel1Led4 = 203,

        /// <summary>
        /// For first channel of the DIY-devices led 5.
        /// </summary>
        DIYChannel1Led5 = 204,

        /// <summary>
        /// For first channel of the DIY-devices led 6.
        /// </summary>
        DIYChannel1Led6 = 205,

        /// <summary>
        /// For first channel of the DIY-devices led 7.
        /// </summary>
        DIYChannel1Led7 = 206,

        /// <summary>
        /// For first channel of the DIY-devices led 8.
        /// </summary>
        DIYChannel1Led8 = 207,

        /// <summary>
        /// For first channel of the DIY-devices led 9.
        /// </summary>
        DIYChannel1Led9 = 208,

        /// <summary>
        /// For first channel of the DIY-devices led 10.
        /// </summary>
        DIYChannel1Led10 = 209,

        /// <summary>
        /// For first channel of the DIY-devices led 11.
        /// </summary>
        DIYChannel1Led11 = 210,

        /// <summary>
        /// For first channel of the DIY-devices led 12.
        /// </summary>
        DIYChannel1Led12 = 211,

        /// <summary>
        /// For first channel of the DIY-devices led 13.
        /// </summary>
        DIYChannel1Led13 = 212,

        /// <summary>
        /// For first channel of the DIY-devices led 14.
        /// </summary>
        DIYChannel1Led14 = 213,

        /// <summary>
        /// For first channel of the DIY-devices led 15.
        /// </summary>
        DIYChannel1Led15 = 214,

        /// <summary>
        /// For first channel of the DIY-devices led 16.
        /// </summary>
        DIYChannel1Led16 = 215,

        /// <summary>
        /// For first channel of the DIY-devices led 17.
        /// </summary>
        DIYChannel1Led17 = 216,

        /// <summary>
        /// For first channel of the DIY-devices led 18.
        /// </summary>
        DIYChannel1Led18 = 217,

        /// <summary>
        /// For first channel of the DIY-devices led 19.
        /// </summary>
        DIYChannel1Led19 = 218,

        /// <summary>
        /// For first channel of the DIY-devices led 20.
        /// </summary>
        DIYChannel1Led20 = 219,

        /// <summary>
        /// For first channel of the DIY-devices led 21.
        /// </summary>
        DIYChannel1Led21 = 220,

        /// <summary>
        /// For first channel of the DIY-devices led 22.
        /// </summary>
        DIYChannel1Led22 = 221,

        /// <summary>
        /// For first channel of the DIY-devices led 23.
        /// </summary>
        DIYChannel1Led23 = 222,

        /// <summary>
        /// For first channel of the DIY-devices led 24.
        /// </summary>
        DIYChannel1Led24 = 223,

        /// <summary>
        /// For first channel of the DIY-devices led 25.
        /// </summary>
        DIYChannel1Led25 = 224,

        /// <summary>
        /// For first channel of the DIY-devices led 26.
        /// </summary>
        DIYChannel1Led26 = 225,

        /// <summary>
        /// For first channel of the DIY-devices led 27.
        /// </summary>
        DIYChannel1Led27 = 226,

        /// <summary>
        /// For first channel of the DIY-devices led 28.
        /// </summary>
        DIYChannel1Led28 = 227,

        /// <summary>
        /// For first channel of the DIY-devices led 29.
        /// </summary>
        DIYChannel1Led29 = 228,

        /// <summary>
        /// For first channel of the DIY-devices led 30.
        /// </summary>
        DIYChannel1Led30 = 229,

        /// <summary>
        /// For first channel of the DIY-devices led 31.
        /// </summary>
        DIYChannel1Led31 = 230,

        /// <summary>
        /// For first channel of the DIY-devices led 32.
        /// </summary>
        DIYChannel1Led32 = 231,

        /// <summary>
        /// For first channel of the DIY-devices led 33.
        /// </summary>
        DIYChannel1Led33 = 232,

        /// <summary>
        /// For first channel of the DIY-devices led 34.
        /// </summary>
        DIYChannel1Led34 = 233,

        /// <summary>
        /// For first channel of the DIY-devices led 35.
        /// </summary>
        DIYChannel1Led35 = 234,

        /// <summary>
        /// For first channel of the DIY-devices led 36.
        /// </summary>
        DIYChannel1Led36 = 235,

        /// <summary>
        /// For first channel of the DIY-devices led 37.
        /// </summary>
        DIYChannel1Led37 = 236,

        /// <summary>
        /// For first channel of the DIY-devices led 38.
        /// </summary>
        DIYChannel1Led38 = 237,

        /// <summary>
        /// For first channel of the DIY-devices led 39.
        /// </summary>
        DIYChannel1Led39 = 238,

        /// <summary>
        /// For first channel of the DIY-devices led 40.
        /// </summary>
        DIYChannel1Led40 = 239,

        /// <summary>
        /// For first channel of the DIY-devices led 41.
        /// </summary>
        DIYChannel1Led41 = 240,

        /// <summary>
        /// For first channel of the DIY-devices led 42.
        /// </summary>
        DIYChannel1Led42 = 241,

        /// <summary>
        /// For first channel of the DIY-devices led 43.
        /// </summary>
        DIYChannel1Led43 = 242,

        /// <summary>
        /// For first channel of the DIY-devices led 44.
        /// </summary>
        DIYChannel1Led44 = 243,

        /// <summary>
        /// For first channel of the DIY-devices led 45.
        /// </summary>
        DIYChannel1Led45 = 244,

        /// <summary>
        /// For first channel of the DIY-devices led 46.
        /// </summary>
        DIYChannel1Led46 = 245,

        /// <summary>
        /// For first channel of the DIY-devices led 47.
        /// </summary>
        DIYChannel1Led47 = 246,

        /// <summary>
        /// For first channel of the DIY-devices led 48.
        /// </summary>
        DIYChannel1Led48 = 247,

        /// <summary>
        /// For first channel of the DIY-devices led 49.
        /// </summary>
        DIYChannel1Led49 = 248,

        /// <summary>
        /// For first channel of the DIY-devices led 50.
        /// </summary>
        DIYChannel1Led50 = 249,

        /// <summary>
        /// For first channel of the DIY-devices led 51.
        /// </summary>
        DIYChannel1Led51 = 250,

        /// <summary>
        /// For first channel of the DIY-devices led 52.
        /// </summary>
        DIYChannel1Led52 = 251,

        /// <summary>
        /// For first channel of the DIY-devices led 53.
        /// </summary>
        DIYChannel1Led53 = 252,

        /// <summary>
        /// For first channel of the DIY-devices led 54.
        /// </summary>
        DIYChannel1Led54 = 253,

        /// <summary>
        /// For first channel of the DIY-devices led 55.
        /// </summary>
        DIYChannel1Led55 = 254,

        /// <summary>
        /// For first channel of the DIY-devices led 56.
        /// </summary>
        DIYChannel1Led56 = 255,

        /// <summary>
        /// For first channel of the DIY-devices led 57.
        /// </summary>
        DIYChannel1Led57 = 256,

        /// <summary>
        /// For first channel of the DIY-devices led 58.
        /// </summary>
        DIYChannel1Led58 = 257,

        /// <summary>
        /// For first channel of the DIY-devices led 59.
        /// </summary>
        DIYChannel1Led59 = 258,

        /// <summary>
        /// For first channel of the DIY-devices led 60.
        /// </summary>
        DIYChannel1Led60 = 259,

        /// <summary>
        /// For first channel of the DIY-devices led 61.
        /// </summary>
        DIYChannel1Led61 = 260,

        /// <summary>
        /// For first channel of the DIY-devices led 62.
        /// </summary>
        DIYChannel1Led62 = 261,

        /// <summary>
        /// For first channel of the DIY-devices led 63.
        /// </summary>
        DIYChannel1Led63 = 262,

        /// <summary>
        /// For first channel of the DIY-devices led 64.
        /// </summary>
        DIYChannel1Led64 = 263,

        /// <summary>
        /// For first channel of the DIY-devices led 65.
        /// </summary>
        DIYChannel1Led65 = 264,

        /// <summary>
        /// For first channel of the DIY-devices led 66.
        /// </summary>
        DIYChannel1Led66 = 265,

        /// <summary>
        /// For first channel of the DIY-devices led 67.
        /// </summary>
        DIYChannel1Led67 = 266,

        /// <summary>
        /// For first channel of the DIY-devices led 68.
        /// </summary>
        DIYChannel1Led68 = 267,

        /// <summary>
        /// For first channel of the DIY-devices led 69.
        /// </summary>
        DIYChannel1Led69 = 268,

        /// <summary>
        /// For first channel of the DIY-devices led 70.
        /// </summary>
        DIYChannel1Led70 = 269,

        /// <summary>
        /// For first channel of the DIY-devices led 71.
        /// </summary>
        DIYChannel1Led71 = 270,

        /// <summary>
        /// For first channel of the DIY-devices led 72.
        /// </summary>
        DIYChannel1Led72 = 271,

        /// <summary>
        /// For first channel of the DIY-devices led 73.
        /// </summary>
        DIYChannel1Led73 = 272,

        /// <summary>
        /// For first channel of the DIY-devices led 74.
        /// </summary>
        DIYChannel1Led74 = 273,

        /// <summary>
        /// For first channel of the DIY-devices led 75.
        /// </summary>
        DIYChannel1Led75 = 274,

        /// <summary>
        /// For first channel of the DIY-devices led 76.
        /// </summary>
        DIYChannel1Led76 = 275,

        /// <summary>
        /// For first channel of the DIY-devices led 77.
        /// </summary>
        DIYChannel1Led77 = 276,

        /// <summary>
        /// For first channel of the DIY-devices led 78.
        /// </summary>
        DIYChannel1Led78 = 277,

        /// <summary>
        /// For first channel of the DIY-devices led 79.
        /// </summary>
        DIYChannel1Led79 = 278,

        /// <summary>
        /// For first channel of the DIY-devices led 80.
        /// </summary>
        DIYChannel1Led80 = 279,

        /// <summary>
        /// For first channel of the DIY-devices led 81.
        /// </summary>
        DIYChannel1Led81 = 280,

        /// <summary>
        /// For first channel of the DIY-devices led 82.
        /// </summary>
        DIYChannel1Led82 = 281,

        /// <summary>
        /// For first channel of the DIY-devices led 83.
        /// </summary>
        DIYChannel1Led83 = 282,

        /// <summary>
        /// For first channel of the DIY-devices led 84.
        /// </summary>
        DIYChannel1Led84 = 283,

        /// <summary>
        /// For first channel of the DIY-devices led 85.
        /// </summary>
        DIYChannel1Led85 = 284,

        /// <summary>
        /// For first channel of the DIY-devices led 86.
        /// </summary>
        DIYChannel1Led86 = 285,

        /// <summary>
        /// For first channel of the DIY-devices led 87.
        /// </summary>
        DIYChannel1Led87 = 286,

        /// <summary>
        /// For first channel of the DIY-devices led 88.
        /// </summary>
        DIYChannel1Led88 = 287,

        /// <summary>
        /// For first channel of the DIY-devices led 89.
        /// </summary>
        DIYChannel1Led89 = 288,

        /// <summary>
        /// For first channel of the DIY-devices led 90.
        /// </summary>
        DIYChannel1Led90 = 289,

        /// <summary>
        /// For first channel of the DIY-devices led 91.
        /// </summary>
        DIYChannel1Led91 = 290,

        /// <summary>
        /// For first channel of the DIY-devices led 92.
        /// </summary>
        DIYChannel1Led92 = 291,

        /// <summary>
        /// For first channel of the DIY-devices led 93.
        /// </summary>
        DIYChannel1Led93 = 292,

        /// <summary>
        /// For first channel of the DIY-devices led 94.
        /// </summary>
        DIYChannel1Led94 = 293,

        /// <summary>
        /// For first channel of the DIY-devices led 95.
        /// </summary>
        DIYChannel1Led95 = 294,

        /// <summary>
        /// For first channel of the DIY-devices led 96.
        /// </summary>
        DIYChannel1Led96 = 295,

        /// <summary>
        /// For first channel of the DIY-devices led 97.
        /// </summary>
        DIYChannel1Led97 = 296,

        /// <summary>
        /// For first channel of the DIY-devices led 98.
        /// </summary>
        DIYChannel1Led98 = 297,

        /// <summary>
        /// For first channel of the DIY-devices led 99.
        /// </summary>
        DIYChannel1Led99 = 298,

        /// <summary>
        /// For first channel of the DIY-devices led 100.
        /// </summary>
        DIYChannel1Led100 = 299,

        /// <summary>
        /// For first channel of the DIY-devices led 101.
        /// </summary>
        DIYChannel1Led101 = 300,

        /// <summary>
        /// For first channel of the DIY-devices led 102.
        /// </summary>
        DIYChannel1Led102 = 301,

        /// <summary>
        /// For first channel of the DIY-devices led 103.
        /// </summary>
        DIYChannel1Led103 = 302,

        /// <summary>
        /// For first channel of the DIY-devices led 104.
        /// </summary>
        DIYChannel1Led104 = 303,

        /// <summary>
        /// For first channel of the DIY-devices led 105.
        /// </summary>
        DIYChannel1Led105 = 304,

        /// <summary>
        /// For first channel of the DIY-devices led 106.
        /// </summary>
        DIYChannel1Led106 = 305,

        /// <summary>
        /// For first channel of the DIY-devices led 107.
        /// </summary>
        DIYChannel1Led107 = 306,

        /// <summary>
        /// For first channel of the DIY-devices led 108.
        /// </summary>
        DIYChannel1Led108 = 307,

        /// <summary>
        /// For first channel of the DIY-devices led 109.
        /// </summary>
        DIYChannel1Led109 = 308,

        /// <summary>
        /// For first channel of the DIY-devices led 110.
        /// </summary>
        DIYChannel1Led110 = 309,

        /// <summary>
        /// For first channel of the DIY-devices led 111.
        /// </summary>
        DIYChannel1Led111 = 310,

        /// <summary>
        /// For first channel of the DIY-devices led 112.
        /// </summary>
        DIYChannel1Led112 = 311,

        /// <summary>
        /// For first channel of the DIY-devices led 113.
        /// </summary>
        DIYChannel1Led113 = 312,

        /// <summary>
        /// For first channel of the DIY-devices led 114.
        /// </summary>
        DIYChannel1Led114 = 313,

        /// <summary>
        /// For first channel of the DIY-devices led 115.
        /// </summary>
        DIYChannel1Led115 = 314,

        /// <summary>
        /// For first channel of the DIY-devices led 116.
        /// </summary>
        DIYChannel1Led116 = 315,

        /// <summary>
        /// For first channel of the DIY-devices led 117.
        /// </summary>
        DIYChannel1Led117 = 316,

        /// <summary>
        /// For first channel of the DIY-devices led 118.
        /// </summary>
        DIYChannel1Led118 = 317,

        /// <summary>
        /// For first channel of the DIY-devices led 119.
        /// </summary>
        DIYChannel1Led119 = 318,

        /// <summary>
        /// For first channel of the DIY-devices led 120.
        /// </summary>
        DIYChannel1Led120 = 319,

        /// <summary>
        /// For first channel of the DIY-devices led 121.
        /// </summary>
        DIYChannel1Led121 = 320,

        /// <summary>
        /// For first channel of the DIY-devices led 122.
        /// </summary>
        DIYChannel1Led122 = 321,

        /// <summary>
        /// For first channel of the DIY-devices led 123.
        /// </summary>
        DIYChannel1Led123 = 322,

        /// <summary>
        /// For first channel of the DIY-devices led 124.
        /// </summary>
        DIYChannel1Led124 = 323,

        /// <summary>
        /// For first channel of the DIY-devices led 125.
        /// </summary>
        DIYChannel1Led125 = 324,

        /// <summary>
        /// For first channel of the DIY-devices led 126.
        /// </summary>
        DIYChannel1Led126 = 325,

        /// <summary>
        /// For first channel of the DIY-devices led 127.
        /// </summary>
        DIYChannel1Led127 = 326,

        /// <summary>
        /// For first channel of the DIY-devices led 128.
        /// </summary>
        DIYChannel1Led128 = 327,

        /// <summary>
        /// For first channel of the DIY-devices led 129.
        /// </summary>
        DIYChannel1Led129 = 328,

        /// <summary>
        /// For first channel of the DIY-devices led 130.
        /// </summary>
        DIYChannel1Led130 = 329,

        /// <summary>
        /// For first channel of the DIY-devices led 131.
        /// </summary>
        DIYChannel1Led131 = 330,

        /// <summary>
        /// For first channel of the DIY-devices led 132.
        /// </summary>
        DIYChannel1Led132 = 331,

        /// <summary>
        /// For first channel of the DIY-devices led 133.
        /// </summary>
        DIYChannel1Led133 = 332,

        /// <summary>
        /// For first channel of the DIY-devices led 134.
        /// </summary>
        DIYChannel1Led134 = 333,

        /// <summary>
        /// For first channel of the DIY-devices led 135.
        /// </summary>
        DIYChannel1Led135 = 334,

        /// <summary>
        /// For first channel of the DIY-devices led 136.
        /// </summary>
        DIYChannel1Led136 = 335,

        /// <summary>
        /// For first channel of the DIY-devices led 137.
        /// </summary>
        DIYChannel1Led137 = 336,

        /// <summary>
        /// For first channel of the DIY-devices led 138.
        /// </summary>
        DIYChannel1Led138 = 337,

        /// <summary>
        /// For first channel of the DIY-devices led 139.
        /// </summary>
        DIYChannel1Led139 = 338,

        /// <summary>
        /// For first channel of the DIY-devices led 140.
        /// </summary>
        DIYChannel1Led140 = 339,

        /// <summary>
        /// For first channel of the DIY-devices led 141.
        /// </summary>
        DIYChannel1Led141 = 340,

        /// <summary>
        /// For first channel of the DIY-devices led 142.
        /// </summary>
        DIYChannel1Led142 = 341,

        /// <summary>
        /// For first channel of the DIY-devices led 143.
        /// </summary>
        DIYChannel1Led143 = 342,

        /// <summary>
        /// For first channel of the DIY-devices led 144.
        /// </summary>
        DIYChannel1Led144 = 343,

        /// <summary>
        /// For first channel of the DIY-devices led 145.
        /// </summary>
        DIYChannel1Led145 = 344,

        /// <summary>
        /// For first channel of the DIY-devices led 146.
        /// </summary>
        DIYChannel1Led146 = 345,

        /// <summary>
        /// For first channel of the DIY-devices led 147.
        /// </summary>
        DIYChannel1Led147 = 346,

        /// <summary>
        /// For first channel of the DIY-devices led 148.
        /// </summary>
        DIYChannel1Led148 = 347,

        /// <summary>
        /// For first channel of the DIY-devices led 149.
        /// </summary>
        DIYChannel1Led149 = 348,

        /// <summary>
        /// For first channel of the DIY-devices led 150.
        /// </summary>
        DIYChannel1Led150 = 349,

        /// <summary>
        /// For second channel of the DIY-devices led 1.
        /// </summary>
        DIYChannel2Led1 = 350,

        /// <summary>
        /// For second channel of the DIY-devices led 2.
        /// </summary>
        DIYChannel2Led2 = 351,

        /// <summary>
        /// For second channel of the DIY-devices led 3.
        /// </summary>
        DIYChannel2Led3 = 352,

        /// <summary>
        /// For second channel of the DIY-devices led 4.
        /// </summary>
        DIYChannel2Led4 = 353,

        /// <summary>
        /// For second channel of the DIY-devices led 5.
        /// </summary>
        DIYChannel2Led5 = 354,

        /// <summary>
        /// For second channel of the DIY-devices led 6.
        /// </summary>
        DIYChannel2Led6 = 355,

        /// <summary>
        /// For second channel of the DIY-devices led 7.
        /// </summary>
        DIYChannel2Led7 = 356,

        /// <summary>
        /// For second channel of the DIY-devices led 8.
        /// </summary>
        DIYChannel2Led8 = 357,

        /// <summary>
        /// For second channel of the DIY-devices led 9.
        /// </summary>
        DIYChannel2Led9 = 358,

        /// <summary>
        /// For second channel of the DIY-devices led 10.
        /// </summary>
        DIYChannel2Led10 = 359,

        /// <summary>
        /// For second channel of the DIY-devices led 11.
        /// </summary>
        DIYChannel2Led11 = 360,

        /// <summary>
        /// For second channel of the DIY-devices led 12.
        /// </summary>
        DIYChannel2Led12 = 361,

        /// <summary>
        /// For second channel of the DIY-devices led 13.
        /// </summary>
        DIYChannel2Led13 = 362,

        /// <summary>
        /// For second channel of the DIY-devices led 14.
        /// </summary>
        DIYChannel2Led14 = 363,

        /// <summary>
        /// For second channel of the DIY-devices led 15.
        /// </summary>
        DIYChannel2Led15 = 364,

        /// <summary>
        /// For second channel of the DIY-devices led 16.
        /// </summary>
        DIYChannel2Led16 = 365,

        /// <summary>
        /// For second channel of the DIY-devices led 17.
        /// </summary>
        DIYChannel2Led17 = 366,

        /// <summary>
        /// For second channel of the DIY-devices led 18.
        /// </summary>
        DIYChannel2Led18 = 367,

        /// <summary>
        /// For second channel of the DIY-devices led 19.
        /// </summary>
        DIYChannel2Led19 = 368,

        /// <summary>
        /// For second channel of the DIY-devices led 20.
        /// </summary>
        DIYChannel2Led20 = 369,

        /// <summary>
        /// For second channel of the DIY-devices led 21.
        /// </summary>
        DIYChannel2Led21 = 370,

        /// <summary>
        /// For second channel of the DIY-devices led 22.
        /// </summary>
        DIYChannel2Led22 = 371,

        /// <summary>
        /// For second channel of the DIY-devices led 23.
        /// </summary>
        DIYChannel2Led23 = 372,

        /// <summary>
        /// For second channel of the DIY-devices led 24.
        /// </summary>
        DIYChannel2Led24 = 373,

        /// <summary>
        /// For second channel of the DIY-devices led 25.
        /// </summary>
        DIYChannel2Led25 = 374,

        /// <summary>
        /// For second channel of the DIY-devices led 26.
        /// </summary>
        DIYChannel2Led26 = 375,

        /// <summary>
        /// For second channel of the DIY-devices led 27.
        /// </summary>
        DIYChannel2Led27 = 376,

        /// <summary>
        /// For second channel of the DIY-devices led 28.
        /// </summary>
        DIYChannel2Led28 = 377,

        /// <summary>
        /// For second channel of the DIY-devices led 29.
        /// </summary>
        DIYChannel2Led29 = 378,

        /// <summary>
        /// For second channel of the DIY-devices led 30.
        /// </summary>
        DIYChannel2Led30 = 379,

        /// <summary>
        /// For second channel of the DIY-devices led 31.
        /// </summary>
        DIYChannel2Led31 = 380,

        /// <summary>
        /// For second channel of the DIY-devices led 32.
        /// </summary>
        DIYChannel2Led32 = 381,

        /// <summary>
        /// For second channel of the DIY-devices led 33.
        /// </summary>
        DIYChannel2Led33 = 382,

        /// <summary>
        /// For second channel of the DIY-devices led 34.
        /// </summary>
        DIYChannel2Led34 = 383,

        /// <summary>
        /// For second channel of the DIY-devices led 35.
        /// </summary>
        DIYChannel2Led35 = 384,

        /// <summary>
        /// For second channel of the DIY-devices led 36.
        /// </summary>
        DIYChannel2Led36 = 385,

        /// <summary>
        /// For second channel of the DIY-devices led 37.
        /// </summary>
        DIYChannel2Led37 = 386,

        /// <summary>
        /// For second channel of the DIY-devices led 38.
        /// </summary>
        DIYChannel2Led38 = 387,

        /// <summary>
        /// For second channel of the DIY-devices led 39.
        /// </summary>
        DIYChannel2Led39 = 388,

        /// <summary>
        /// For second channel of the DIY-devices led 40.
        /// </summary>
        DIYChannel2Led40 = 389,

        /// <summary>
        /// For second channel of the DIY-devices led 41.
        /// </summary>
        DIYChannel2Led41 = 390,

        /// <summary>
        /// For second channel of the DIY-devices led 42.
        /// </summary>
        DIYChannel2Led42 = 391,

        /// <summary>
        /// For second channel of the DIY-devices led 43.
        /// </summary>
        DIYChannel2Led43 = 392,

        /// <summary>
        /// For second channel of the DIY-devices led 44.
        /// </summary>
        DIYChannel2Led44 = 393,

        /// <summary>
        /// For second channel of the DIY-devices led 45.
        /// </summary>
        DIYChannel2Led45 = 394,

        /// <summary>
        /// For second channel of the DIY-devices led 46.
        /// </summary>
        DIYChannel2Led46 = 395,

        /// <summary>
        /// For second channel of the DIY-devices led 47.
        /// </summary>
        DIYChannel2Led47 = 396,

        /// <summary>
        /// For second channel of the DIY-devices led 48.
        /// </summary>
        DIYChannel2Led48 = 397,

        /// <summary>
        /// For second channel of the DIY-devices led 49.
        /// </summary>
        DIYChannel2Led49 = 398,

        /// <summary>
        /// For second channel of the DIY-devices led 50.
        /// </summary>
        DIYChannel2Led50 = 399,

        /// <summary>
        /// For second channel of the DIY-devices led 51.
        /// </summary>
        DIYChannel2Led51 = 400,

        /// <summary>
        /// For second channel of the DIY-devices led 52.
        /// </summary>
        DIYChannel2Led52 = 401,

        /// <summary>
        /// For second channel of the DIY-devices led 53.
        /// </summary>
        DIYChannel2Led53 = 402,

        /// <summary>
        /// For second channel of the DIY-devices led 54.
        /// </summary>
        DIYChannel2Led54 = 403,

        /// <summary>
        /// For second channel of the DIY-devices led 55.
        /// </summary>
        DIYChannel2Led55 = 404,

        /// <summary>
        /// For second channel of the DIY-devices led 56.
        /// </summary>
        DIYChannel2Led56 = 405,

        /// <summary>
        /// For second channel of the DIY-devices led 57.
        /// </summary>
        DIYChannel2Led57 = 406,

        /// <summary>
        /// For second channel of the DIY-devices led 58.
        /// </summary>
        DIYChannel2Led58 = 407,

        /// <summary>
        /// For second channel of the DIY-devices led 59.
        /// </summary>
        DIYChannel2Led59 = 408,

        /// <summary>
        /// For second channel of the DIY-devices led 60.
        /// </summary>
        DIYChannel2Led60 = 409,

        /// <summary>
        /// For second channel of the DIY-devices led 61.
        /// </summary>
        DIYChannel2Led61 = 410,

        /// <summary>
        /// For second channel of the DIY-devices led 62.
        /// </summary>
        DIYChannel2Led62 = 411,

        /// <summary>
        /// For second channel of the DIY-devices led 63.
        /// </summary>
        DIYChannel2Led63 = 412,

        /// <summary>
        /// For second channel of the DIY-devices led 64.
        /// </summary>
        DIYChannel2Led64 = 413,

        /// <summary>
        /// For second channel of the DIY-devices led 65.
        /// </summary>
        DIYChannel2Led65 = 414,

        /// <summary>
        /// For second channel of the DIY-devices led 66.
        /// </summary>
        DIYChannel2Led66 = 415,

        /// <summary>
        /// For second channel of the DIY-devices led 67.
        /// </summary>
        DIYChannel2Led67 = 416,

        /// <summary>
        /// For second channel of the DIY-devices led 68.
        /// </summary>
        DIYChannel2Led68 = 417,

        /// <summary>
        /// For second channel of the DIY-devices led 69.
        /// </summary>
        DIYChannel2Led69 = 418,

        /// <summary>
        /// For second channel of the DIY-devices led 70.
        /// </summary>
        DIYChannel2Led70 = 419,

        /// <summary>
        /// For second channel of the DIY-devices led 71.
        /// </summary>
        DIYChannel2Led71 = 420,

        /// <summary>
        /// For second channel of the DIY-devices led 72.
        /// </summary>
        DIYChannel2Led72 = 421,

        /// <summary>
        /// For second channel of the DIY-devices led 73.
        /// </summary>
        DIYChannel2Led73 = 422,

        /// <summary>
        /// For second channel of the DIY-devices led 74.
        /// </summary>
        DIYChannel2Led74 = 423,

        /// <summary>
        /// For second channel of the DIY-devices led 75.
        /// </summary>
        DIYChannel2Led75 = 424,

        /// <summary>
        /// For second channel of the DIY-devices led 76.
        /// </summary>
        DIYChannel2Led76 = 425,

        /// <summary>
        /// For second channel of the DIY-devices led 77.
        /// </summary>
        DIYChannel2Led77 = 426,

        /// <summary>
        /// For second channel of the DIY-devices led 78.
        /// </summary>
        DIYChannel2Led78 = 427,

        /// <summary>
        /// For second channel of the DIY-devices led 79.
        /// </summary>
        DIYChannel2Led79 = 428,

        /// <summary>
        /// For second channel of the DIY-devices led 80.
        /// </summary>
        DIYChannel2Led80 = 429,

        /// <summary>
        /// For second channel of the DIY-devices led 81.
        /// </summary>
        DIYChannel2Led81 = 430,

        /// <summary>
        /// For second channel of the DIY-devices led 82.
        /// </summary>
        DIYChannel2Led82 = 431,

        /// <summary>
        /// For second channel of the DIY-devices led 83.
        /// </summary>
        DIYChannel2Led83 = 432,

        /// <summary>
        /// For second channel of the DIY-devices led 84.
        /// </summary>
        DIYChannel2Led84 = 433,

        /// <summary>
        /// For second channel of the DIY-devices led 85.
        /// </summary>
        DIYChannel2Led85 = 434,

        /// <summary>
        /// For second channel of the DIY-devices led 86.
        /// </summary>
        DIYChannel2Led86 = 435,

        /// <summary>
        /// For second channel of the DIY-devices led 87.
        /// </summary>
        DIYChannel2Led87 = 436,

        /// <summary>
        /// For second channel of the DIY-devices led 88.
        /// </summary>
        DIYChannel2Led88 = 437,

        /// <summary>
        /// For second channel of the DIY-devices led 89.
        /// </summary>
        DIYChannel2Led89 = 438,

        /// <summary>
        /// For second channel of the DIY-devices led 90.
        /// </summary>
        DIYChannel2Led90 = 439,

        /// <summary>
        /// For second channel of the DIY-devices led 91.
        /// </summary>
        DIYChannel2Led91 = 440,

        /// <summary>
        /// For second channel of the DIY-devices led 92.
        /// </summary>
        DIYChannel2Led92 = 441,

        /// <summary>
        /// For second channel of the DIY-devices led 93.
        /// </summary>
        DIYChannel2Led93 = 442,

        /// <summary>
        /// For second channel of the DIY-devices led 94.
        /// </summary>
        DIYChannel2Led94 = 443,

        /// <summary>
        /// For second channel of the DIY-devices led 95.
        /// </summary>
        DIYChannel2Led95 = 444,

        /// <summary>
        /// For second channel of the DIY-devices led 96.
        /// </summary>
        DIYChannel2Led96 = 445,

        /// <summary>
        /// For second channel of the DIY-devices led 97.
        /// </summary>
        DIYChannel2Led97 = 446,

        /// <summary>
        /// For second channel of the DIY-devices led 98.
        /// </summary>
        DIYChannel2Led98 = 447,

        /// <summary>
        /// For second channel of the DIY-devices led 99.
        /// </summary>
        DIYChannel2Led99 = 448,

        /// <summary>
        /// For second channel of the DIY-devices led 100.
        /// </summary>
        DIYChannel2Led100 = 449,

        /// <summary>
        /// For second channel of the DIY-devices led 101.
        /// </summary>
        DIYChannel2Led101 = 450,

        /// <summary>
        /// For second channel of the DIY-devices led 102.
        /// </summary>
        DIYChannel2Led102 = 451,

        /// <summary>
        /// For second channel of the DIY-devices led 103.
        /// </summary>
        DIYChannel2Led103 = 452,

        /// <summary>
        /// For second channel of the DIY-devices led 104.
        /// </summary>
        DIYChannel2Led104 = 453,

        /// <summary>
        /// For second channel of the DIY-devices led 105.
        /// </summary>
        DIYChannel2Led105 = 454,

        /// <summary>
        /// For second channel of the DIY-devices led 106.
        /// </summary>
        DIYChannel2Led106 = 455,

        /// <summary>
        /// For second channel of the DIY-devices led 107.
        /// </summary>
        DIYChannel2Led107 = 456,

        /// <summary>
        /// For second channel of the DIY-devices led 108.
        /// </summary>
        DIYChannel2Led108 = 457,

        /// <summary>
        /// For second channel of the DIY-devices led 109.
        /// </summary>
        DIYChannel2Led109 = 458,

        /// <summary>
        /// For second channel of the DIY-devices led 110.
        /// </summary>
        DIYChannel2Led110 = 459,

        /// <summary>
        /// For second channel of the DIY-devices led 111.
        /// </summary>
        DIYChannel2Led111 = 460,

        /// <summary>
        /// For second channel of the DIY-devices led 112.
        /// </summary>
        DIYChannel2Led112 = 461,

        /// <summary>
        /// For second channel of the DIY-devices led 113.
        /// </summary>
        DIYChannel2Led113 = 462,

        /// <summary>
        /// For second channel of the DIY-devices led 114.
        /// </summary>
        DIYChannel2Led114 = 463,

        /// <summary>
        /// For second channel of the DIY-devices led 115.
        /// </summary>
        DIYChannel2Led115 = 464,

        /// <summary>
        /// For second channel of the DIY-devices led 116.
        /// </summary>
        DIYChannel2Led116 = 465,

        /// <summary>
        /// For second channel of the DIY-devices led 117.
        /// </summary>
        DIYChannel2Led117 = 466,

        /// <summary>
        /// For second channel of the DIY-devices led 118.
        /// </summary>
        DIYChannel2Led118 = 467,

        /// <summary>
        /// For second channel of the DIY-devices led 119.
        /// </summary>
        DIYChannel2Led119 = 468,

        /// <summary>
        /// For second channel of the DIY-devices led 120.
        /// </summary>
        DIYChannel2Led120 = 469,

        /// <summary>
        /// For second channel of the DIY-devices led 121.
        /// </summary>
        DIYChannel2Led121 = 470,

        /// <summary>
        /// For second channel of the DIY-devices led 122.
        /// </summary>
        DIYChannel2Led122 = 471,

        /// <summary>
        /// For second channel of the DIY-devices led 123.
        /// </summary>
        DIYChannel2Led123 = 472,

        /// <summary>
        /// For second channel of the DIY-devices led 124.
        /// </summary>
        DIYChannel2Led124 = 473,

        /// <summary>
        /// For second channel of the DIY-devices led 125.
        /// </summary>
        DIYChannel2Led125 = 474,

        /// <summary>
        /// For second channel of the DIY-devices led 126.
        /// </summary>
        DIYChannel2Led126 = 475,

        /// <summary>
        /// For second channel of the DIY-devices led 127.
        /// </summary>
        DIYChannel2Led127 = 476,

        /// <summary>
        /// For second channel of the DIY-devices led 128.
        /// </summary>
        DIYChannel2Led128 = 477,

        /// <summary>
        /// For second channel of the DIY-devices led 129.
        /// </summary>
        DIYChannel2Led129 = 478,

        /// <summary>
        /// For second channel of the DIY-devices led 130.
        /// </summary>
        DIYChannel2Led130 = 479,

        /// <summary>
        /// For second channel of the DIY-devices led 131.
        /// </summary>
        DIYChannel2Led131 = 480,

        /// <summary>
        /// For second channel of the DIY-devices led 132.
        /// </summary>
        DIYChannel2Led132 = 481,

        /// <summary>
        /// For second channel of the DIY-devices led 133.
        /// </summary>
        DIYChannel2Led133 = 482,

        /// <summary>
        /// For second channel of the DIY-devices led 134.
        /// </summary>
        DIYChannel2Led134 = 483,

        /// <summary>
        /// For second channel of the DIY-devices led 135.
        /// </summary>
        DIYChannel2Led135 = 484,

        /// <summary>
        /// For second channel of the DIY-devices led 136.
        /// </summary>
        DIYChannel2Led136 = 485,

        /// <summary>
        /// For second channel of the DIY-devices led 137.
        /// </summary>
        DIYChannel2Led137 = 486,

        /// <summary>
        /// For second channel of the DIY-devices led 138.
        /// </summary>
        DIYChannel2Led138 = 487,

        /// <summary>
        /// For second channel of the DIY-devices led 139.
        /// </summary>
        DIYChannel2Led139 = 488,

        /// <summary>
        /// For second channel of the DIY-devices led 140.
        /// </summary>
        DIYChannel2Led140 = 489,

        /// <summary>
        /// For second channel of the DIY-devices led 141.
        /// </summary>
        DIYChannel2Led141 = 490,

        /// <summary>
        /// For second channel of the DIY-devices led 142.
        /// </summary>
        DIYChannel2Led142 = 491,

        /// <summary>
        /// For second channel of the DIY-devices led 143.
        /// </summary>
        DIYChannel2Led143 = 492,

        /// <summary>
        /// For second channel of the DIY-devices led 144.
        /// </summary>
        DIYChannel2Led144 = 493,

        /// <summary>
        /// For second channel of the DIY-devices led 145.
        /// </summary>
        DIYChannel2Led145 = 494,

        /// <summary>
        /// For second channel of the DIY-devices led 146.
        /// </summary>
        DIYChannel2Led146 = 495,

        /// <summary>
        /// For second channel of the DIY-devices led 147.
        /// </summary>
        DIYChannel2Led147 = 496,

        /// <summary>
        /// For second channel of the DIY-devices led 148.
        /// </summary>
        DIYChannel2Led148 = 497,

        /// <summary>
        /// For second channel of the DIY-devices led 149.
        /// </summary>
        DIYChannel2Led149 = 498,

        /// <summary>
        /// For second channel of the DIY-devices led 150.
        /// </summary>
        DIYChannel2Led150 = 499,

        /// <summary>
        /// Reserved for custom led 1.
        /// </summary>
        CustomOem1 = 500,

        /// <summary>
        /// Reserved for custom led 2.
        /// </summary>
        CustomOem2 = 501,

        /// <summary>
        /// Reserved for custom led 3.
        /// </summary>
        CustomOem3 = 502,

        /// <summary>
        /// Reserved for custom led 4.
        /// </summary>
        CustomOem4 = 503,

        /// <summary>
        /// Reserved for custom led 5.
        /// </summary>
        CustomOem5 = 504,

        /// <summary>
        /// Reserved for custom led 6.
        /// </summary>
        CustomOem6 = 505,

        /// <summary>
        /// Reserved for custom led 7.
        /// </summary>
        CustomOem7 = 506,

        /// <summary>
        /// Reserved for custom led 8.
        /// </summary>
        CustomOem8 = 507,

        /// <summary>
        /// Reserved for custom led 9.
        /// </summary>
        CustomOem9 = 508,

        /// <summary>
        /// Reserved for custom led 10.
        /// </summary>
        CustomOem10 = 509,

        /// <summary>
        /// Reserved for custom led 11.
        /// </summary>
        CustomOem11 = 510,

        /// <summary>
        /// Reserved for custom led 12.
        /// </summary>
        CustomOem12 = 511,

        /// <summary>
        /// Reserved for custom led 13.
        /// </summary>
        CustomOem13 = 512,

        /// <summary>
        /// Reserved for custom led 14.
        /// </summary>
        CustomOem14 = 513,

        /// <summary>
        /// Reserved for custom led 15.
        /// </summary>
        CustomOem15 = 514,

        /// <summary>
        /// Reserved for custom led 16.
        /// </summary>
        CustomOem16 = 515,

        /// <summary>
        /// Reserved for custom led 17.
        /// </summary>
        CustomOem17 = 516,

        /// <summary>
        /// Reserved for custom led 18.
        /// </summary>
        CustomOem18 = 517,

        /// <summary>
        /// Reserved for custom led 19.
        /// </summary>
        CustomOem19 = 518,

        /// <summary>
        /// Reserved for custom led 20.
        /// </summary>
        CustomOem20 = 519,

        /// <summary>
        /// Reserved for custom led 21.
        /// </summary>
        CustomOem21 = 520,

        /// <summary>
        /// Reserved for custom led 22.
        /// </summary>
        CustomOem22 = 521,

        /// <summary>
        /// Reserved for custom led 23.
        /// </summary>
        CustomOem23 = 522,

        /// <summary>
        /// Reserved for custom led 24.
        /// </summary>
        CustomOem24 = 523,

        /// <summary>
        /// Reserved for custom led 25.
        /// </summary>
        CustomOem25 = 524,

        /// <summary>
        /// Reserved for custom led 26.
        /// </summary>
        CustomOem26 = 525,

        /// <summary>
        /// Reserved for custom led 27.
        /// </summary>
        CustomOem27 = 526,

        /// <summary>
        /// Reserved for custom led 28.
        /// </summary>
        CustomOem28 = 527,

        /// <summary>
        /// Reserved for custom led 29.
        /// </summary>
        CustomOem29 = 528,

        /// <summary>
        /// Reserved for custom led 30.
        /// </summary>
        CustomOem30 = 529,

        /// <summary>
        /// Reserved for custom led 31.
        /// </summary>
        CustomOem31 = 530,

        /// <summary>
        /// Reserved for custom led 32.
        /// </summary>
        CustomOem32 = 531,

        /// <summary>
        /// Reserved for custom led 33.
        /// </summary>
        CustomOem33 = 532,

        /// <summary>
        /// Reserved for custom led 34.
        /// </summary>
        CustomOem34 = 533,

        /// <summary>
        /// Reserved for custom led 35.
        /// </summary>
        CustomOem35 = 534,

        /// <summary>
        /// Reserved for custom led 36.
        /// </summary>
        CustomOem36 = 535,

        /// <summary>
        /// Reserved for custom led 37.
        /// </summary>
        CustomOem37 = 536,

        /// <summary>
        /// Reserved for custom led 38.
        /// </summary>
        CustomOem38 = 537,

        /// <summary>
        /// Reserved for custom led 39.
        /// </summary>
        CustomOem39 = 538,

        /// <summary>
        /// Reserved for custom led 40.
        /// </summary>
        CustomOem40 = 539,

        /// <summary>
        /// Reserved for custom led 41.
        /// </summary>
        CustomOem41 = 540,

        /// <summary>
        /// Reserved for custom led 42.
        /// </summary>
        CustomOem42 = 541,

        /// <summary>
        /// Reserved for custom led 43.
        /// </summary>
        CustomOem43 = 542,

        /// <summary>
        /// Reserved for custom led 44.
        /// </summary>
        CustomOem44 = 543,

        /// <summary>
        /// Reserved for custom led 45.
        /// </summary>
        CustomOem45 = 544,

        /// <summary>
        /// Reserved for custom led 46.
        /// </summary>
        CustomOem46 = 545,

        /// <summary>
        /// Reserved for custom led 47.
        /// </summary>
        CustomOem47 = 546,

        /// <summary>
        /// Reserved for custom led 48.
        /// </summary>
        CustomOem48 = 547,

        /// <summary>
        /// Reserved for custom led 49.
        /// </summary>
        CustomOem49 = 548,

        /// <summary>
        /// Reserved for custom led 50.
        /// </summary>
        CustomOem50 = 549,

        /// <summary>
        /// Reserved for custom led 51.
        /// </summary>
        CustomOem51 = 550,

        /// <summary>
        /// Reserved for custom led 52.
        /// </summary>
        CustomOem52 = 551,

        /// <summary>
        /// Reserved for custom led 53.
        /// </summary>
        CustomOem53 = 552,

        /// <summary>
        /// Reserved for custom led 54.
        /// </summary>
        CustomOem54 = 553,

        /// <summary>
        /// Reserved for custom led 55.
        /// </summary>
        CustomOem55 = 554,

        /// <summary>
        /// Reserved for custom led 56.
        /// </summary>
        CustomOem56 = 555,

        /// <summary>
        /// Reserved for custom led 57.
        /// </summary>
        CustomOem57 = 556,

        /// <summary>
        /// Reserved for custom led 58.
        /// </summary>
        CustomOem58 = 557,

        /// <summary>
        /// Reserved for custom led 59.
        /// </summary>
        CustomOem59 = 558,

        /// <summary>
        /// Reserved for custom led 60.
        /// </summary>
        CustomOem60 = 559,

        /// <summary>
        /// Reserved for custom led 61.
        /// </summary>
        CustomOem61 = 560,

        /// <summary>
        /// Reserved for custom led 62.
        /// </summary>
        CustomOem62 = 561,

        /// <summary>
        /// Reserved for custom led 63.
        /// </summary>
        CustomOem63 = 562,

        /// <summary>
        /// Reserved for custom led 64.
        /// </summary>
        CustomOem64 = 563,

        /// <summary>
        /// Reserved for custom led 65.
        /// </summary>
        CustomOem65 = 564,

        /// <summary>
        /// Reserved for custom led 66.
        /// </summary>
        CustomOem66 = 565,

        /// <summary>
        /// Reserved for custom led 67.
        /// </summary>
        CustomOem67 = 566,

        /// <summary>
        /// Reserved for custom led 68.
        /// </summary>
        CustomOem68 = 567,

        /// <summary>
        /// Reserved for custom led 69.
        /// </summary>
        CustomOem69 = 568,

        /// <summary>
        /// Reserved for custom led 70.
        /// </summary>
        CustomOem70 = 569,

        /// <summary>
        /// Reserved for custom led 71.
        /// </summary>
        CustomOem71 = 570,

        /// <summary>
        /// Reserved for custom led 72.
        /// </summary>
        CustomOem72 = 571,

        /// <summary>
        /// Reserved for custom led 73.
        /// </summary>
        CustomOem73 = 572,

        /// <summary>
        /// Reserved for custom led 74.
        /// </summary>
        CustomOem74 = 573,

        /// <summary>
        /// Reserved for custom led 75.
        /// </summary>
        CustomOem75 = 574,

        /// <summary>
        /// Reserved for custom led 76.
        /// </summary>
        CustomOem76 = 575,

        /// <summary>
        /// Reserved for custom led 77.
        /// </summary>
        CustomOem77 = 576,

        /// <summary>
        /// Reserved for custom led 78.
        /// </summary>
        CustomOem78 = 577,

        /// <summary>
        /// Reserved for custom led 79.
        /// </summary>
        CustomOem79 = 578,

        /// <summary>
        /// Reserved for custom led 80.
        /// </summary>
        CustomOem80 = 579,

        /// <summary>
        /// Reserved for custom led 81.
        /// </summary>
        CustomOem81 = 580,

        /// <summary>
        /// Reserved for custom led 82.
        /// </summary>
        CustomOem82 = 581,

        /// <summary>
        /// Reserved for custom led 83.
        /// </summary>
        CustomOem83 = 582,

        /// <summary>
        /// Reserved for custom led 84.
        /// </summary>
        CustomOem84 = 583,

        /// <summary>
        /// Reserved for custom led 85.
        /// </summary>
        CustomOem85 = 584,

        /// <summary>
        /// Reserved for custom led 86.
        /// </summary>
        CustomOem86 = 585,

        /// <summary>
        /// Reserved for custom led 87.
        /// </summary>
        CustomOem87 = 586,

        /// <summary>
        /// Reserved for custom led 88.
        /// </summary>
        CustomOem88 = 587,

        /// <summary>
        /// Reserved for custom led 89.
        /// </summary>
        CustomOem89 = 588,

        /// <summary>
        /// Reserved for custom led 90.
        /// </summary>
        CustomOem90 = 589,

        /// <summary>
        /// Reserved for custom led 91.
        /// </summary>
        CustomOem91 = 590,

        /// <summary>
        /// Reserved for custom led 92.
        /// </summary>
        CustomOem92 = 591,

        /// <summary>
        /// Reserved for custom led 93.
        /// </summary>
        CustomOem93 = 592,

        /// <summary>
        /// Reserved for custom led 94.
        /// </summary>
        CustomOem94 = 593,

        /// <summary>
        /// Reserved for custom led 95.
        /// </summary>
        CustomOem95 = 594,

        /// <summary>
        /// Reserved for custom led 96.
        /// </summary>
        CustomOem96 = 595,

        /// <summary>
        /// Reserved for custom led 97.
        /// </summary>
        CustomOem97 = 596,

        /// <summary>
        /// Reserved for custom led 98.
        /// </summary>
        CustomOem98 = 597,

        /// <summary>
        /// Reserved for custom led 99.
        /// </summary>
        CustomOem99 = 598,

        /// <summary>
        /// Reserved for custom led 100.
        /// </summary>
        CustomOem100 = 599,

        /// <summary>
        /// For memory module led 1.
        /// </summary>
        MemoryModule1 = 600,

        /// <summary>
        /// For memory module led 2.
        /// </summary>
        MemoryModule2 = 601,

        /// <summary>
        /// For memory module led 3.
        /// </summary>
        MemoryModule3 = 602,

        /// <summary>
        /// For memory module led 4.
        /// </summary>
        MemoryModule4 = 603,

        /// <summary>
        /// For memory module led 5.
        /// </summary>
        MemoryModule5 = 604,

        /// <summary>
        /// For memory module led 6.
        /// </summary>
        MemoryModule6 = 605,

        /// <summary>
        /// For memory module led 7.
        /// </summary>
        MemoryModule7 = 606,

        /// <summary>
        /// For memory module led 8.
        /// </summary>
        MemoryModule8 = 607,

        /// <summary>
        /// For memory module led 9.
        /// </summary>
        MemoryModule9 = 608,

        /// <summary>
        /// For memory module led 10.
        /// </summary>
        MemoryModule10 = 609,

        /// <summary>
        /// For memory module led 11.
        /// </summary>
        MemoryModule11 = 610,

        /// <summary>
        /// For memory module led 12.
        /// </summary>
        MemoryModule12 = 611,

        /// <summary>
        /// For third channel of the DIY-devices led 1.
        /// </summary>
        DIYChannel3Led1 = 612,

        /// <summary>
        /// For third channel of the DIY-devices led 2.
        /// </summary>
        DIYChannel3Led2 = 613,

        /// <summary>
        /// For third channel of the DIY-devices led 3.
        /// </summary>
        DIYChannel3Led3 = 614,

        /// <summary>
        /// For third channel of the DIY-devices led 4.
        /// </summary>
        DIYChannel3Led4 = 615,

        /// <summary>
        /// For third channel of the DIY-devices led 5.
        /// </summary>
        DIYChannel3Led5 = 616,

        /// <summary>
        /// For third channel of the DIY-devices led 6.
        /// </summary>
        DIYChannel3Led6 = 617,

        /// <summary>
        /// For third channel of the DIY-devices led 7.
        /// </summary>
        DIYChannel3Led7 = 618,

        /// <summary>
        /// For third channel of the DIY-devices led 8.
        /// </summary>
        DIYChannel3Led8 = 619,

        /// <summary>
        /// For third channel of the DIY-devices led 9.
        /// </summary>
        DIYChannel3Led9 = 620,

        /// <summary>
        /// For third channel of the DIY-devices led 10.
        /// </summary>
        DIYChannel3Led10 = 621,

        /// <summary>
        /// For third channel of the DIY-devices led 11.
        /// </summary>
        DIYChannel3Led11 = 622,

        /// <summary>
        /// For third channel of the DIY-devices led 12.
        /// </summary>
        DIYChannel3Led12 = 623,

        /// <summary>
        /// For third channel of the DIY-devices led 13.
        /// </summary>
        DIYChannel3Led13 = 624,

        /// <summary>
        /// For third channel of the DIY-devices led 14.
        /// </summary>
        DIYChannel3Led14 = 625,

        /// <summary>
        /// For third channel of the DIY-devices led 15.
        /// </summary>
        DIYChannel3Led15 = 626,

        /// <summary>
        /// For third channel of the DIY-devices led 16.
        /// </summary>
        DIYChannel3Led16 = 627,

        /// <summary>
        /// For third channel of the DIY-devices led 17.
        /// </summary>
        DIYChannel3Led17 = 628,

        /// <summary>
        /// For third channel of the DIY-devices led 18.
        /// </summary>
        DIYChannel3Led18 = 629,

        /// <summary>
        /// For third channel of the DIY-devices led 19.
        /// </summary>
        DIYChannel3Led19 = 630,

        /// <summary>
        /// For third channel of the DIY-devices led 20.
        /// </summary>
        DIYChannel3Led20 = 631,

        /// <summary>
        /// For third channel of the DIY-devices led 21.
        /// </summary>
        DIYChannel3Led21 = 632,

        /// <summary>
        /// For third channel of the DIY-devices led 22.
        /// </summary>
        DIYChannel3Led22 = 633,

        /// <summary>
        /// For third channel of the DIY-devices led 23.
        /// </summary>
        DIYChannel3Led23 = 634,

        /// <summary>
        /// For third channel of the DIY-devices led 24.
        /// </summary>
        DIYChannel3Led24 = 635,

        /// <summary>
        /// For third channel of the DIY-devices led 25.
        /// </summary>
        DIYChannel3Led25 = 636,

        /// <summary>
        /// For third channel of the DIY-devices led 26.
        /// </summary>
        DIYChannel3Led26 = 637,

        /// <summary>
        /// For third channel of the DIY-devices led 27.
        /// </summary>
        DIYChannel3Led27 = 638,

        /// <summary>
        /// For third channel of the DIY-devices led 28.
        /// </summary>
        DIYChannel3Led28 = 639,

        /// <summary>
        /// For third channel of the DIY-devices led 29.
        /// </summary>
        DIYChannel3Led29 = 640,

        /// <summary>
        /// For third channel of the DIY-devices led 30.
        /// </summary>
        DIYChannel3Led30 = 641,

        /// <summary>
        /// For third channel of the DIY-devices led 31.
        /// </summary>
        DIYChannel3Led31 = 642,

        /// <summary>
        /// For third channel of the DIY-devices led 32.
        /// </summary>
        DIYChannel3Led32 = 643,

        /// <summary>
        /// For third channel of the DIY-devices led 33.
        /// </summary>
        DIYChannel3Led33 = 644,

        /// <summary>
        /// For third channel of the DIY-devices led 34.
        /// </summary>
        DIYChannel3Led34 = 645,

        /// <summary>
        /// For third channel of the DIY-devices led 35.
        /// </summary>
        DIYChannel3Led35 = 646,

        /// <summary>
        /// For third channel of the DIY-devices led 36.
        /// </summary>
        DIYChannel3Led36 = 647,

        /// <summary>
        /// For third channel of the DIY-devices led 37.
        /// </summary>
        DIYChannel3Led37 = 648,

        /// <summary>
        /// For third channel of the DIY-devices led 38.
        /// </summary>
        DIYChannel3Led38 = 649,

        /// <summary>
        /// For third channel of the DIY-devices led 39.
        /// </summary>
        DIYChannel3Led39 = 650,

        /// <summary>
        /// For third channel of the DIY-devices led 40.
        /// </summary>
        DIYChannel3Led40 = 651,

        /// <summary>
        /// For third channel of the DIY-devices led 41.
        /// </summary>
        DIYChannel3Led41 = 652,

        /// <summary>
        /// For third channel of the DIY-devices led 42.
        /// </summary>
        DIYChannel3Led42 = 653,

        /// <summary>
        /// For third channel of the DIY-devices led 43.
        /// </summary>
        DIYChannel3Led43 = 654,

        /// <summary>
        /// For third channel of the DIY-devices led 44.
        /// </summary>
        DIYChannel3Led44 = 655,

        /// <summary>
        /// For third channel of the DIY-devices led 45.
        /// </summary>
        DIYChannel3Led45 = 656,

        /// <summary>
        /// For third channel of the DIY-devices led 46.
        /// </summary>
        DIYChannel3Led46 = 657,

        /// <summary>
        /// For third channel of the DIY-devices led 47.
        /// </summary>
        DIYChannel3Led47 = 658,

        /// <summary>
        /// For third channel of the DIY-devices led 48.
        /// </summary>
        DIYChannel3Led48 = 659,

        /// <summary>
        /// For third channel of the DIY-devices led 49.
        /// </summary>
        DIYChannel3Led49 = 660,

        /// <summary>
        /// For third channel of the DIY-devices led 50.
        /// </summary>
        DIYChannel3Led50 = 661,

        /// <summary>
        /// For third channel of the DIY-devices led 51.
        /// </summary>
        DIYChannel3Led51 = 662,

        /// <summary>
        /// For third channel of the DIY-devices led 52.
        /// </summary>
        DIYChannel3Led52 = 663,

        /// <summary>
        /// For third channel of the DIY-devices led 53.
        /// </summary>
        DIYChannel3Led53 = 664,

        /// <summary>
        /// For third channel of the DIY-devices led 54.
        /// </summary>
        DIYChannel3Led54 = 665,

        /// <summary>
        /// For third channel of the DIY-devices led 55.
        /// </summary>
        DIYChannel3Led55 = 666,

        /// <summary>
        /// For third channel of the DIY-devices led 56.
        /// </summary>
        DIYChannel3Led56 = 667,

        /// <summary>
        /// For third channel of the DIY-devices led 57.
        /// </summary>
        DIYChannel3Led57 = 668,

        /// <summary>
        /// For third channel of the DIY-devices led 58.
        /// </summary>
        DIYChannel3Led58 = 669,

        /// <summary>
        /// For third channel of the DIY-devices led 59.
        /// </summary>
        DIYChannel3Led59 = 670,

        /// <summary>
        /// For third channel of the DIY-devices led 60.
        /// </summary>
        DIYChannel3Led60 = 671,

        /// <summary>
        /// For third channel of the DIY-devices led 61.
        /// </summary>
        DIYChannel3Led61 = 672,

        /// <summary>
        /// For third channel of the DIY-devices led 62.
        /// </summary>
        DIYChannel3Led62 = 673,

        /// <summary>
        /// For third channel of the DIY-devices led 63.
        /// </summary>
        DIYChannel3Led63 = 674,

        /// <summary>
        /// For third channel of the DIY-devices led 64.
        /// </summary>
        DIYChannel3Led64 = 675,

        /// <summary>
        /// For third channel of the DIY-devices led 65.
        /// </summary>
        DIYChannel3Led65 = 676,

        /// <summary>
        /// For third channel of the DIY-devices led 66.
        /// </summary>
        DIYChannel3Led66 = 677,

        /// <summary>
        /// For third channel of the DIY-devices led 67.
        /// </summary>
        DIYChannel3Led67 = 678,

        /// <summary>
        /// For third channel of the DIY-devices led 68.
        /// </summary>
        DIYChannel3Led68 = 679,

        /// <summary>
        /// For third channel of the DIY-devices led 69.
        /// </summary>
        DIYChannel3Led69 = 680,

        /// <summary>
        /// For third channel of the DIY-devices led 70.
        /// </summary>
        DIYChannel3Led70 = 681,

        /// <summary>
        /// For third channel of the DIY-devices led 71.
        /// </summary>
        DIYChannel3Led71 = 682,

        /// <summary>
        /// For third channel of the DIY-devices led 72.
        /// </summary>
        DIYChannel3Led72 = 683,

        /// <summary>
        /// For third channel of the DIY-devices led 73.
        /// </summary>
        DIYChannel3Led73 = 684,

        /// <summary>
        /// For third channel of the DIY-devices led 74.
        /// </summary>
        DIYChannel3Led74 = 685,

        /// <summary>
        /// For third channel of the DIY-devices led 75.
        /// </summary>
        DIYChannel3Led75 = 686,

        /// <summary>
        /// For third channel of the DIY-devices led 76.
        /// </summary>
        DIYChannel3Led76 = 687,

        /// <summary>
        /// For third channel of the DIY-devices led 77.
        /// </summary>
        DIYChannel3Led77 = 688,

        /// <summary>
        /// For third channel of the DIY-devices led 78.
        /// </summary>
        DIYChannel3Led78 = 689,

        /// <summary>
        /// For third channel of the DIY-devices led 79.
        /// </summary>
        DIYChannel3Led79 = 690,

        /// <summary>
        /// For third channel of the DIY-devices led 80.
        /// </summary>
        DIYChannel3Led80 = 691,

        /// <summary>
        /// For third channel of the DIY-devices led 81.
        /// </summary>
        DIYChannel3Led81 = 692,

        /// <summary>
        /// For third channel of the DIY-devices led 82.
        /// </summary>
        DIYChannel3Led82 = 693,

        /// <summary>
        /// For third channel of the DIY-devices led 83.
        /// </summary>
        DIYChannel3Led83 = 694,

        /// <summary>
        /// For third channel of the DIY-devices led 84.
        /// </summary>
        DIYChannel3Led84 = 695,

        /// <summary>
        /// For third channel of the DIY-devices led 85.
        /// </summary>
        DIYChannel3Led85 = 696,

        /// <summary>
        /// For third channel of the DIY-devices led 86.
        /// </summary>
        DIYChannel3Led86 = 697,

        /// <summary>
        /// For third channel of the DIY-devices led 87.
        /// </summary>
        DIYChannel3Led87 = 698,

        /// <summary>
        /// For third channel of the DIY-devices led 88.
        /// </summary>
        DIYChannel3Led88 = 699,

        /// <summary>
        /// For third channel of the DIY-devices led 89.
        /// </summary>
        DIYChannel3Led89 = 700,

        /// <summary>
        /// For third channel of the DIY-devices led 90.
        /// </summary>
        DIYChannel3Led90 = 701,

        /// <summary>
        /// For third channel of the DIY-devices led 91.
        /// </summary>
        DIYChannel3Led91 = 702,

        /// <summary>
        /// For third channel of the DIY-devices led 92.
        /// </summary>
        DIYChannel3Led92 = 703,

        /// <summary>
        /// For third channel of the DIY-devices led 93.
        /// </summary>
        DIYChannel3Led93 = 704,

        /// <summary>
        /// For third channel of the DIY-devices led 94.
        /// </summary>
        DIYChannel3Led94 = 705,

        /// <summary>
        /// For third channel of the DIY-devices led 95.
        /// </summary>
        DIYChannel3Led95 = 706,

        /// <summary>
        /// For third channel of the DIY-devices led 96.
        /// </summary>
        DIYChannel3Led96 = 707,

        /// <summary>
        /// For third channel of the DIY-devices led 97.
        /// </summary>
        DIYChannel3Led97 = 708,

        /// <summary>
        /// For third channel of the DIY-devices led 98.
        /// </summary>
        DIYChannel3Led98 = 709,

        /// <summary>
        /// For third channel of the DIY-devices led 99.
        /// </summary>
        DIYChannel3Led99 = 710,

        /// <summary>
        /// For third channel of the DIY-devices led 100.
        /// </summary>
        DIYChannel3Led100 = 711,

        /// <summary>
        /// For third channel of the DIY-devices led 101.
        /// </summary>
        DIYChannel3Led101 = 712,

        /// <summary>
        /// For third channel of the DIY-devices led 102.
        /// </summary>
        DIYChannel3Led102 = 713,

        /// <summary>
        /// For third channel of the DIY-devices led 103.
        /// </summary>
        DIYChannel3Led103 = 714,

        /// <summary>
        /// For third channel of the DIY-devices led 104.
        /// </summary>
        DIYChannel3Led104 = 715,

        /// <summary>
        /// For third channel of the DIY-devices led 105.
        /// </summary>
        DIYChannel3Led105 = 716,

        /// <summary>
        /// For third channel of the DIY-devices led 106.
        /// </summary>
        DIYChannel3Led106 = 717,

        /// <summary>
        /// For third channel of the DIY-devices led 107.
        /// </summary>
        DIYChannel3Led107 = 718,

        /// <summary>
        /// For third channel of the DIY-devices led 108.
        /// </summary>
        DIYChannel3Led108 = 719,

        /// <summary>
        /// For third channel of the DIY-devices led 109.
        /// </summary>
        DIYChannel3Led109 = 720,

        /// <summary>
        /// For third channel of the DIY-devices led 110.
        /// </summary>
        DIYChannel3Led110 = 721,

        /// <summary>
        /// For third channel of the DIY-devices led 111.
        /// </summary>
        DIYChannel3Led111 = 722,

        /// <summary>
        /// For third channel of the DIY-devices led 112.
        /// </summary>
        DIYChannel3Led112 = 723,

        /// <summary>
        /// For third channel of the DIY-devices led 113.
        /// </summary>
        DIYChannel3Led113 = 724,

        /// <summary>
        /// For third channel of the DIY-devices led 114.
        /// </summary>
        DIYChannel3Led114 = 725,

        /// <summary>
        /// For third channel of the DIY-devices led 115.
        /// </summary>
        DIYChannel3Led115 = 726,

        /// <summary>
        /// For third channel of the DIY-devices led 116.
        /// </summary>
        DIYChannel3Led116 = 727,

        /// <summary>
        /// For third channel of the DIY-devices led 117.
        /// </summary>
        DIYChannel3Led117 = 728,

        /// <summary>
        /// For third channel of the DIY-devices led 118.
        /// </summary>
        DIYChannel3Led118 = 729,

        /// <summary>
        /// For third channel of the DIY-devices led 119.
        /// </summary>
        DIYChannel3Led119 = 730,

        /// <summary>
        /// For third channel of the DIY-devices led 120.
        /// </summary>
        DIYChannel3Led120 = 731,

        /// <summary>
        /// For third channel of the DIY-devices led 121.
        /// </summary>
        DIYChannel3Led121 = 732,

        /// <summary>
        /// For third channel of the DIY-devices led 122.
        /// </summary>
        DIYChannel3Led122 = 733,

        /// <summary>
        /// For third channel of the DIY-devices led 123.
        /// </summary>
        DIYChannel3Led123 = 734,

        /// <summary>
        /// For third channel of the DIY-devices led 124.
        /// </summary>
        DIYChannel3Led124 = 735,

        /// <summary>
        /// For third channel of the DIY-devices led 125.
        /// </summary>
        DIYChannel3Led125 = 736,

        /// <summary>
        /// For third channel of the DIY-devices led 126.
        /// </summary>
        DIYChannel3Led126 = 737,

        /// <summary>
        /// For third channel of the DIY-devices led 127.
        /// </summary>
        DIYChannel3Led127 = 738,

        /// <summary>
        /// For third channel of the DIY-devices led 128.
        /// </summary>
        DIYChannel3Led128 = 739,

        /// <summary>
        /// For third channel of the DIY-devices led 129.
        /// </summary>
        DIYChannel3Led129 = 740,

        /// <summary>
        /// For third channel of the DIY-devices led 130.
        /// </summary>
        DIYChannel3Led130 = 741,

        /// <summary>
        /// For third channel of the DIY-devices led 131.
        /// </summary>
        DIYChannel3Led131 = 742,

        /// <summary>
        /// For third channel of the DIY-devices led 132.
        /// </summary>
        DIYChannel3Led132 = 743,

        /// <summary>
        /// For third channel of the DIY-devices led 133.
        /// </summary>
        DIYChannel3Led133 = 744,

        /// <summary>
        /// For third channel of the DIY-devices led 134.
        /// </summary>
        DIYChannel3Led134 = 745,

        /// <summary>
        /// For third channel of the DIY-devices led 135.
        /// </summary>
        DIYChannel3Led135 = 746,

        /// <summary>
        /// For third channel of the DIY-devices led 136.
        /// </summary>
        DIYChannel3Led136 = 747,

        /// <summary>
        /// For third channel of the DIY-devices led 137.
        /// </summary>
        DIYChannel3Led137 = 748,

        /// <summary>
        /// For third channel of the DIY-devices led 138.
        /// </summary>
        DIYChannel3Led138 = 749,

        /// <summary>
        /// For third channel of the DIY-devices led 139.
        /// </summary>
        DIYChannel3Led139 = 750,

        /// <summary>
        /// For third channel of the DIY-devices led 140.
        /// </summary>
        DIYChannel3Led140 = 751,

        /// <summary>
        /// For third channel of the DIY-devices led 141.
        /// </summary>
        DIYChannel3Led141 = 752,

        /// <summary>
        /// For third channel of the DIY-devices led 142.
        /// </summary>
        DIYChannel3Led142 = 753,

        /// <summary>
        /// For third channel of the DIY-devices led 143.
        /// </summary>
        DIYChannel3Led143 = 754,

        /// <summary>
        /// For third channel of the DIY-devices led 144.
        /// </summary>
        DIYChannel3Led144 = 755,

        /// <summary>
        /// For third channel of the DIY-devices led 145.
        /// </summary>
        DIYChannel3Led145 = 756,

        /// <summary>
        /// For third channel of the DIY-devices led 146.
        /// </summary>
        DIYChannel3Led146 = 757,

        /// <summary>
        /// For third channel of the DIY-devices led 147.
        /// </summary>
        DIYChannel3Led147 = 758,

        /// <summary>
        /// For third channel of the DIY-devices led 148.
        /// </summary>
        DIYChannel3Led148 = 759,

        /// <summary>
        /// For third channel of the DIY-devices led 149.
        /// </summary>
        DIYChannel3Led149 = 760,

        /// <summary>
        /// For third channel of the DIY-devices led 150.
        /// </summary>
        DIYChannel3Led150 = 761,

        /// <summary>
        /// For first channel of the liquid coolers led 1.
        /// </summary>
        LiquidCoolerChannel1Led1 = 762,

        /// <summary>
        /// For first channel of the liquid coolers led 2.
        /// </summary>
        LiquidCoolerChannel1Led2 = 763,

        /// <summary>
        /// For first channel of the liquid coolers led 3.
        /// </summary>
        LiquidCoolerChannel1Led3 = 764,

        /// <summary>
        /// For first channel of the liquid coolers led 4.
        /// </summary>
        LiquidCoolerChannel1Led4 = 765,

        /// <summary>
        /// For first channel of the liquid coolers led 5.
        /// </summary>
        LiquidCoolerChannel1Led5 = 766,

        /// <summary>
        /// For first channel of the liquid coolers led 6.
        /// </summary>
        LiquidCoolerChannel1Led6 = 767,

        /// <summary>
        /// For first channel of the liquid coolers led 7.
        /// </summary>
        LiquidCoolerChannel1Led7 = 768,

        /// <summary>
        /// For first channel of the liquid coolers led 8.
        /// </summary>
        LiquidCoolerChannel1Led8 = 769,

        /// <summary>
        /// For first channel of the liquid coolers led 9.
        /// </summary>
        LiquidCoolerChannel1Led9 = 770,

        /// <summary>
        /// For first channel of the liquid coolers led 10.
        /// </summary>
        LiquidCoolerChannel1Led10 = 771,

        /// <summary>
        /// For first channel of the liquid coolers led 11.
        /// </summary>
        LiquidCoolerChannel1Led11 = 772,

        /// <summary>
        /// For first channel of the liquid coolers led 12.
        /// </summary>
        LiquidCoolerChannel1Led12 = 773,

        /// <summary>
        /// For first channel of the liquid coolers led 13.
        /// </summary>
        LiquidCoolerChannel1Led13 = 774,

        /// <summary>
        /// For first channel of the liquid coolers led 14.
        /// </summary>
        LiquidCoolerChannel1Led14 = 775,

        /// <summary>
        /// For first channel of the liquid coolers led 15.
        /// </summary>
        LiquidCoolerChannel1Led15 = 776,

        /// <summary>
        /// For first channel of the liquid coolers led 16.
        /// </summary>
        LiquidCoolerChannel1Led16 = 777,

        /// <summary>
        /// For first channel of the liquid coolers led 17.
        /// </summary>
        LiquidCoolerChannel1Led17 = 778,

        /// <summary>
        /// For first channel of the liquid coolers led 18.
        /// </summary>
        LiquidCoolerChannel1Led18 = 779,

        /// <summary>
        /// For first channel of the liquid coolers led 19.
        /// </summary>
        LiquidCoolerChannel1Led19 = 780,

        /// <summary>
        /// For first channel of the liquid coolers led 20.
        /// </summary>
        LiquidCoolerChannel1Led20 = 781,

        /// <summary>
        /// For first channel of the liquid coolers led 21.
        /// </summary>
        LiquidCoolerChannel1Led21 = 782,

        /// <summary>
        /// For first channel of the liquid coolers led 22.
        /// </summary>
        LiquidCoolerChannel1Led22 = 783,

        /// <summary>
        /// For first channel of the liquid coolers led 23.
        /// </summary>
        LiquidCoolerChannel1Led23 = 784,

        /// <summary>
        /// For first channel of the liquid coolers led 24.
        /// </summary>
        LiquidCoolerChannel1Led24 = 785,

        /// <summary>
        /// For first channel of the liquid coolers led 25.
        /// </summary>
        LiquidCoolerChannel1Led25 = 786,

        /// <summary>
        /// For first channel of the liquid coolers led 26.
        /// </summary>
        LiquidCoolerChannel1Led26 = 787,

        /// <summary>
        /// For first channel of the liquid coolers led 27.
        /// </summary>
        LiquidCoolerChannel1Led27 = 788,

        /// <summary>
        /// For first channel of the liquid coolers led 28.
        /// </summary>
        LiquidCoolerChannel1Led28 = 789,

        /// <summary>
        /// For first channel of the liquid coolers led 29.
        /// </summary>
        LiquidCoolerChannel1Led29 = 790,

        /// <summary>
        /// For first channel of the liquid coolers led 30.
        /// </summary>
        LiquidCoolerChannel1Led30 = 791,

        /// <summary>
        /// For first channel of the liquid coolers led 31.
        /// </summary>
        LiquidCoolerChannel1Led31 = 792,

        /// <summary>
        /// For first channel of the liquid coolers led 32.
        /// </summary>
        LiquidCoolerChannel1Led32 = 793,

        /// <summary>
        /// For first channel of the liquid coolers led 33.
        /// </summary>
        LiquidCoolerChannel1Led33 = 794,

        /// <summary>
        /// For first channel of the liquid coolers led 34.
        /// </summary>
        LiquidCoolerChannel1Led34 = 795,

        /// <summary>
        /// For first channel of the liquid coolers led 35.
        /// </summary>
        LiquidCoolerChannel1Led35 = 796,

        /// <summary>
        /// For first channel of the liquid coolers led 36.
        /// </summary>
        LiquidCoolerChannel1Led36 = 797,

        /// <summary>
        /// For first channel of the liquid coolers led 37.
        /// </summary>
        LiquidCoolerChannel1Led37 = 798,

        /// <summary>
        /// For first channel of the liquid coolers led 38.
        /// </summary>
        LiquidCoolerChannel1Led38 = 799,

        /// <summary>
        /// For first channel of the liquid coolers led 39.
        /// </summary>
        LiquidCoolerChannel1Led39 = 800,

        /// <summary>
        /// For first channel of the liquid coolers led 40.
        /// </summary>
        LiquidCoolerChannel1Led40 = 801,

        /// <summary>
        /// For first channel of the liquid coolers led 41.
        /// </summary>
        LiquidCoolerChannel1Led41 = 802,

        /// <summary>
        /// For first channel of the liquid coolers led 42.
        /// </summary>
        LiquidCoolerChannel1Led42 = 803,

        /// <summary>
        /// For first channel of the liquid coolers led 43.
        /// </summary>
        LiquidCoolerChannel1Led43 = 804,

        /// <summary>
        /// For first channel of the liquid coolers led 44.
        /// </summary>
        LiquidCoolerChannel1Led44 = 805,

        /// <summary>
        /// For first channel of the liquid coolers led 45.
        /// </summary>
        LiquidCoolerChannel1Led45 = 806,

        /// <summary>
        /// For first channel of the liquid coolers led 46.
        /// </summary>
        LiquidCoolerChannel1Led46 = 807,

        /// <summary>
        /// For first channel of the liquid coolers led 47.
        /// </summary>
        LiquidCoolerChannel1Led47 = 808,

        /// <summary>
        /// For first channel of the liquid coolers led 48.
        /// </summary>
        LiquidCoolerChannel1Led48 = 809,

        /// <summary>
        /// For first channel of the liquid coolers led 49.
        /// </summary>
        LiquidCoolerChannel1Led49 = 810,

        /// <summary>
        /// For first channel of the liquid coolers led 50.
        /// </summary>
        LiquidCoolerChannel1Led50 = 811,

        /// <summary>
        /// For first channel of the liquid coolers led 51.
        /// </summary>
        LiquidCoolerChannel1Led51 = 812,

        /// <summary>
        /// For first channel of the liquid coolers led 52.
        /// </summary>
        LiquidCoolerChannel1Led52 = 813,

        /// <summary>
        /// For first channel of the liquid coolers led 53.
        /// </summary>
        LiquidCoolerChannel1Led53 = 814,

        /// <summary>
        /// For first channel of the liquid coolers led 54.
        /// </summary>
        LiquidCoolerChannel1Led54 = 815,

        /// <summary>
        /// For first channel of the liquid coolers led 55.
        /// </summary>
        LiquidCoolerChannel1Led55 = 816,

        /// <summary>
        /// For first channel of the liquid coolers led 56.
        /// </summary>
        LiquidCoolerChannel1Led56 = 817,

        /// <summary>
        /// For first channel of the liquid coolers led 57.
        /// </summary>
        LiquidCoolerChannel1Led57 = 818,

        /// <summary>
        /// For first channel of the liquid coolers led 58.
        /// </summary>
        LiquidCoolerChannel1Led58 = 819,

        /// <summary>
        /// For first channel of the liquid coolers led 59.
        /// </summary>
        LiquidCoolerChannel1Led59 = 820,

        /// <summary>
        /// For first channel of the liquid coolers led 60.
        /// </summary>
        LiquidCoolerChannel1Led60 = 821,

        /// <summary>
        /// For first channel of the liquid coolers led 61.
        /// </summary>
        LiquidCoolerChannel1Led61 = 822,

        /// <summary>
        /// For first channel of the liquid coolers led 62.
        /// </summary>
        LiquidCoolerChannel1Led62 = 823,

        /// <summary>
        /// For first channel of the liquid coolers led 63.
        /// </summary>
        LiquidCoolerChannel1Led63 = 824,

        /// <summary>
        /// For first channel of the liquid coolers led 64.
        /// </summary>
        LiquidCoolerChannel1Led64 = 825,

        /// <summary>
        /// For first channel of the liquid coolers led 65.
        /// </summary>
        LiquidCoolerChannel1Led65 = 826,

        /// <summary>
        /// For first channel of the liquid coolers led 66.
        /// </summary>
        LiquidCoolerChannel1Led66 = 827,

        /// <summary>
        /// For first channel of the liquid coolers led 67.
        /// </summary>
        LiquidCoolerChannel1Led67 = 828,

        /// <summary>
        /// For first channel of the liquid coolers led 68.
        /// </summary>
        LiquidCoolerChannel1Led68 = 829,

        /// <summary>
        /// For first channel of the liquid coolers led 69.
        /// </summary>
        LiquidCoolerChannel1Led69 = 830,

        /// <summary>
        /// For first channel of the liquid coolers led 70.
        /// </summary>
        LiquidCoolerChannel1Led70 = 831,

        /// <summary>
        /// For first channel of the liquid coolers led 71.
        /// </summary>
        LiquidCoolerChannel1Led71 = 832,

        /// <summary>
        /// For first channel of the liquid coolers led 72.
        /// </summary>
        LiquidCoolerChannel1Led72 = 833,

        /// <summary>
        /// For first channel of the liquid coolers led 73.
        /// </summary>
        LiquidCoolerChannel1Led73 = 834,

        /// <summary>
        /// For first channel of the liquid coolers led 74.
        /// </summary>
        LiquidCoolerChannel1Led74 = 835,

        /// <summary>
        /// For first channel of the liquid coolers led 75.
        /// </summary>
        LiquidCoolerChannel1Led75 = 836,

        /// <summary>
        /// For first channel of the liquid coolers led 76.
        /// </summary>
        LiquidCoolerChannel1Led76 = 837,

        /// <summary>
        /// For first channel of the liquid coolers led 77.
        /// </summary>
        LiquidCoolerChannel1Led77 = 838,

        /// <summary>
        /// For first channel of the liquid coolers led 78.
        /// </summary>
        LiquidCoolerChannel1Led78 = 839,

        /// <summary>
        /// For first channel of the liquid coolers led 79.
        /// </summary>
        LiquidCoolerChannel1Led79 = 840,

        /// <summary>
        /// For first channel of the liquid coolers led 80.
        /// </summary>
        LiquidCoolerChannel1Led80 = 841,

        /// <summary>
        /// For first channel of the liquid coolers led 81.
        /// </summary>
        LiquidCoolerChannel1Led81 = 842,

        /// <summary>
        /// For first channel of the liquid coolers led 82.
        /// </summary>
        LiquidCoolerChannel1Led82 = 843,

        /// <summary>
        /// For first channel of the liquid coolers led 83.
        /// </summary>
        LiquidCoolerChannel1Led83 = 844,

        /// <summary>
        /// For first channel of the liquid coolers led 84.
        /// </summary>
        LiquidCoolerChannel1Led84 = 845,

        /// <summary>
        /// For first channel of the liquid coolers led 85.
        /// </summary>
        LiquidCoolerChannel1Led85 = 846,

        /// <summary>
        /// For first channel of the liquid coolers led 86.
        /// </summary>
        LiquidCoolerChannel1Led86 = 847,

        /// <summary>
        /// For first channel of the liquid coolers led 87.
        /// </summary>
        LiquidCoolerChannel1Led87 = 848,

        /// <summary>
        /// For first channel of the liquid coolers led 88.
        /// </summary>
        LiquidCoolerChannel1Led88 = 849,

        /// <summary>
        /// For first channel of the liquid coolers led 89.
        /// </summary>
        LiquidCoolerChannel1Led89 = 850,

        /// <summary>
        /// For first channel of the liquid coolers led 90.
        /// </summary>
        LiquidCoolerChannel1Led90 = 851,

        /// <summary>
        /// For first channel of the liquid coolers led 91.
        /// </summary>
        LiquidCoolerChannel1Led91 = 852,

        /// <summary>
        /// For first channel of the liquid coolers led 92.
        /// </summary>
        LiquidCoolerChannel1Led92 = 853,

        /// <summary>
        /// For first channel of the liquid coolers led 93.
        /// </summary>
        LiquidCoolerChannel1Led93 = 854,

        /// <summary>
        /// For first channel of the liquid coolers led 94.
        /// </summary>
        LiquidCoolerChannel1Led94 = 855,

        /// <summary>
        /// For first channel of the liquid coolers led 95.
        /// </summary>
        LiquidCoolerChannel1Led95 = 856,

        /// <summary>
        /// For first channel of the liquid coolers led 96.
        /// </summary>
        LiquidCoolerChannel1Led96 = 857,

        /// <summary>
        /// For first channel of the liquid coolers led 97.
        /// </summary>
        LiquidCoolerChannel1Led97 = 858,

        /// <summary>
        /// For first channel of the liquid coolers led 98.
        /// </summary>
        LiquidCoolerChannel1Led98 = 859,

        /// <summary>
        /// For first channel of the liquid coolers led 99.
        /// </summary>
        LiquidCoolerChannel1Led99 = 860,

        /// <summary>
        /// For first channel of the liquid coolers led 100.
        /// </summary>
        LiquidCoolerChannel1Led100 = 861,

        /// <summary>
        /// For first channel of the liquid coolers led 101.
        /// </summary>
        LiquidCoolerChannel1Led101 = 862,

        /// <summary>
        /// For first channel of the liquid coolers led 102.
        /// </summary>
        LiquidCoolerChannel1Led102 = 863,

        /// <summary>
        /// For first channel of the liquid coolers led 103.
        /// </summary>
        LiquidCoolerChannel1Led103 = 864,

        /// <summary>
        /// For first channel of the liquid coolers led 104.
        /// </summary>
        LiquidCoolerChannel1Led104 = 865,

        /// <summary>
        /// For first channel of the liquid coolers led 105.
        /// </summary>
        LiquidCoolerChannel1Led105 = 866,

        /// <summary>
        /// For first channel of the liquid coolers led 106.
        /// </summary>
        LiquidCoolerChannel1Led106 = 867,

        /// <summary>
        /// For first channel of the liquid coolers led 107.
        /// </summary>
        LiquidCoolerChannel1Led107 = 868,

        /// <summary>
        /// For first channel of the liquid coolers led 108.
        /// </summary>
        LiquidCoolerChannel1Led108 = 869,

        /// <summary>
        /// For first channel of the liquid coolers led 109.
        /// </summary>
        LiquidCoolerChannel1Led109 = 870,

        /// <summary>
        /// For first channel of the liquid coolers led 110.
        /// </summary>
        LiquidCoolerChannel1Led110 = 871,

        /// <summary>
        /// For first channel of the liquid coolers led 111.
        /// </summary>
        LiquidCoolerChannel1Led111 = 872,

        /// <summary>
        /// For first channel of the liquid coolers led 112.
        /// </summary>
        LiquidCoolerChannel1Led112 = 873,

        /// <summary>
        /// For first channel of the liquid coolers led 113.
        /// </summary>
        LiquidCoolerChannel1Led113 = 874,

        /// <summary>
        /// For first channel of the liquid coolers led 114.
        /// </summary>
        LiquidCoolerChannel1Led114 = 875,

        /// <summary>
        /// For first channel of the liquid coolers led 115.
        /// </summary>
        LiquidCoolerChannel1Led115 = 876,

        /// <summary>
        /// For first channel of the liquid coolers led 116.
        /// </summary>
        LiquidCoolerChannel1Led116 = 877,

        /// <summary>
        /// For first channel of the liquid coolers led 117.
        /// </summary>
        LiquidCoolerChannel1Led117 = 878,

        /// <summary>
        /// For first channel of the liquid coolers led 118.
        /// </summary>
        LiquidCoolerChannel1Led118 = 879,

        /// <summary>
        /// For first channel of the liquid coolers led 119.
        /// </summary>
        LiquidCoolerChannel1Led119 = 880,

        /// <summary>
        /// For first channel of the liquid coolers led 120.
        /// </summary>
        LiquidCoolerChannel1Led120 = 881,

        /// <summary>
        /// For first channel of the liquid coolers led 121.
        /// </summary>
        LiquidCoolerChannel1Led121 = 882,

        /// <summary>
        /// For first channel of the liquid coolers led 122.
        /// </summary>
        LiquidCoolerChannel1Led122 = 883,

        /// <summary>
        /// For first channel of the liquid coolers led 123.
        /// </summary>
        LiquidCoolerChannel1Led123 = 884,

        /// <summary>
        /// For first channel of the liquid coolers led 124.
        /// </summary>
        LiquidCoolerChannel1Led124 = 885,

        /// <summary>
        /// For first channel of the liquid coolers led 125.
        /// </summary>
        LiquidCoolerChannel1Led125 = 886,

        /// <summary>
        /// For first channel of the liquid coolers led 126.
        /// </summary>
        LiquidCoolerChannel1Led126 = 887,

        /// <summary>
        /// For first channel of the liquid coolers led 127.
        /// </summary>
        LiquidCoolerChannel1Led127 = 888,

        /// <summary>
        /// For first channel of the liquid coolers led 128.
        /// </summary>
        LiquidCoolerChannel1Led128 = 889,

        /// <summary>
        /// For first channel of the liquid coolers led 129.
        /// </summary>
        LiquidCoolerChannel1Led129 = 890,

        /// <summary>
        /// For first channel of the liquid coolers led 130.
        /// </summary>
        LiquidCoolerChannel1Led130 = 891,

        /// <summary>
        /// For first channel of the liquid coolers led 131.
        /// </summary>
        LiquidCoolerChannel1Led131 = 892,

        /// <summary>
        /// For first channel of the liquid coolers led 132.
        /// </summary>
        LiquidCoolerChannel1Led132 = 893,

        /// <summary>
        /// For first channel of the liquid coolers led 133.
        /// </summary>
        LiquidCoolerChannel1Led133 = 894,

        /// <summary>
        /// For first channel of the liquid coolers led 134.
        /// </summary>
        LiquidCoolerChannel1Led134 = 895,

        /// <summary>
        /// For first channel of the liquid coolers led 135.
        /// </summary>
        LiquidCoolerChannel1Led135 = 896,

        /// <summary>
        /// For first channel of the liquid coolers led 136.
        /// </summary>
        LiquidCoolerChannel1Led136 = 897,

        /// <summary>
        /// For first channel of the liquid coolers led 137.
        /// </summary>
        LiquidCoolerChannel1Led137 = 898,

        /// <summary>
        /// For first channel of the liquid coolers led 138.
        /// </summary>
        LiquidCoolerChannel1Led138 = 899,

        /// <summary>
        /// For first channel of the liquid coolers led 139.
        /// </summary>
        LiquidCoolerChannel1Led139 = 900,

        /// <summary>
        /// For first channel of the liquid coolers led 140.
        /// </summary>
        LiquidCoolerChannel1Led140 = 901,

        /// <summary>
        /// For first channel of the liquid coolers led 141.
        /// </summary>
        LiquidCoolerChannel1Led141 = 902,

        /// <summary>
        /// For first channel of the liquid coolers led 142.
        /// </summary>
        LiquidCoolerChannel1Led142 = 903,

        /// <summary>
        /// For first channel of the liquid coolers led 143.
        /// </summary>
        LiquidCoolerChannel1Led143 = 904,

        /// <summary>
        /// For first channel of the liquid coolers led 144.
        /// </summary>
        LiquidCoolerChannel1Led144 = 905,

        /// <summary>
        /// For first channel of the liquid coolers led 145.
        /// </summary>
        LiquidCoolerChannel1Led145 = 906,

        /// <summary>
        /// For first channel of the liquid coolers led 146.
        /// </summary>
        LiquidCoolerChannel1Led146 = 907,

        /// <summary>
        /// For first channel of the liquid coolers led 147.
        /// </summary>
        LiquidCoolerChannel1Led147 = 908,

        /// <summary>
        /// For first channel of the liquid coolers led 148.
        /// </summary>
        LiquidCoolerChannel1Led148 = 909,

        /// <summary>
        /// For first channel of the liquid coolers led 149.
        /// </summary>
        LiquidCoolerChannel1Led149 = 910,

        /// <summary>
        /// For first channel of the liquid coolers led 150.
        /// </summary>
        LiquidCoolerChannel1Led150 = 911,

        /// <summary>
        /// For first channel of the DIY-devices led 151.
        /// </summary>
        DIYChannel1Led151 = 912,

        /// <summary>
        /// For first channel of the DIY-devices led 152.
        /// </summary>
        DIYChannel1Led152 = 913,

        /// <summary>
        /// For first channel of the DIY-devices led 153.
        /// </summary>
        DIYChannel1Led153 = 914,

        /// <summary>
        /// For first channel of the DIY-devices led 154.
        /// </summary>
        DIYChannel1Led154 = 915,

        /// <summary>
        /// For first channel of the DIY-devices led 155.
        /// </summary>
        DIYChannel1Led155 = 916,

        /// <summary>
        /// For first channel of the DIY-devices led 156.
        /// </summary>
        DIYChannel1Led156 = 917,

        /// <summary>
        /// For first channel of the DIY-devices led 157.
        /// </summary>
        DIYChannel1Led157 = 918,

        /// <summary>
        /// For first channel of the DIY-devices led 158.
        /// </summary>
        DIYChannel1Led158 = 919,

        /// <summary>
        /// For first channel of the DIY-devices led 159.
        /// </summary>
        DIYChannel1Led159 = 920,

        /// <summary>
        /// For first channel of the DIY-devices led 160.
        /// </summary>
        DIYChannel1Led160 = 921,

        /// <summary>
        /// For first channel of the DIY-devices led 161.
        /// </summary>
        DIYChannel1Led161 = 922,

        /// <summary>
        /// For first channel of the DIY-devices led 162.
        /// </summary>
        DIYChannel1Led162 = 923,

        /// <summary>
        /// For first channel of the DIY-devices led 163.
        /// </summary>
        DIYChannel1Led163 = 924,

        /// <summary>
        /// For first channel of the DIY-devices led 164.
        /// </summary>
        DIYChannel1Led164 = 925,

        /// <summary>
        /// For first channel of the DIY-devices led 165.
        /// </summary>
        DIYChannel1Led165 = 926,

        /// <summary>
        /// For first channel of the DIY-devices led 166.
        /// </summary>
        DIYChannel1Led166 = 927,

        /// <summary>
        /// For first channel of the DIY-devices led 167.
        /// </summary>
        DIYChannel1Led167 = 928,

        /// <summary>
        /// For first channel of the DIY-devices led 168.
        /// </summary>
        DIYChannel1Led168 = 929,

        /// <summary>
        /// For first channel of the DIY-devices led 169.
        /// </summary>
        DIYChannel1Led169 = 930,

        /// <summary>
        /// For first channel of the DIY-devices led 170.
        /// </summary>
        DIYChannel1Led170 = 931,

        /// <summary>
        /// For first channel of the DIY-devices led 171.
        /// </summary>
        DIYChannel1Led171 = 932,

        /// <summary>
        /// For first channel of the DIY-devices led 172.
        /// </summary>
        DIYChannel1Led172 = 933,

        /// <summary>
        /// For first channel of the DIY-devices led 173.
        /// </summary>
        DIYChannel1Led173 = 934,

        /// <summary>
        /// For first channel of the DIY-devices led 174.
        /// </summary>
        DIYChannel1Led174 = 935,

        /// <summary>
        /// For first channel of the DIY-devices led 175.
        /// </summary>
        DIYChannel1Led175 = 936,

        /// <summary>
        /// For first channel of the DIY-devices led 176.
        /// </summary>
        DIYChannel1Led176 = 937,

        /// <summary>
        /// For first channel of the DIY-devices led 177.
        /// </summary>
        DIYChannel1Led177 = 938,

        /// <summary>
        /// For first channel of the DIY-devices led 178.
        /// </summary>
        DIYChannel1Led178 = 939,

        /// <summary>
        /// For first channel of the DIY-devices led 179.
        /// </summary>
        DIYChannel1Led179 = 940,

        /// <summary>
        /// For first channel of the DIY-devices led 180.
        /// </summary>
        DIYChannel1Led180 = 941,

        /// <summary>
        /// For first channel of the DIY-devices led 181.
        /// </summary>
        DIYChannel1Led181 = 942,

        /// <summary>
        /// For first channel of the DIY-devices led 182.
        /// </summary>
        DIYChannel1Led182 = 943,

        /// <summary>
        /// For first channel of the DIY-devices led 183.
        /// </summary>
        DIYChannel1Led183 = 944,

        /// <summary>
        /// For first channel of the DIY-devices led 184.
        /// </summary>
        DIYChannel1Led184 = 945,

        /// <summary>
        /// For first channel of the DIY-devices led 185.
        /// </summary>
        DIYChannel1Led185 = 946,

        /// <summary>
        /// For first channel of the DIY-devices led 186.
        /// </summary>
        DIYChannel1Led186 = 947,

        /// <summary>
        /// For first channel of the DIY-devices led 187.
        /// </summary>
        DIYChannel1Led187 = 948,

        /// <summary>
        /// For first channel of the DIY-devices led 188.
        /// </summary>
        DIYChannel1Led188 = 949,

        /// <summary>
        /// For first channel of the DIY-devices led 189.
        /// </summary>
        DIYChannel1Led189 = 950,

        /// <summary>
        /// For first channel of the DIY-devices led 190.
        /// </summary>
        DIYChannel1Led190 = 951,

        /// <summary>
        /// For first channel of the DIY-devices led 191.
        /// </summary>
        DIYChannel1Led191 = 952,

        /// <summary>
        /// For first channel of the DIY-devices led 192.
        /// </summary>
        DIYChannel1Led192 = 953,

        /// <summary>
        /// For first channel of the DIY-devices led 193.
        /// </summary>
        DIYChannel1Led193 = 954,

        /// <summary>
        /// For first channel of the DIY-devices led 194.
        /// </summary>
        DIYChannel1Led194 = 955,

        /// <summary>
        /// For first channel of the DIY-devices led 195.
        /// </summary>
        DIYChannel1Led195 = 956,

        /// <summary>
        /// For first channel of the DIY-devices led 196.
        /// </summary>
        DIYChannel1Led196 = 957,

        /// <summary>
        /// For first channel of the DIY-devices led 197.
        /// </summary>
        DIYChannel1Led197 = 958,

        /// <summary>
        /// For first channel of the DIY-devices led 198.
        /// </summary>
        DIYChannel1Led198 = 959,

        /// <summary>
        /// For first channel of the DIY-devices led 199.
        /// </summary>
        DIYChannel1Led199 = 960,

        /// <summary>
        /// For first channel of the DIY-devices led 200.
        /// </summary>
        DIYChannel1Led200 = 961,

        /// <summary>
        /// For first channel of the DIY-devices led 201.
        /// </summary>
        DIYChannel1Led201 = 962,

        /// <summary>
        /// For first channel of the DIY-devices led 202.
        /// </summary>
        DIYChannel1Led202 = 963,

        /// <summary>
        /// For first channel of the DIY-devices led 203.
        /// </summary>
        DIYChannel1Led203 = 964,

        /// <summary>
        /// For first channel of the DIY-devices led 204.
        /// </summary>
        DIYChannel1Led204 = 965,

        /// <summary>
        /// For first channel of the DIY-devices led 205.
        /// </summary>
        DIYChannel1Led205 = 966,

        /// <summary>
        /// For first channel of the DIY-devices led 206.
        /// </summary>
        DIYChannel1Led206 = 967,

        /// <summary>
        /// For first channel of the DIY-devices led 207.
        /// </summary>
        DIYChannel1Led207 = 968,

        /// <summary>
        /// For first channel of the DIY-devices led 208.
        /// </summary>
        DIYChannel1Led208 = 969,

        /// <summary>
        /// For first channel of the DIY-devices led 209.
        /// </summary>
        DIYChannel1Led209 = 970,

        /// <summary>
        /// For first channel of the DIY-devices led 210.
        /// </summary>
        DIYChannel1Led210 = 971,

        /// <summary>
        /// For first channel of the DIY-devices led 211.
        /// </summary>
        DIYChannel1Led211 = 972,

        /// <summary>
        /// For first channel of the DIY-devices led 212.
        /// </summary>
        DIYChannel1Led212 = 973,

        /// <summary>
        /// For first channel of the DIY-devices led 213.
        /// </summary>
        DIYChannel1Led213 = 974,

        /// <summary>
        /// For first channel of the DIY-devices led 214.
        /// </summary>
        DIYChannel1Led214 = 975,

        /// <summary>
        /// For first channel of the DIY-devices led 215.
        /// </summary>
        DIYChannel1Led215 = 976,

        /// <summary>
        /// For first channel of the DIY-devices led 216.
        /// </summary>
        DIYChannel1Led216 = 977,

        /// <summary>
        /// For first channel of the DIY-devices led 217.
        /// </summary>
        DIYChannel1Led217 = 978,

        /// <summary>
        /// For first channel of the DIY-devices led 218.
        /// </summary>
        DIYChannel1Led218 = 979,

        /// <summary>
        /// For first channel of the DIY-devices led 219.
        /// </summary>
        DIYChannel1Led219 = 980,

        /// <summary>
        /// For first channel of the DIY-devices led 220.
        /// </summary>
        DIYChannel1Led220 = 981,

        /// <summary>
        /// For first channel of the DIY-devices led 221.
        /// </summary>
        DIYChannel1Led221 = 982,

        /// <summary>
        /// For first channel of the DIY-devices led 222.
        /// </summary>
        DIYChannel1Led222 = 983,

        /// <summary>
        /// For first channel of the DIY-devices led 223.
        /// </summary>
        DIYChannel1Led223 = 984,

        /// <summary>
        /// For first channel of the DIY-devices led 224.
        /// </summary>
        DIYChannel1Led224 = 985,

        /// <summary>
        /// For first channel of the DIY-devices led 225.
        /// </summary>
        DIYChannel1Led225 = 986,

        /// <summary>
        /// For first channel of the DIY-devices led 226.
        /// </summary>
        DIYChannel1Led226 = 987,

        /// <summary>
        /// For first channel of the DIY-devices led 227.
        /// </summary>
        DIYChannel1Led227 = 988,

        /// <summary>
        /// For first channel of the DIY-devices led 228.
        /// </summary>
        DIYChannel1Led228 = 989,

        /// <summary>
        /// For first channel of the DIY-devices led 229.
        /// </summary>
        DIYChannel1Led229 = 990,

        /// <summary>
        /// For first channel of the DIY-devices led 230.
        /// </summary>
        DIYChannel1Led230 = 991,

        /// <summary>
        /// For first channel of the DIY-devices led 231.
        /// </summary>
        DIYChannel1Led231 = 992,

        /// <summary>
        /// For first channel of the DIY-devices led 232.
        /// </summary>
        DIYChannel1Led232 = 993,

        /// <summary>
        /// For first channel of the DIY-devices led 233.
        /// </summary>
        DIYChannel1Led233 = 994,

        /// <summary>
        /// For first channel of the DIY-devices led 234.
        /// </summary>
        DIYChannel1Led234 = 995,

        /// <summary>
        /// For first channel of the DIY-devices led 235.
        /// </summary>
        DIYChannel1Led235 = 996,

        /// <summary>
        /// For first channel of the DIY-devices led 236.
        /// </summary>
        DIYChannel1Led236 = 997,

        /// <summary>
        /// For first channel of the DIY-devices led 237.
        /// </summary>
        DIYChannel1Led237 = 998,

        /// <summary>
        /// For first channel of the DIY-devices led 238.
        /// </summary>
        DIYChannel1Led238 = 999,

        /// <summary>
        /// For first channel of the DIY-devices led 239.
        /// </summary>
        DIYChannel1Led239 = 1000,

        /// <summary>
        /// For first channel of the DIY-devices led 240.
        /// </summary>
        DIYChannel1Led240 = 1001,

        /// <summary>
        /// For first channel of the DIY-devices led 241.
        /// </summary>
        DIYChannel1Led241 = 1002,

        /// <summary>
        /// For first channel of the DIY-devices led 242.
        /// </summary>
        DIYChannel1Led242 = 1003,

        /// <summary>
        /// For first channel of the DIY-devices led 243.
        /// </summary>
        DIYChannel1Led243 = 1004,

        /// <summary>
        /// For first channel of the DIY-devices led 244.
        /// </summary>
        DIYChannel1Led244 = 1005,

        /// <summary>
        /// For first channel of the DIY-devices led 245.
        /// </summary>
        DIYChannel1Led245 = 1006,

        /// <summary>
        /// For first channel of the DIY-devices led 246.
        /// </summary>
        DIYChannel1Led246 = 1007,

        /// <summary>
        /// For first channel of the DIY-devices led 247.
        /// </summary>
        DIYChannel1Led247 = 1008,

        /// <summary>
        /// For first channel of the DIY-devices led 248.
        /// </summary>
        DIYChannel1Led248 = 1009,

        /// <summary>
        /// For first channel of the DIY-devices led 249.
        /// </summary>
        DIYChannel1Led249 = 1010,

        /// <summary>
        /// For first channel of the DIY-devices led 250.
        /// </summary>
        DIYChannel1Led250 = 1011,

        /// <summary>
        /// For first channel of the DIY-devices led 251.
        /// </summary>
        DIYChannel1Led251 = 1012,

        /// <summary>
        /// For first channel of the DIY-devices led 252.
        /// </summary>
        DIYChannel1Led252 = 1013,

        /// <summary>
        /// For first channel of the DIY-devices led 253.
        /// </summary>
        DIYChannel1Led253 = 1014,

        /// <summary>
        /// For first channel of the DIY-devices led 254.
        /// </summary>
        DIYChannel1Led254 = 1015,

        /// <summary>
        /// For first channel of the DIY-devices led 255.
        /// </summary>
        DIYChannel1Led255 = 1016,

        /// <summary>
        /// For first channel of the DIY-devices led 256.
        /// </summary>
        DIYChannel1Led256 = 1017,

        /// <summary>
        /// For first channel of the DIY-devices led 257.
        /// </summary>
        DIYChannel1Led257 = 1018,

        /// <summary>
        /// For first channel of the DIY-devices led 258.
        /// </summary>
        DIYChannel1Led258 = 1019,

        /// <summary>
        /// For first channel of the DIY-devices led 259.
        /// </summary>
        DIYChannel1Led259 = 1020,

        /// <summary>
        /// For first channel of the DIY-devices led 260.
        /// </summary>
        DIYChannel1Led260 = 1021,

        /// <summary>
        /// For first channel of the DIY-devices led 261.
        /// </summary>
        DIYChannel1Led261 = 1022,

        /// <summary>
        /// For first channel of the DIY-devices led 262.
        /// </summary>
        DIYChannel1Led262 = 1023,

        /// <summary>
        /// For first channel of the DIY-devices led 263.
        /// </summary>
        DIYChannel1Led263 = 1024,

        /// <summary>
        /// For first channel of the DIY-devices led 264.
        /// </summary>
        DIYChannel1Led264 = 1025,

        /// <summary>
        /// For first channel of the DIY-devices led 265.
        /// </summary>
        DIYChannel1Led265 = 1026,

        /// <summary>
        /// For first channel of the DIY-devices led 266.
        /// </summary>
        DIYChannel1Led266 = 1027,

        /// <summary>
        /// For first channel of the DIY-devices led 267.
        /// </summary>
        DIYChannel1Led267 = 1028,

        /// <summary>
        /// For first channel of the DIY-devices led 268.
        /// </summary>
        DIYChannel1Led268 = 1029,

        /// <summary>
        /// For first channel of the DIY-devices led 269.
        /// </summary>
        DIYChannel1Led269 = 1030,

        /// <summary>
        /// For first channel of the DIY-devices led 270.
        /// </summary>
        DIYChannel1Led270 = 1031,

        /// <summary>
        /// For first channel of the DIY-devices led 271.
        /// </summary>
        DIYChannel1Led271 = 1032,

        /// <summary>
        /// For first channel of the DIY-devices led 272.
        /// </summary>
        DIYChannel1Led272 = 1033,

        /// <summary>
        /// For first channel of the DIY-devices led 273.
        /// </summary>
        DIYChannel1Led273 = 1034,

        /// <summary>
        /// For first channel of the DIY-devices led 274.
        /// </summary>
        DIYChannel1Led274 = 1035,

        /// <summary>
        /// For first channel of the DIY-devices led 275.
        /// </summary>
        DIYChannel1Led275 = 1036,

        /// <summary>
        /// For first channel of the DIY-devices led 276.
        /// </summary>
        DIYChannel1Led276 = 1037,

        /// <summary>
        /// For first channel of the DIY-devices led 277.
        /// </summary>
        DIYChannel1Led277 = 1038,

        /// <summary>
        /// For first channel of the DIY-devices led 278.
        /// </summary>
        DIYChannel1Led278 = 1039,

        /// <summary>
        /// For first channel of the DIY-devices led 279.
        /// </summary>
        DIYChannel1Led279 = 1040,

        /// <summary>
        /// For first channel of the DIY-devices led 280.
        /// </summary>
        DIYChannel1Led280 = 1041,

        /// <summary>
        /// For first channel of the DIY-devices led 281.
        /// </summary>
        DIYChannel1Led281 = 1042,

        /// <summary>
        /// For first channel of the DIY-devices led 282.
        /// </summary>
        DIYChannel1Led282 = 1043,

        /// <summary>
        /// For first channel of the DIY-devices led 283.
        /// </summary>
        DIYChannel1Led283 = 1044,

        /// <summary>
        /// For first channel of the DIY-devices led 284.
        /// </summary>
        DIYChannel1Led284 = 1045,

        /// <summary>
        /// For first channel of the DIY-devices led 285.
        /// </summary>
        DIYChannel1Led285 = 1046,

        /// <summary>
        /// For first channel of the DIY-devices led 286.
        /// </summary>
        DIYChannel1Led286 = 1047,

        /// <summary>
        /// For first channel of the DIY-devices led 287.
        /// </summary>
        DIYChannel1Led287 = 1048,

        /// <summary>
        /// For first channel of the DIY-devices led 288.
        /// </summary>
        DIYChannel1Led288 = 1049,

        /// <summary>
        /// For first channel of the DIY-devices led 289.
        /// </summary>
        DIYChannel1Led289 = 1050,

        /// <summary>
        /// For first channel of the DIY-devices led 290.
        /// </summary>
        DIYChannel1Led290 = 1051,

        /// <summary>
        /// For first channel of the DIY-devices led 291.
        /// </summary>
        DIYChannel1Led291 = 1052,

        /// <summary>
        /// For first channel of the DIY-devices led 292.
        /// </summary>
        DIYChannel1Led292 = 1053,

        /// <summary>
        /// For first channel of the DIY-devices led 293.
        /// </summary>
        DIYChannel1Led293 = 1054,

        /// <summary>
        /// For first channel of the DIY-devices led 294.
        /// </summary>
        DIYChannel1Led294 = 1055,

        /// <summary>
        /// For first channel of the DIY-devices led 295.
        /// </summary>
        DIYChannel1Led295 = 1056,

        /// <summary>
        /// For first channel of the DIY-devices led 296.
        /// </summary>
        DIYChannel1Led296 = 1057,

        /// <summary>
        /// For first channel of the DIY-devices led 297.
        /// </summary>
        DIYChannel1Led297 = 1058,

        /// <summary>
        /// For first channel of the DIY-devices led 298.
        /// </summary>
        DIYChannel1Led298 = 1059,

        /// <summary>
        /// For first channel of the DIY-devices led 299.
        /// </summary>
        DIYChannel1Led299 = 1060,

        /// <summary>
        /// For first channel of the DIY-devices led 300.
        /// </summary>
        DIYChannel1Led300 = 1061,

        /// <summary>
        /// For second channel of the DIY-devices led 151.
        /// </summary>
        DIYChannel2Led151 = 1062,

        /// <summary>
        /// For second channel of the DIY-devices led 152.
        /// </summary>
        DIYChannel2Led152 = 1063,

        /// <summary>
        /// For second channel of the DIY-devices led 153.
        /// </summary>
        DIYChannel2Led153 = 1064,

        /// <summary>
        /// For second channel of the DIY-devices led 154.
        /// </summary>
        DIYChannel2Led154 = 1065,

        /// <summary>
        /// For second channel of the DIY-devices led 155.
        /// </summary>
        DIYChannel2Led155 = 1066,

        /// <summary>
        /// For second channel of the DIY-devices led 156.
        /// </summary>
        DIYChannel2Led156 = 1067,

        /// <summary>
        /// For second channel of the DIY-devices led 157.
        /// </summary>
        DIYChannel2Led157 = 1068,

        /// <summary>
        /// For second channel of the DIY-devices led 158.
        /// </summary>
        DIYChannel2Led158 = 1069,

        /// <summary>
        /// For second channel of the DIY-devices led 159.
        /// </summary>
        DIYChannel2Led159 = 1070,

        /// <summary>
        /// For second channel of the DIY-devices led 160.
        /// </summary>
        DIYChannel2Led160 = 1071,

        /// <summary>
        /// For second channel of the DIY-devices led 161.
        /// </summary>
        DIYChannel2Led161 = 1072,

        /// <summary>
        /// For second channel of the DIY-devices led 162.
        /// </summary>
        DIYChannel2Led162 = 1073,

        /// <summary>
        /// For second channel of the DIY-devices led 163.
        /// </summary>
        DIYChannel2Led163 = 1074,

        /// <summary>
        /// For second channel of the DIY-devices led 164.
        /// </summary>
        DIYChannel2Led164 = 1075,

        /// <summary>
        /// For second channel of the DIY-devices led 165.
        /// </summary>
        DIYChannel2Led165 = 1076,

        /// <summary>
        /// For second channel of the DIY-devices led 166.
        /// </summary>
        DIYChannel2Led166 = 1077,

        /// <summary>
        /// For second channel of the DIY-devices led 167.
        /// </summary>
        DIYChannel2Led167 = 1078,

        /// <summary>
        /// For second channel of the DIY-devices led 168.
        /// </summary>
        DIYChannel2Led168 = 1079,

        /// <summary>
        /// For second channel of the DIY-devices led 169.
        /// </summary>
        DIYChannel2Led169 = 1080,

        /// <summary>
        /// For second channel of the DIY-devices led 170.
        /// </summary>
        DIYChannel2Led170 = 1081,

        /// <summary>
        /// For second channel of the DIY-devices led 171.
        /// </summary>
        DIYChannel2Led171 = 1082,

        /// <summary>
        /// For second channel of the DIY-devices led 172.
        /// </summary>
        DIYChannel2Led172 = 1083,

        /// <summary>
        /// For second channel of the DIY-devices led 173.
        /// </summary>
        DIYChannel2Led173 = 1084,

        /// <summary>
        /// For second channel of the DIY-devices led 174.
        /// </summary>
        DIYChannel2Led174 = 1085,

        /// <summary>
        /// For second channel of the DIY-devices led 175.
        /// </summary>
        DIYChannel2Led175 = 1086,

        /// <summary>
        /// For second channel of the DIY-devices led 176.
        /// </summary>
        DIYChannel2Led176 = 1087,

        /// <summary>
        /// For second channel of the DIY-devices led 177.
        /// </summary>
        DIYChannel2Led177 = 1088,

        /// <summary>
        /// For second channel of the DIY-devices led 178.
        /// </summary>
        DIYChannel2Led178 = 1089,

        /// <summary>
        /// For second channel of the DIY-devices led 179.
        /// </summary>
        DIYChannel2Led179 = 1090,

        /// <summary>
        /// For second channel of the DIY-devices led 180.
        /// </summary>
        DIYChannel2Led180 = 1091,

        /// <summary>
        /// For second channel of the DIY-devices led 181.
        /// </summary>
        DIYChannel2Led181 = 1092,

        /// <summary>
        /// For second channel of the DIY-devices led 182.
        /// </summary>
        DIYChannel2Led182 = 1093,

        /// <summary>
        /// For second channel of the DIY-devices led 183.
        /// </summary>
        DIYChannel2Led183 = 1094,

        /// <summary>
        /// For second channel of the DIY-devices led 184.
        /// </summary>
        DIYChannel2Led184 = 1095,

        /// <summary>
        /// For second channel of the DIY-devices led 185.
        /// </summary>
        DIYChannel2Led185 = 1096,

        /// <summary>
        /// For second channel of the DIY-devices led 186.
        /// </summary>
        DIYChannel2Led186 = 1097,

        /// <summary>
        /// For second channel of the DIY-devices led 187.
        /// </summary>
        DIYChannel2Led187 = 1098,

        /// <summary>
        /// For second channel of the DIY-devices led 188.
        /// </summary>
        DIYChannel2Led188 = 1099,

        /// <summary>
        /// For second channel of the DIY-devices led 189.
        /// </summary>
        DIYChannel2Led189 = 1100,

        /// <summary>
        /// For second channel of the DIY-devices led 190.
        /// </summary>
        DIYChannel2Led190 = 1101,

        /// <summary>
        /// For second channel of the DIY-devices led 191.
        /// </summary>
        DIYChannel2Led191 = 1102,

        /// <summary>
        /// For second channel of the DIY-devices led 192.
        /// </summary>
        DIYChannel2Led192 = 1103,

        /// <summary>
        /// For second channel of the DIY-devices led 193.
        /// </summary>
        DIYChannel2Led193 = 1104,

        /// <summary>
        /// For second channel of the DIY-devices led 194.
        /// </summary>
        DIYChannel2Led194 = 1105,

        /// <summary>
        /// For second channel of the DIY-devices led 195.
        /// </summary>
        DIYChannel2Led195 = 1106,

        /// <summary>
        /// For second channel of the DIY-devices led 196.
        /// </summary>
        DIYChannel2Led196 = 1107,

        /// <summary>
        /// For second channel of the DIY-devices led 197.
        /// </summary>
        DIYChannel2Led197 = 1108,

        /// <summary>
        /// For second channel of the DIY-devices led 198.
        /// </summary>
        DIYChannel2Led198 = 1109,

        /// <summary>
        /// For second channel of the DIY-devices led 199.
        /// </summary>
        DIYChannel2Led199 = 1110,

        /// <summary>
        /// For second channel of the DIY-devices led 200.
        /// </summary>
        DIYChannel2Led200 = 1111,

        /// <summary>
        /// For second channel of the DIY-devices led 201.
        /// </summary>
        DIYChannel2Led201 = 1112,

        /// <summary>
        /// For second channel of the DIY-devices led 202.
        /// </summary>
        DIYChannel2Led202 = 1113,

        /// <summary>
        /// For second channel of the DIY-devices led 203.
        /// </summary>
        DIYChannel2Led203 = 1114,

        /// <summary>
        /// For second channel of the DIY-devices led 204.
        /// </summary>
        DIYChannel2Led204 = 1115,

        /// <summary>
        /// For second channel of the DIY-devices led 205.
        /// </summary>
        DIYChannel2Led205 = 1116,

        /// <summary>
        /// For second channel of the DIY-devices led 206.
        /// </summary>
        DIYChannel2Led206 = 1117,

        /// <summary>
        /// For second channel of the DIY-devices led 207.
        /// </summary>
        DIYChannel2Led207 = 1118,

        /// <summary>
        /// For second channel of the DIY-devices led 208.
        /// </summary>
        DIYChannel2Led208 = 1119,

        /// <summary>
        /// For second channel of the DIY-devices led 209.
        /// </summary>
        DIYChannel2Led209 = 1120,

        /// <summary>
        /// For second channel of the DIY-devices led 210.
        /// </summary>
        DIYChannel2Led210 = 1121,

        /// <summary>
        /// For second channel of the DIY-devices led 211.
        /// </summary>
        DIYChannel2Led211 = 1122,

        /// <summary>
        /// For second channel of the DIY-devices led 212.
        /// </summary>
        DIYChannel2Led212 = 1123,

        /// <summary>
        /// For second channel of the DIY-devices led 213.
        /// </summary>
        DIYChannel2Led213 = 1124,

        /// <summary>
        /// For second channel of the DIY-devices led 214.
        /// </summary>
        DIYChannel2Led214 = 1125,

        /// <summary>
        /// For second channel of the DIY-devices led 215.
        /// </summary>
        DIYChannel2Led215 = 1126,

        /// <summary>
        /// For second channel of the DIY-devices led 216.
        /// </summary>
        DIYChannel2Led216 = 1127,

        /// <summary>
        /// For second channel of the DIY-devices led 217.
        /// </summary>
        DIYChannel2Led217 = 1128,

        /// <summary>
        /// For second channel of the DIY-devices led 218.
        /// </summary>
        DIYChannel2Led218 = 1129,

        /// <summary>
        /// For second channel of the DIY-devices led 219.
        /// </summary>
        DIYChannel2Led219 = 1130,

        /// <summary>
        /// For second channel of the DIY-devices led 220.
        /// </summary>
        DIYChannel2Led220 = 1131,

        /// <summary>
        /// For second channel of the DIY-devices led 221.
        /// </summary>
        DIYChannel2Led221 = 1132,

        /// <summary>
        /// For second channel of the DIY-devices led 222.
        /// </summary>
        DIYChannel2Led222 = 1133,

        /// <summary>
        /// For second channel of the DIY-devices led 223.
        /// </summary>
        DIYChannel2Led223 = 1134,

        /// <summary>
        /// For second channel of the DIY-devices led 224.
        /// </summary>
        DIYChannel2Led224 = 1135,

        /// <summary>
        /// For second channel of the DIY-devices led 225.
        /// </summary>
        DIYChannel2Led225 = 1136,

        /// <summary>
        /// For second channel of the DIY-devices led 226.
        /// </summary>
        DIYChannel2Led226 = 1137,

        /// <summary>
        /// For second channel of the DIY-devices led 227.
        /// </summary>
        DIYChannel2Led227 = 1138,

        /// <summary>
        /// For second channel of the DIY-devices led 228.
        /// </summary>
        DIYChannel2Led228 = 1139,

        /// <summary>
        /// For second channel of the DIY-devices led 229.
        /// </summary>
        DIYChannel2Led229 = 1140,

        /// <summary>
        /// For second channel of the DIY-devices led 230.
        /// </summary>
        DIYChannel2Led230 = 1141,

        /// <summary>
        /// For second channel of the DIY-devices led 231.
        /// </summary>
        DIYChannel2Led231 = 1142,

        /// <summary>
        /// For second channel of the DIY-devices led 232.
        /// </summary>
        DIYChannel2Led232 = 1143,

        /// <summary>
        /// For second channel of the DIY-devices led 233.
        /// </summary>
        DIYChannel2Led233 = 1144,

        /// <summary>
        /// For second channel of the DIY-devices led 234.
        /// </summary>
        DIYChannel2Led234 = 1145,

        /// <summary>
        /// For second channel of the DIY-devices led 235.
        /// </summary>
        DIYChannel2Led235 = 1146,

        /// <summary>
        /// For second channel of the DIY-devices led 236.
        /// </summary>
        DIYChannel2Led236 = 1147,

        /// <summary>
        /// For second channel of the DIY-devices led 237.
        /// </summary>
        DIYChannel2Led237 = 1148,

        /// <summary>
        /// For second channel of the DIY-devices led 238.
        /// </summary>
        DIYChannel2Led238 = 1149,

        /// <summary>
        /// For second channel of the DIY-devices led 239.
        /// </summary>
        DIYChannel2Led239 = 1150,

        /// <summary>
        /// For second channel of the DIY-devices led 240.
        /// </summary>
        DIYChannel2Led240 = 1151,

        /// <summary>
        /// For second channel of the DIY-devices led 241.
        /// </summary>
        DIYChannel2Led241 = 1152,

        /// <summary>
        /// For second channel of the DIY-devices led 242.
        /// </summary>
        DIYChannel2Led242 = 1153,

        /// <summary>
        /// For second channel of the DIY-devices led 243.
        /// </summary>
        DIYChannel2Led243 = 1154,

        /// <summary>
        /// For second channel of the DIY-devices led 244.
        /// </summary>
        DIYChannel2Led244 = 1155,

        /// <summary>
        /// For second channel of the DIY-devices led 245.
        /// </summary>
        DIYChannel2Led245 = 1156,

        /// <summary>
        /// For second channel of the DIY-devices led 246.
        /// </summary>
        DIYChannel2Led246 = 1157,

        /// <summary>
        /// For second channel of the DIY-devices led 247.
        /// </summary>
        DIYChannel2Led247 = 1158,

        /// <summary>
        /// For second channel of the DIY-devices led 248.
        /// </summary>
        DIYChannel2Led248 = 1159,

        /// <summary>
        /// For second channel of the DIY-devices led 249.
        /// </summary>
        DIYChannel2Led249 = 1160,

        /// <summary>
        /// For second channel of the DIY-devices led 250.
        /// </summary>
        DIYChannel2Led250 = 1161,

        /// <summary>
        /// For second channel of the DIY-devices led 251.
        /// </summary>
        DIYChannel2Led251 = 1162,

        /// <summary>
        /// For second channel of the DIY-devices led 252.
        /// </summary>
        DIYChannel2Led252 = 1163,

        /// <summary>
        /// For second channel of the DIY-devices led 253.
        /// </summary>
        DIYChannel2Led253 = 1164,

        /// <summary>
        /// For second channel of the DIY-devices led 254.
        /// </summary>
        DIYChannel2Led254 = 1165,

        /// <summary>
        /// For second channel of the DIY-devices led 255.
        /// </summary>
        DIYChannel2Led255 = 1166,

        /// <summary>
        /// For second channel of the DIY-devices led 256.
        /// </summary>
        DIYChannel2Led256 = 1167,

        /// <summary>
        /// For second channel of the DIY-devices led 257.
        /// </summary>
        DIYChannel2Led257 = 1168,

        /// <summary>
        /// For second channel of the DIY-devices led 258.
        /// </summary>
        DIYChannel2Led258 = 1169,

        /// <summary>
        /// For second channel of the DIY-devices led 259.
        /// </summary>
        DIYChannel2Led259 = 1170,

        /// <summary>
        /// For second channel of the DIY-devices led 260.
        /// </summary>
        DIYChannel2Led260 = 1171,

        /// <summary>
        /// For second channel of the DIY-devices led 261.
        /// </summary>
        DIYChannel2Led261 = 1172,

        /// <summary>
        /// For second channel of the DIY-devices led 262.
        /// </summary>
        DIYChannel2Led262 = 1173,

        /// <summary>
        /// For second channel of the DIY-devices led 263.
        /// </summary>
        DIYChannel2Led263 = 1174,

        /// <summary>
        /// For second channel of the DIY-devices led 264.
        /// </summary>
        DIYChannel2Led264 = 1175,

        /// <summary>
        /// For second channel of the DIY-devices led 265.
        /// </summary>
        DIYChannel2Led265 = 1176,

        /// <summary>
        /// For second channel of the DIY-devices led 266.
        /// </summary>
        DIYChannel2Led266 = 1177,

        /// <summary>
        /// For second channel of the DIY-devices led 267.
        /// </summary>
        DIYChannel2Led267 = 1178,

        /// <summary>
        /// For second channel of the DIY-devices led 268.
        /// </summary>
        DIYChannel2Led268 = 1179,

        /// <summary>
        /// For second channel of the DIY-devices led 269.
        /// </summary>
        DIYChannel2Led269 = 1180,

        /// <summary>
        /// For second channel of the DIY-devices led 270.
        /// </summary>
        DIYChannel2Led270 = 1181,

        /// <summary>
        /// For second channel of the DIY-devices led 271.
        /// </summary>
        DIYChannel2Led271 = 1182,

        /// <summary>
        /// For second channel of the DIY-devices led 272.
        /// </summary>
        DIYChannel2Led272 = 1183,

        /// <summary>
        /// For second channel of the DIY-devices led 273.
        /// </summary>
        DIYChannel2Led273 = 1184,

        /// <summary>
        /// For second channel of the DIY-devices led 274.
        /// </summary>
        DIYChannel2Led274 = 1185,

        /// <summary>
        /// For second channel of the DIY-devices led 275.
        /// </summary>
        DIYChannel2Led275 = 1186,

        /// <summary>
        /// For second channel of the DIY-devices led 276.
        /// </summary>
        DIYChannel2Led276 = 1187,

        /// <summary>
        /// For second channel of the DIY-devices led 277.
        /// </summary>
        DIYChannel2Led277 = 1188,

        /// <summary>
        /// For second channel of the DIY-devices led 278.
        /// </summary>
        DIYChannel2Led278 = 1189,

        /// <summary>
        /// For second channel of the DIY-devices led 279.
        /// </summary>
        DIYChannel2Led279 = 1190,

        /// <summary>
        /// For second channel of the DIY-devices led 280.
        /// </summary>
        DIYChannel2Led280 = 1191,

        /// <summary>
        /// For second channel of the DIY-devices led 281.
        /// </summary>
        DIYChannel2Led281 = 1192,

        /// <summary>
        /// For second channel of the DIY-devices led 282.
        /// </summary>
        DIYChannel2Led282 = 1193,

        /// <summary>
        /// For second channel of the DIY-devices led 283.
        /// </summary>
        DIYChannel2Led283 = 1194,

        /// <summary>
        /// For second channel of the DIY-devices led 284.
        /// </summary>
        DIYChannel2Led284 = 1195,

        /// <summary>
        /// For second channel of the DIY-devices led 285.
        /// </summary>
        DIYChannel2Led285 = 1196,

        /// <summary>
        /// For second channel of the DIY-devices led 286.
        /// </summary>
        DIYChannel2Led286 = 1197,

        /// <summary>
        /// For second channel of the DIY-devices led 287.
        /// </summary>
        DIYChannel2Led287 = 1198,

        /// <summary>
        /// For second channel of the DIY-devices led 288.
        /// </summary>
        DIYChannel2Led288 = 1199,

        /// <summary>
        /// For second channel of the DIY-devices led 289.
        /// </summary>
        DIYChannel2Led289 = 1200,

        /// <summary>
        /// For second channel of the DIY-devices led 290.
        /// </summary>
        DIYChannel2Led290 = 1201,

        /// <summary>
        /// For second channel of the DIY-devices led 291.
        /// </summary>
        DIYChannel2Led291 = 1202,

        /// <summary>
        /// For second channel of the DIY-devices led 292.
        /// </summary>
        DIYChannel2Led292 = 1203,

        /// <summary>
        /// For second channel of the DIY-devices led 293.
        /// </summary>
        DIYChannel2Led293 = 1204,

        /// <summary>
        /// For second channel of the DIY-devices led 294.
        /// </summary>
        DIYChannel2Led294 = 1205,

        /// <summary>
        /// For second channel of the DIY-devices led 295.
        /// </summary>
        DIYChannel2Led295 = 1206,

        /// <summary>
        /// For second channel of the DIY-devices led 296.
        /// </summary>
        DIYChannel2Led296 = 1207,

        /// <summary>
        /// For second channel of the DIY-devices led 297.
        /// </summary>
        DIYChannel2Led297 = 1208,

        /// <summary>
        /// For second channel of the DIY-devices led 298.
        /// </summary>
        DIYChannel2Led298 = 1209,

        /// <summary>
        /// For second channel of the DIY-devices led 299.
        /// </summary>
        DIYChannel2Led299 = 1210,

        /// <summary>
        /// For second channel of the DIY-devices led 300.
        /// </summary>
        DIYChannel2Led300 = 1211,

        /// <summary>
        /// For third channel of the DIY-devices led 151.
        /// </summary>
        DIYChannel3Led151 = 1212,

        /// <summary>
        /// For third channel of the DIY-devices led 152.
        /// </summary>
        DIYChannel3Led152 = 1213,

        /// <summary>
        /// For third channel of the DIY-devices led 153.
        /// </summary>
        DIYChannel3Led153 = 1214,

        /// <summary>
        /// For third channel of the DIY-devices led 154.
        /// </summary>
        DIYChannel3Led154 = 1215,

        /// <summary>
        /// For third channel of the DIY-devices led 155.
        /// </summary>
        DIYChannel3Led155 = 1216,

        /// <summary>
        /// For third channel of the DIY-devices led 156.
        /// </summary>
        DIYChannel3Led156 = 1217,

        /// <summary>
        /// For third channel of the DIY-devices led 157.
        /// </summary>
        DIYChannel3Led157 = 1218,

        /// <summary>
        /// For third channel of the DIY-devices led 158.
        /// </summary>
        DIYChannel3Led158 = 1219,

        /// <summary>
        /// For third channel of the DIY-devices led 159.
        /// </summary>
        DIYChannel3Led159 = 1220,

        /// <summary>
        /// For third channel of the DIY-devices led 160.
        /// </summary>
        DIYChannel3Led160 = 1221,

        /// <summary>
        /// For third channel of the DIY-devices led 161.
        /// </summary>
        DIYChannel3Led161 = 1222,

        /// <summary>
        /// For third channel of the DIY-devices led 162.
        /// </summary>
        DIYChannel3Led162 = 1223,

        /// <summary>
        /// For third channel of the DIY-devices led 163.
        /// </summary>
        DIYChannel3Led163 = 1224,

        /// <summary>
        /// For third channel of the DIY-devices led 164.
        /// </summary>
        DIYChannel3Led164 = 1225,

        /// <summary>
        /// For third channel of the DIY-devices led 165.
        /// </summary>
        DIYChannel3Led165 = 1226,

        /// <summary>
        /// For third channel of the DIY-devices led 166.
        /// </summary>
        DIYChannel3Led166 = 1227,

        /// <summary>
        /// For third channel of the DIY-devices led 167.
        /// </summary>
        DIYChannel3Led167 = 1228,

        /// <summary>
        /// For third channel of the DIY-devices led 168.
        /// </summary>
        DIYChannel3Led168 = 1229,

        /// <summary>
        /// For third channel of the DIY-devices led 169.
        /// </summary>
        DIYChannel3Led169 = 1230,

        /// <summary>
        /// For third channel of the DIY-devices led 170.
        /// </summary>
        DIYChannel3Led170 = 1231,

        /// <summary>
        /// For third channel of the DIY-devices led 171.
        /// </summary>
        DIYChannel3Led171 = 1232,

        /// <summary>
        /// For third channel of the DIY-devices led 172.
        /// </summary>
        DIYChannel3Led172 = 1233,

        /// <summary>
        /// For third channel of the DIY-devices led 173.
        /// </summary>
        DIYChannel3Led173 = 1234,

        /// <summary>
        /// For third channel of the DIY-devices led 174.
        /// </summary>
        DIYChannel3Led174 = 1235,

        /// <summary>
        /// For third channel of the DIY-devices led 175.
        /// </summary>
        DIYChannel3Led175 = 1236,

        /// <summary>
        /// For third channel of the DIY-devices led 176.
        /// </summary>
        DIYChannel3Led176 = 1237,

        /// <summary>
        /// For third channel of the DIY-devices led 177.
        /// </summary>
        DIYChannel3Led177 = 1238,

        /// <summary>
        /// For third channel of the DIY-devices led 178.
        /// </summary>
        DIYChannel3Led178 = 1239,

        /// <summary>
        /// For third channel of the DIY-devices led 179.
        /// </summary>
        DIYChannel3Led179 = 1240,

        /// <summary>
        /// For third channel of the DIY-devices led 180.
        /// </summary>
        DIYChannel3Led180 = 1241,

        /// <summary>
        /// For third channel of the DIY-devices led 181.
        /// </summary>
        DIYChannel3Led181 = 1242,

        /// <summary>
        /// For third channel of the DIY-devices led 182.
        /// </summary>
        DIYChannel3Led182 = 1243,

        /// <summary>
        /// For third channel of the DIY-devices led 183.
        /// </summary>
        DIYChannel3Led183 = 1244,

        /// <summary>
        /// For third channel of the DIY-devices led 184.
        /// </summary>
        DIYChannel3Led184 = 1245,

        /// <summary>
        /// For third channel of the DIY-devices led 185.
        /// </summary>
        DIYChannel3Led185 = 1246,

        /// <summary>
        /// For third channel of the DIY-devices led 186.
        /// </summary>
        DIYChannel3Led186 = 1247,

        /// <summary>
        /// For third channel of the DIY-devices led 187.
        /// </summary>
        DIYChannel3Led187 = 1248,

        /// <summary>
        /// For third channel of the DIY-devices led 188.
        /// </summary>
        DIYChannel3Led188 = 1249,

        /// <summary>
        /// For third channel of the DIY-devices led 189.
        /// </summary>
        DIYChannel3Led189 = 1250,

        /// <summary>
        /// For third channel of the DIY-devices led 190.
        /// </summary>
        DIYChannel3Led190 = 1251,

        /// <summary>
        /// For third channel of the DIY-devices led 191.
        /// </summary>
        DIYChannel3Led191 = 1252,

        /// <summary>
        /// For third channel of the DIY-devices led 192.
        /// </summary>
        DIYChannel3Led192 = 1253,

        /// <summary>
        /// For third channel of the DIY-devices led 193.
        /// </summary>
        DIYChannel3Led193 = 1254,

        /// <summary>
        /// For third channel of the DIY-devices led 194.
        /// </summary>
        DIYChannel3Led194 = 1255,

        /// <summary>
        /// For third channel of the DIY-devices led 195.
        /// </summary>
        DIYChannel3Led195 = 1256,

        /// <summary>
        /// For third channel of the DIY-devices led 196.
        /// </summary>
        DIYChannel3Led196 = 1257,

        /// <summary>
        /// For third channel of the DIY-devices led 197.
        /// </summary>
        DIYChannel3Led197 = 1258,

        /// <summary>
        /// For third channel of the DIY-devices led 198.
        /// </summary>
        DIYChannel3Led198 = 1259,

        /// <summary>
        /// For third channel of the DIY-devices led 199.
        /// </summary>
        DIYChannel3Led199 = 1260,

        /// <summary>
        /// For third channel of the DIY-devices led 200.
        /// </summary>
        DIYChannel3Led200 = 1261,

        /// <summary>
        /// For third channel of the DIY-devices led 201.
        /// </summary>
        DIYChannel3Led201 = 1262,

        /// <summary>
        /// For third channel of the DIY-devices led 202.
        /// </summary>
        DIYChannel3Led202 = 1263,

        /// <summary>
        /// For third channel of the DIY-devices led 203.
        /// </summary>
        DIYChannel3Led203 = 1264,

        /// <summary>
        /// For third channel of the DIY-devices led 204.
        /// </summary>
        DIYChannel3Led204 = 1265,

        /// <summary>
        /// For third channel of the DIY-devices led 205.
        /// </summary>
        DIYChannel3Led205 = 1266,

        /// <summary>
        /// For third channel of the DIY-devices led 206.
        /// </summary>
        DIYChannel3Led206 = 1267,

        /// <summary>
        /// For third channel of the DIY-devices led 207.
        /// </summary>
        DIYChannel3Led207 = 1268,

        /// <summary>
        /// For third channel of the DIY-devices led 208.
        /// </summary>
        DIYChannel3Led208 = 1269,

        /// <summary>
        /// For third channel of the DIY-devices led 209.
        /// </summary>
        DIYChannel3Led209 = 1270,

        /// <summary>
        /// For third channel of the DIY-devices led 210.
        /// </summary>
        DIYChannel3Led210 = 1271,

        /// <summary>
        /// For third channel of the DIY-devices led 211.
        /// </summary>
        DIYChannel3Led211 = 1272,

        /// <summary>
        /// For third channel of the DIY-devices led 212.
        /// </summary>
        DIYChannel3Led212 = 1273,

        /// <summary>
        /// For third channel of the DIY-devices led 213.
        /// </summary>
        DIYChannel3Led213 = 1274,

        /// <summary>
        /// For third channel of the DIY-devices led 214.
        /// </summary>
        DIYChannel3Led214 = 1275,

        /// <summary>
        /// For third channel of the DIY-devices led 215.
        /// </summary>
        DIYChannel3Led215 = 1276,

        /// <summary>
        /// For third channel of the DIY-devices led 216.
        /// </summary>
        DIYChannel3Led216 = 1277,

        /// <summary>
        /// For third channel of the DIY-devices led 217.
        /// </summary>
        DIYChannel3Led217 = 1278,

        /// <summary>
        /// For third channel of the DIY-devices led 218.
        /// </summary>
        DIYChannel3Led218 = 1279,

        /// <summary>
        /// For third channel of the DIY-devices led 219.
        /// </summary>
        DIYChannel3Led219 = 1280,

        /// <summary>
        /// For third channel of the DIY-devices led 220.
        /// </summary>
        DIYChannel3Led220 = 1281,

        /// <summary>
        /// For third channel of the DIY-devices led 221.
        /// </summary>
        DIYChannel3Led221 = 1282,

        /// <summary>
        /// For third channel of the DIY-devices led 222.
        /// </summary>
        DIYChannel3Led222 = 1283,

        /// <summary>
        /// For third channel of the DIY-devices led 223.
        /// </summary>
        DIYChannel3Led223 = 1284,

        /// <summary>
        /// For third channel of the DIY-devices led 224.
        /// </summary>
        DIYChannel3Led224 = 1285,

        /// <summary>
        /// For third channel of the DIY-devices led 225.
        /// </summary>
        DIYChannel3Led225 = 1286,

        /// <summary>
        /// For third channel of the DIY-devices led 226.
        /// </summary>
        DIYChannel3Led226 = 1287,

        /// <summary>
        /// For third channel of the DIY-devices led 227.
        /// </summary>
        DIYChannel3Led227 = 1288,

        /// <summary>
        /// For third channel of the DIY-devices led 228.
        /// </summary>
        DIYChannel3Led228 = 1289,

        /// <summary>
        /// For third channel of the DIY-devices led 229.
        /// </summary>
        DIYChannel3Led229 = 1290,

        /// <summary>
        /// For third channel of the DIY-devices led 230.
        /// </summary>
        DIYChannel3Led230 = 1291,

        /// <summary>
        /// For third channel of the DIY-devices led 231.
        /// </summary>
        DIYChannel3Led231 = 1292,

        /// <summary>
        /// For third channel of the DIY-devices led 232.
        /// </summary>
        DIYChannel3Led232 = 1293,

        /// <summary>
        /// For third channel of the DIY-devices led 233.
        /// </summary>
        DIYChannel3Led233 = 1294,

        /// <summary>
        /// For third channel of the DIY-devices led 234.
        /// </summary>
        DIYChannel3Led234 = 1295,

        /// <summary>
        /// For third channel of the DIY-devices led 235.
        /// </summary>
        DIYChannel3Led235 = 1296,

        /// <summary>
        /// For third channel of the DIY-devices led 236.
        /// </summary>
        DIYChannel3Led236 = 1297,

        /// <summary>
        /// For third channel of the DIY-devices led 237.
        /// </summary>
        DIYChannel3Led237 = 1298,

        /// <summary>
        /// For third channel of the DIY-devices led 238.
        /// </summary>
        DIYChannel3Led238 = 1299,

        /// <summary>
        /// For third channel of the DIY-devices led 239.
        /// </summary>
        DIYChannel3Led239 = 1300,

        /// <summary>
        /// For third channel of the DIY-devices led 240.
        /// </summary>
        DIYChannel3Led240 = 1301,

        /// <summary>
        /// For third channel of the DIY-devices led 241.
        /// </summary>
        DIYChannel3Led241 = 1302,

        /// <summary>
        /// For third channel of the DIY-devices led 242.
        /// </summary>
        DIYChannel3Led242 = 1303,

        /// <summary>
        /// For third channel of the DIY-devices led 243.
        /// </summary>
        DIYChannel3Led243 = 1304,

        /// <summary>
        /// For third channel of the DIY-devices led 244.
        /// </summary>
        DIYChannel3Led244 = 1305,

        /// <summary>
        /// For third channel of the DIY-devices led 245.
        /// </summary>
        DIYChannel3Led245 = 1306,

        /// <summary>
        /// For third channel of the DIY-devices led 246.
        /// </summary>
        DIYChannel3Led246 = 1307,

        /// <summary>
        /// For third channel of the DIY-devices led 247.
        /// </summary>
        DIYChannel3Led247 = 1308,

        /// <summary>
        /// For third channel of the DIY-devices led 248.
        /// </summary>
        DIYChannel3Led248 = 1309,

        /// <summary>
        /// For third channel of the DIY-devices led 249.
        /// </summary>
        DIYChannel3Led249 = 1310,

        /// <summary>
        /// For third channel of the DIY-devices led 250.
        /// </summary>
        DIYChannel3Led250 = 1311,

        /// <summary>
        /// For third channel of the DIY-devices led 251.
        /// </summary>
        DIYChannel3Led251 = 1312,

        /// <summary>
        /// For third channel of the DIY-devices led 252.
        /// </summary>
        DIYChannel3Led252 = 1313,

        /// <summary>
        /// For third channel of the DIY-devices led 253.
        /// </summary>
        DIYChannel3Led253 = 1314,

        /// <summary>
        /// For third channel of the DIY-devices led 254.
        /// </summary>
        DIYChannel3Led254 = 1315,

        /// <summary>
        /// For third channel of the DIY-devices led 255.
        /// </summary>
        DIYChannel3Led255 = 1316,

        /// <summary>
        /// For third channel of the DIY-devices led 256.
        /// </summary>
        DIYChannel3Led256 = 1317,

        /// <summary>
        /// For third channel of the DIY-devices led 257.
        /// </summary>
        DIYChannel3Led257 = 1318,

        /// <summary>
        /// For third channel of the DIY-devices led 258.
        /// </summary>
        DIYChannel3Led258 = 1319,

        /// <summary>
        /// For third channel of the DIY-devices led 259.
        /// </summary>
        DIYChannel3Led259 = 1320,

        /// <summary>
        /// For third channel of the DIY-devices led 260.
        /// </summary>
        DIYChannel3Led260 = 1321,

        /// <summary>
        /// For third channel of the DIY-devices led 261.
        /// </summary>
        DIYChannel3Led261 = 1322,

        /// <summary>
        /// For third channel of the DIY-devices led 262.
        /// </summary>
        DIYChannel3Led262 = 1323,

        /// <summary>
        /// For third channel of the DIY-devices led 263.
        /// </summary>
        DIYChannel3Led263 = 1324,

        /// <summary>
        /// For third channel of the DIY-devices led 264.
        /// </summary>
        DIYChannel3Led264 = 1325,

        /// <summary>
        /// For third channel of the DIY-devices led 265.
        /// </summary>
        DIYChannel3Led265 = 1326,

        /// <summary>
        /// For third channel of the DIY-devices led 266.
        /// </summary>
        DIYChannel3Led266 = 1327,

        /// <summary>
        /// For third channel of the DIY-devices led 267.
        /// </summary>
        DIYChannel3Led267 = 1328,

        /// <summary>
        /// For third channel of the DIY-devices led 268.
        /// </summary>
        DIYChannel3Led268 = 1329,

        /// <summary>
        /// For third channel of the DIY-devices led 269.
        /// </summary>
        DIYChannel3Led269 = 1330,

        /// <summary>
        /// For third channel of the DIY-devices led 270.
        /// </summary>
        DIYChannel3Led270 = 1331,

        /// <summary>
        /// For third channel of the DIY-devices led 271.
        /// </summary>
        DIYChannel3Led271 = 1332,

        /// <summary>
        /// For third channel of the DIY-devices led 272.
        /// </summary>
        DIYChannel3Led272 = 1333,

        /// <summary>
        /// For third channel of the DIY-devices led 273.
        /// </summary>
        DIYChannel3Led273 = 1334,

        /// <summary>
        /// For third channel of the DIY-devices led 274.
        /// </summary>
        DIYChannel3Led274 = 1335,

        /// <summary>
        /// For third channel of the DIY-devices led 275.
        /// </summary>
        DIYChannel3Led275 = 1336,

        /// <summary>
        /// For third channel of the DIY-devices led 276.
        /// </summary>
        DIYChannel3Led276 = 1337,

        /// <summary>
        /// For third channel of the DIY-devices led 277.
        /// </summary>
        DIYChannel3Led277 = 1338,

        /// <summary>
        /// For third channel of the DIY-devices led 278.
        /// </summary>
        DIYChannel3Led278 = 1339,

        /// <summary>
        /// For third channel of the DIY-devices led 279.
        /// </summary>
        DIYChannel3Led279 = 1340,

        /// <summary>
        /// For third channel of the DIY-devices led 280.
        /// </summary>
        DIYChannel3Led280 = 1341,

        /// <summary>
        /// For third channel of the DIY-devices led 281.
        /// </summary>
        DIYChannel3Led281 = 1342,

        /// <summary>
        /// For third channel of the DIY-devices led 282.
        /// </summary>
        DIYChannel3Led282 = 1343,

        /// <summary>
        /// For third channel of the DIY-devices led 283.
        /// </summary>
        DIYChannel3Led283 = 1344,

        /// <summary>
        /// For third channel of the DIY-devices led 284.
        /// </summary>
        DIYChannel3Led284 = 1345,

        /// <summary>
        /// For third channel of the DIY-devices led 285.
        /// </summary>
        DIYChannel3Led285 = 1346,

        /// <summary>
        /// For third channel of the DIY-devices led 286.
        /// </summary>
        DIYChannel3Led286 = 1347,

        /// <summary>
        /// For third channel of the DIY-devices led 287.
        /// </summary>
        DIYChannel3Led287 = 1348,

        /// <summary>
        /// For third channel of the DIY-devices led 288.
        /// </summary>
        DIYChannel3Led288 = 1349,

        /// <summary>
        /// For third channel of the DIY-devices led 289.
        /// </summary>
        DIYChannel3Led289 = 1350,

        /// <summary>
        /// For third channel of the DIY-devices led 290.
        /// </summary>
        DIYChannel3Led290 = 1351,

        /// <summary>
        /// For third channel of the DIY-devices led 291.
        /// </summary>
        DIYChannel3Led291 = 1352,

        /// <summary>
        /// For third channel of the DIY-devices led 292.
        /// </summary>
        DIYChannel3Led292 = 1353,

        /// <summary>
        /// For third channel of the DIY-devices led 293.
        /// </summary>
        DIYChannel3Led293 = 1354,

        /// <summary>
        /// For third channel of the DIY-devices led 294.
        /// </summary>
        DIYChannel3Led294 = 1355,

        /// <summary>
        /// For third channel of the DIY-devices led 295.
        /// </summary>
        DIYChannel3Led295 = 1356,

        /// <summary>
        /// For third channel of the DIY-devices led 296.
        /// </summary>
        DIYChannel3Led296 = 1357,

        /// <summary>
        /// For third channel of the DIY-devices led 297.
        /// </summary>
        DIYChannel3Led297 = 1358,

        /// <summary>
        /// For third channel of the DIY-devices led 298.
        /// </summary>
        DIYChannel3Led298 = 1359,

        /// <summary>
        /// For third channel of the DIY-devices led 299.
        /// </summary>
        DIYChannel3Led299 = 1360,

        /// <summary>
        /// For third channel of the DIY-devices led 300.
        /// </summary>
        DIYChannel3Led300 = 1361,

        /// <summary>
        /// For motherboard zone 1 led.
        /// </summary>
        MotherboardZone1 = 1362,

        /// <summary>
        /// For motherboard zone 2 led.
        /// </summary>
        MotherboardZone2 = 1363,

        /// <summary>
        /// For motherboard zone 3 led.
        /// </summary>
        MotherboardZone3 = 1364,

        /// <summary>
        /// For motherboard zone 4 led.
        /// </summary>
        MotherboardZone4 = 1365,

        /// <summary>
        /// For motherboard zone 5 led.
        /// </summary>
        MotherboardZone5 = 1366,

        /// <summary>
        /// For motherboard zone 6 led.
        /// </summary>
        MotherboardZone6 = 1367,

        /// <summary>
        /// For motherboard zone 7 led.
        /// </summary>
        MotherboardZone7 = 1368,

        /// <summary>
        /// For motherboard zone 8 led.
        /// </summary>
        MotherboardZone8 = 1369,

        /// <summary>
        /// For motherboard zone 9 led.
        /// </summary>
        MotherboardZone9 = 1370,

        /// <summary>
        /// For motherboard zone 10 led.
        /// </summary>
        MotherboardZone10 = 1371,

        /// <summary>
        /// For motherboard zone 11 led.
        /// </summary>
        MotherboardZone11 = 1372,

        /// <summary>
        /// For motherboard zone 12 led.
        /// </summary>
        MotherboardZone12 = 1373,

        /// <summary>
        /// For motherboard zone 13 led.
        /// </summary>
        MotherboardZone13 = 1374,

        /// <summary>
        /// For motherboard zone 14 led.
        /// </summary>
        MotherboardZone14 = 1375,

        /// <summary>
        /// For motherboard zone 15 led.
        /// </summary>
        MotherboardZone15 = 1376,

        /// <summary>
        /// For motherboard zone 16 led.
        /// </summary>
        MotherboardZone16 = 1377,

        /// <summary>
        /// For motherboard zone 17 led.
        /// </summary>
        MotherboardZone17 = 1378,

        /// <summary>
        /// For motherboard zone 18 led.
        /// </summary>
        MotherboardZone18 = 1379,

        /// <summary>
        /// For motherboard zone 19 led.
        /// </summary>
        MotherboardZone19 = 1380,

        /// <summary>
        /// For motherboard zone 20 led.
        /// </summary>
        MotherboardZone20 = 1381,

        /// <summary>
        /// For motherboard zone 21 led.
        /// </summary>
        MotherboardZone21 = 1382,

        /// <summary>
        /// For motherboard zone 22 led.
        /// </summary>
        MotherboardZone22 = 1383,

        /// <summary>
        /// For motherboard zone 23 led.
        /// </summary>
        MotherboardZone23 = 1384,

        /// <summary>
        /// For motherboard zone 24 led.
        /// </summary>
        MotherboardZone24 = 1385,

        /// <summary>
        /// For motherboard zone 25 led.
        /// </summary>
        MotherboardZone25 = 1386,

        /// <summary>
        /// For motherboard zone 26 led.
        /// </summary>
        MotherboardZone26 = 1387,

        /// <summary>
        /// For motherboard zone 27 led.
        /// </summary>
        MotherboardZone27 = 1388,

        /// <summary>
        /// For motherboard zone 28 led.
        /// </summary>
        MotherboardZone28 = 1389,

        /// <summary>
        /// For motherboard zone 29 led.
        /// </summary>
        MotherboardZone29 = 1390,

        /// <summary>
        /// For motherboard zone 30 led.
        /// </summary>
        MotherboardZone30 = 1391,

        /// <summary>
        /// For motherboard zone 31 led.
        /// </summary>
        MotherboardZone31 = 1392,

        /// <summary>
        /// For motherboard zone 32 led.
        /// </summary>
        MotherboardZone32 = 1393,

        /// <summary>
        /// For motherboard zone 33 led.
        /// </summary>
        MotherboardZone33 = 1394,

        /// <summary>
        /// For motherboard zone 34 led.
        /// </summary>
        MotherboardZone34 = 1395,

        /// <summary>
        /// For motherboard zone 35 led.
        /// </summary>
        MotherboardZone35 = 1396,

        /// <summary>
        /// For motherboard zone 36 led.
        /// </summary>
        MotherboardZone36 = 1397,

        /// <summary>
        /// For motherboard zone 37 led.
        /// </summary>
        MotherboardZone37 = 1398,

        /// <summary>
        /// For motherboard zone 38 led.
        /// </summary>
        MotherboardZone38 = 1399,

        /// <summary>
        /// For motherboard zone 39 led.
        /// </summary>
        MotherboardZone39 = 1400,

        /// <summary>
        /// For motherboard zone 40 led.
        /// </summary>
        MotherboardZone40 = 1401,

        /// <summary>
        /// For motherboard zone 41 led.
        /// </summary>
        MotherboardZone41 = 1402,

        /// <summary>
        /// For motherboard zone 42 led.
        /// </summary>
        MotherboardZone42 = 1403,

        /// <summary>
        /// For motherboard zone 43 led.
        /// </summary>
        MotherboardZone43 = 1404,

        /// <summary>
        /// For motherboard zone 44 led.
        /// </summary>
        MotherboardZone44 = 1405,

        /// <summary>
        /// For motherboard zone 45 led.
        /// </summary>
        MotherboardZone45 = 1406,

        /// <summary>
        /// For motherboard zone 46 led.
        /// </summary>
        MotherboardZone46 = 1407,

        /// <summary>
        /// For motherboard zone 47 led.
        /// </summary>
        MotherboardZone47 = 1408,

        /// <summary>
        /// For motherboard zone 48 led.
        /// </summary>
        MotherboardZone48 = 1409,

        /// <summary>
        /// For motherboard zone 49 led.
        /// </summary>
        MotherboardZone49 = 1410,

        /// <summary>
        /// For motherboard zone 50 led.
        /// </summary>
        MotherboardZone50 = 1411,

        /// <summary>
        /// For motherboard zone 51 led.
        /// </summary>
        MotherboardZone51 = 1412,

        /// <summary>
        /// For motherboard zone 52 led.
        /// </summary>
        MotherboardZone52 = 1413,

        /// <summary>
        /// For motherboard zone 53 led.
        /// </summary>
        MotherboardZone53 = 1414,

        /// <summary>
        /// For motherboard zone 54 led.
        /// </summary>
        MotherboardZone54 = 1415,

        /// <summary>
        /// For motherboard zone 55 led.
        /// </summary>
        MotherboardZone55 = 1416,

        /// <summary>
        /// For motherboard zone 56 led.
        /// </summary>
        MotherboardZone56 = 1417,

        /// <summary>
        /// For motherboard zone 57 led.
        /// </summary>
        MotherboardZone57 = 1418,

        /// <summary>
        /// For motherboard zone 58 led.
        /// </summary>
        MotherboardZone58 = 1419,

        /// <summary>
        /// For motherboard zone 59 led.
        /// </summary>
        MotherboardZone59 = 1420,

        /// <summary>
        /// For motherboard zone 60 led.
        /// </summary>
        MotherboardZone60 = 1421,

        /// <summary>
        /// For motherboard zone 61 led.
        /// </summary>
        MotherboardZone61 = 1422,

        /// <summary>
        /// For motherboard zone 62 led.
        /// </summary>
        MotherboardZone62 = 1423,

        /// <summary>
        /// For motherboard zone 63 led.
        /// </summary>
        MotherboardZone63 = 1424,

        /// <summary>
        /// For motherboard zone 64 led.
        /// </summary>
        MotherboardZone64 = 1425,

        /// <summary>
        /// For motherboard zone 65 led.
        /// </summary>
        MotherboardZone65 = 1426,

        /// <summary>
        /// For motherboard zone 66 led.
        /// </summary>
        MotherboardZone66 = 1427,

        /// <summary>
        /// For motherboard zone 67 led.
        /// </summary>
        MotherboardZone67 = 1428,

        /// <summary>
        /// For motherboard zone 68 led.
        /// </summary>
        MotherboardZone68 = 1429,

        /// <summary>
        /// For motherboard zone 69 led.
        /// </summary>
        MotherboardZone69 = 1430,

        /// <summary>
        /// For motherboard zone 70 led.
        /// </summary>
        MotherboardZone70 = 1431,

        /// <summary>
        /// For motherboard zone 71 led.
        /// </summary>
        MotherboardZone71 = 1432,

        /// <summary>
        /// For motherboard zone 72 led.
        /// </summary>
        MotherboardZone72 = 1433,

        /// <summary>
        /// For motherboard zone 73 led.
        /// </summary>
        MotherboardZone73 = 1434,

        /// <summary>
        /// For motherboard zone 74 led.
        /// </summary>
        MotherboardZone74 = 1435,

        /// <summary>
        /// For motherboard zone 75 led.
        /// </summary>
        MotherboardZone75 = 1436,

        /// <summary>
        /// For motherboard zone 76 led.
        /// </summary>
        MotherboardZone76 = 1437,

        /// <summary>
        /// For motherboard zone 77 led.
        /// </summary>
        MotherboardZone77 = 1438,

        /// <summary>
        /// For motherboard zone 78 led.
        /// </summary>
        MotherboardZone78 = 1439,

        /// <summary>
        /// For motherboard zone 79 led.
        /// </summary>
        MotherboardZone79 = 1440,

        /// <summary>
        /// For motherboard zone 80 led.
        /// </summary>
        MotherboardZone80 = 1441,

        /// <summary>
        /// For motherboard zone 81 led.
        /// </summary>
        MotherboardZone81 = 1442,

        /// <summary>
        /// For motherboard zone 82 led.
        /// </summary>
        MotherboardZone82 = 1443,

        /// <summary>
        /// For motherboard zone 83 led.
        /// </summary>
        MotherboardZone83 = 1444,

        /// <summary>
        /// For motherboard zone 84 led.
        /// </summary>
        MotherboardZone84 = 1445,

        /// <summary>
        /// For motherboard zone 85 led.
        /// </summary>
        MotherboardZone85 = 1446,

        /// <summary>
        /// For motherboard zone 86 led.
        /// </summary>
        MotherboardZone86 = 1447,

        /// <summary>
        /// For motherboard zone 87 led.
        /// </summary>
        MotherboardZone87 = 1448,

        /// <summary>
        /// For motherboard zone 88 led.
        /// </summary>
        MotherboardZone88 = 1449,

        /// <summary>
        /// For motherboard zone 89 led.
        /// </summary>
        MotherboardZone89 = 1450,

        /// <summary>
        /// For motherboard zone 90 led.
        /// </summary>
        MotherboardZone90 = 1451,

        /// <summary>
        /// For motherboard zone 91 led.
        /// </summary>
        MotherboardZone91 = 1452,

        /// <summary>
        /// For motherboard zone 92 led.
        /// </summary>
        MotherboardZone92 = 1453,

        /// <summary>
        /// For motherboard zone 93 led.
        /// </summary>
        MotherboardZone93 = 1454,

        /// <summary>
        /// For motherboard zone 94 led.
        /// </summary>
        MotherboardZone94 = 1455,

        /// <summary>
        /// For motherboard zone 95 led.
        /// </summary>
        MotherboardZone95 = 1456,

        /// <summary>
        /// For motherboard zone 96 led.
        /// </summary>
        MotherboardZone96 = 1457,

        /// <summary>
        /// For motherboard zone 97 led.
        /// </summary>
        MotherboardZone97 = 1458,

        /// <summary>
        /// For motherboard zone 98 led.
        /// </summary>
        MotherboardZone98 = 1459,

        /// <summary>
        /// For motherboard zone 99 led.
        /// </summary>
        MotherboardZone99 = 1460,

        /// <summary>
        /// For motherboard zone 100 led.
        /// </summary>
        MotherboardZone100 = 1461,

        /// <summary>
        /// For graphics card zone 1 led.
        /// </summary>
        GraphicsCardZone1 = 1462,

        /// <summary>
        /// For graphics card zone 2 led.
        /// </summary>
        GraphicsCardZone2 = 1463,

        /// <summary>
        /// For graphics card zone 3 led.
        /// </summary>
        GraphicsCardZone3 = 1464,

        /// <summary>
        /// For graphics card zone 4 led.
        /// </summary>
        GraphicsCardZone4 = 1465,

        /// <summary>
        /// For graphics card zone 5 led.
        /// </summary>
        GraphicsCardZone5 = 1466,

        /// <summary>
        /// For graphics card zone 6 led.
        /// </summary>
        GraphicsCardZone6 = 1467,

        /// <summary>
        /// For graphics card zone 7 led.
        /// </summary>
        GraphicsCardZone7 = 1468,

        /// <summary>
        /// For graphics card zone 8 led.
        /// </summary>
        GraphicsCardZone8 = 1469,

        /// <summary>
        /// For graphics card zone 9 led.
        /// </summary>
        GraphicsCardZone9 = 1470,

        /// <summary>
        /// For graphics card zone 10 led.
        /// </summary>
        GraphicsCardZone10 = 1471,

        /// <summary>
        /// For graphics card zone 11 led.
        /// </summary>
        GraphicsCardZone11 = 1472,

        /// <summary>
        /// For graphics card zone 12 led.
        /// </summary>
        GraphicsCardZone12 = 1473,

        /// <summary>
        /// For graphics card zone 13 led.
        /// </summary>
        GraphicsCardZone13 = 1474,

        /// <summary>
        /// For graphics card zone 14 led.
        /// </summary>
        GraphicsCardZone14 = 1475,

        /// <summary>
        /// For graphics card zone 15 led.
        /// </summary>
        GraphicsCardZone15 = 1476,

        /// <summary>
        /// For graphics card zone 16 led.
        /// </summary>
        GraphicsCardZone16 = 1477,

        /// <summary>
        /// For graphics card zone 17 led.
        /// </summary>
        GraphicsCardZone17 = 1478,

        /// <summary>
        /// For graphics card zone 18 led.
        /// </summary>
        GraphicsCardZone18 = 1479,

        /// <summary>
        /// For graphics card zone 19 led.
        /// </summary>
        GraphicsCardZone19 = 1480,

        /// <summary>
        /// For graphics card zone 20 led.
        /// </summary>
        GraphicsCardZone20 = 1481,

        /// <summary>
        /// For graphics card zone 21 led.
        /// </summary>
        GraphicsCardZone21 = 1482,

        /// <summary>
        /// For graphics card zone 22 led.
        /// </summary>
        GraphicsCardZone22 = 1483,

        /// <summary>
        /// For graphics card zone 23 led.
        /// </summary>
        GraphicsCardZone23 = 1484,

        /// <summary>
        /// For graphics card zone 24 led.
        /// </summary>
        GraphicsCardZone24 = 1485,

        /// <summary>
        /// For graphics card zone 25 led.
        /// </summary>
        GraphicsCardZone25 = 1486,

        /// <summary>
        /// For graphics card zone 26 led.
        /// </summary>
        GraphicsCardZone26 = 1487,

        /// <summary>
        /// For graphics card zone 27 led.
        /// </summary>
        GraphicsCardZone27 = 1488,

        /// <summary>
        /// For graphics card zone 28 led.
        /// </summary>
        GraphicsCardZone28 = 1489,

        /// <summary>
        /// For graphics card zone 29 led.
        /// </summary>
        GraphicsCardZone29 = 1490,

        /// <summary>
        /// For graphics card zone 30 led.
        /// </summary>
        GraphicsCardZone30 = 1491,

        /// <summary>
        /// For graphics card zone 31 led.
        /// </summary>
        GraphicsCardZone31 = 1492,

        /// <summary>
        /// For graphics card zone 32 led.
        /// </summary>
        GraphicsCardZone32 = 1493,

        /// <summary>
        /// For graphics card zone 33 led.
        /// </summary>
        GraphicsCardZone33 = 1494,

        /// <summary>
        /// For graphics card zone 34 led.
        /// </summary>
        GraphicsCardZone34 = 1495,

        /// <summary>
        /// For graphics card zone 35 led.
        /// </summary>
        GraphicsCardZone35 = 1496,

        /// <summary>
        /// For graphics card zone 36 led.
        /// </summary>
        GraphicsCardZone36 = 1497,

        /// <summary>
        /// For graphics card zone 37 led.
        /// </summary>
        GraphicsCardZone37 = 1498,

        /// <summary>
        /// For graphics card zone 38 led.
        /// </summary>
        GraphicsCardZone38 = 1499,

        /// <summary>
        /// For graphics card zone 39 led.
        /// </summary>
        GraphicsCardZone39 = 1500,

        /// <summary>
        /// For graphics card zone 40 led.
        /// </summary>
        GraphicsCardZone40 = 1501,

        /// <summary>
        /// For graphics card zone 41 led.
        /// </summary>
        GraphicsCardZone41 = 1502,

        /// <summary>
        /// For graphics card zone 42 led.
        /// </summary>
        GraphicsCardZone42 = 1503,

        /// <summary>
        /// For graphics card zone 43 led.
        /// </summary>
        GraphicsCardZone43 = 1504,

        /// <summary>
        /// For graphics card zone 44 led.
        /// </summary>
        GraphicsCardZone44 = 1505,

        /// <summary>
        /// For graphics card zone 45 led.
        /// </summary>
        GraphicsCardZone45 = 1506,

        /// <summary>
        /// For graphics card zone 46 led.
        /// </summary>
        GraphicsCardZone46 = 1507,

        /// <summary>
        /// For graphics card zone 47 led.
        /// </summary>
        GraphicsCardZone47 = 1508,

        /// <summary>
        /// For graphics card zone 48 led.
        /// </summary>
        GraphicsCardZone48 = 1509,

        /// <summary>
        /// For graphics card zone 49 led.
        /// </summary>
        GraphicsCardZone49 = 1510,

        /// <summary>
        /// For graphics card zone 50 led.
        /// </summary>
        GraphicsCardZone50 = 1511,

        /// <summary>
        /// For keyboard light pipe zone 20 led.
        /// </summary>
        KeyboardLightPipeZone20 = 1512,

        /// <summary>
        /// For keyboard light pipe zone 21 led.
        /// </summary>
        KeyboardLightPipeZone21 = 1513,

        /// <summary>
        /// For keyboard light pipe zone 22 led.
        /// </summary>
        KeyboardLightPipeZone22 = 1514,

        /// <summary>
        /// For keyboard light pipe zone 23 led.
        /// </summary>
        KeyboardLightPipeZone23 = 1515,

        /// <summary>
        /// For keyboard light pipe zone 24 led.
        /// </summary>
        KeyboardLightPipeZone24 = 1516,

        /// <summary>
        /// For keyboard light pipe zone 25 led.
        /// </summary>
        KeyboardLightPipeZone25 = 1517,

        /// <summary>
        /// For keyboard light pipe zone 26 led.
        /// </summary>
        KeyboardLightPipeZone26 = 1518,

        /// <summary>
        /// For keyboard light pipe zone 27 led.
        /// </summary>
        KeyboardLightPipeZone27 = 1519,

        /// <summary>
        /// For keyboard light pipe zone 28 led.
        /// </summary>
        KeyboardLightPipeZone28 = 1520,

        /// <summary>
        /// For keyboard light pipe zone 29 led.
        /// </summary>
        KeyboardLightPipeZone29 = 1521,

        /// <summary>
        /// For keyboard light pipe zone 30 led.
        /// </summary>
        KeyboardLightPipeZone30 = 1522,

        /// <summary>
        /// For keyboard light pipe zone 31 led.
        /// </summary>
        KeyboardLightPipeZone31 = 1523,

        /// <summary>
        /// For keyboard light pipe zone 32 led.
        /// </summary>
        KeyboardLightPipeZone32 = 1524,

        /// <summary>
        /// For keyboard light pipe zone 33 led.
        /// </summary>
        KeyboardLightPipeZone33 = 1525,

        /// <summary>
        /// For keyboard light pipe zone 34 led.
        /// </summary>
        KeyboardLightPipeZone34 = 1526,

        /// <summary>
        /// For keyboard light pipe zone 35 led.
        /// </summary>
        KeyboardLightPipeZone35 = 1527,

        /// <summary>
        /// For keyboard light pipe zone 36 led.
        /// </summary>
        KeyboardLightPipeZone36 = 1528,

        /// <summary>
        /// For keyboard light pipe zone 37 led.
        /// </summary>
        KeyboardLightPipeZone37 = 1529,

        /// <summary>
        /// For keyboard light pipe zone 38 led.
        /// </summary>
        KeyboardLightPipeZone38 = 1530,

        /// <summary>
        /// For keyboard light pipe zone 39 led.
        /// </summary>
        KeyboardLightPipeZone39 = 1531,

        /// <summary>
        /// For keyboard light pipe zone 40 led.
        /// </summary>
        KeyboardLightPipeZone40 = 1532,

        /// <summary>
        /// For keyboard light pipe zone 41 led.
        /// </summary>
        KeyboardLightPipeZone41 = 1533,

        /// <summary>
        /// For keyboard light pipe zone 42 led.
        /// </summary>
        KeyboardLightPipeZone42 = 1534,

        /// <summary>
        /// For keyboard light pipe zone 43 led.
        /// </summary>
        KeyboardLightPipeZone43 = 1535,

        /// <summary>
        /// For keyboard light pipe zone 44 led.
        /// </summary>
        KeyboardLightPipeZone44 = 1536,

        /// <summary>
        /// For keyboard light pipe zone 45 led.
        /// </summary>
        KeyboardLightPipeZone45 = 1537,

        /// <summary>
        /// For keyboard light pipe zone 46 led.
        /// </summary>
        KeyboardLightPipeZone46 = 1538,

        /// <summary>
        /// For keyboard light pipe zone 47 led.
        /// </summary>
        KeyboardLightPipeZone47 = 1539,

        /// <summary>
        /// For keyboard light pipe zone 48 led.
        /// </summary>
        KeyboardLightPipeZone48 = 1540,

        /// <summary>
        /// For keyboard light pipe zone 49 led.
        /// </summary>
        KeyboardLightPipeZone49 = 1541,

        /// <summary>
        /// For keyboard light pipe zone 50 led.
        /// </summary>
        KeyboardLightPipeZone50 = 1542,

        /// <summary>
        /// For keyboard profile led.
        /// </summary>
        KeyboardProfile = 1543,

        /// <summary>
        /// Reserved for custom led 101.
        /// </summary>
        CustomOem101 = 1544,

        /// <summary>
        /// Reserved for custom led 102.
        /// </summary>
        CustomOem102 = 1545,

        /// <summary>
        /// Reserved for custom led 103.
        /// </summary>
        CustomOem103 = 1546,

        /// <summary>
        /// Reserved for custom led 104.
        /// </summary>
        CustomOem104 = 1547,

        /// <summary>
        /// Reserved for custom led 105.
        /// </summary>
        CustomOem105 = 1548,

        /// <summary>
        /// Reserved for custom led 106.
        /// </summary>
        CustomOem106 = 1549,

        /// <summary>
        /// Reserved for custom led 107.
        /// </summary>
        CustomOem107 = 1550,

        /// <summary>
        /// Reserved for custom led 108.
        /// </summary>
        CustomOem108 = 1551,

        /// <summary>
        /// Reserved for custom led 109.
        /// </summary>
        CustomOem109 = 1552,

        /// <summary>
        /// Reserved for custom led 110.
        /// </summary>
        CustomOem110 = 1553,

        /// <summary>
        /// Reserved for custom led 111.
        /// </summary>
        CustomOem111 = 1554,

        /// <summary>
        /// Reserved for custom led 112.
        /// </summary>
        CustomOem112 = 1555,

        /// <summary>
        /// Reserved for custom led 113.
        /// </summary>
        CustomOem113 = 1556,

        /// <summary>
        /// Reserved for custom led 114.
        /// </summary>
        CustomOem114 = 1557,

        /// <summary>
        /// Reserved for custom led 115.
        /// </summary>
        CustomOem115 = 1558,

        /// <summary>
        /// Reserved for custom led 116.
        /// </summary>
        CustomOem116 = 1559,

        /// <summary>
        /// Reserved for custom led 117.
        /// </summary>
        CustomOem117 = 1560,

        /// <summary>
        /// Reserved for custom led 118.
        /// </summary>
        CustomOem118 = 1561,

        /// <summary>
        /// Reserved for custom led 119.
        /// </summary>
        CustomOem119 = 1562,

        /// <summary>
        /// Reserved for custom led 120.
        /// </summary>
        CustomOem120 = 1563,

        /// <summary>
        /// Reserved for custom led 121.
        /// </summary>
        CustomOem121 = 1564,

        /// <summary>
        /// Reserved for custom led 122.
        /// </summary>
        CustomOem122 = 1565,

        /// <summary>
        /// Reserved for custom led 123.
        /// </summary>
        CustomOem123 = 1566,

        /// <summary>
        /// Reserved for custom led 124.
        /// </summary>
        CustomOem124 = 1567,

        /// <summary>
        /// Reserved for custom led 125.
        /// </summary>
        CustomOem125 = 1568,

        /// <summary>
        /// Reserved for custom led 126.
        /// </summary>
        CustomOem126 = 1569,

        /// <summary>
        /// Reserved for custom led 127.
        /// </summary>
        CustomOem127 = 1570,

        /// <summary>
        /// Reserved for custom led 128.
        /// </summary>
        CustomOem128 = 1571,

        /// <summary>
        /// Reserved for custom led 129.
        /// </summary>
        CustomOem129 = 1572,

        /// <summary>
        /// Reserved for custom led 130.
        /// </summary>
        CustomOem130 = 1573,

        /// <summary>
        /// Reserved for custom led 131.
        /// </summary>
        CustomOem131 = 1574,

        /// <summary>
        /// Reserved for custom led 132.
        /// </summary>
        CustomOem132 = 1575,

        /// <summary>
        /// Reserved for custom led 133.
        /// </summary>
        CustomOem133 = 1576,

        /// <summary>
        /// Reserved for custom led 134.
        /// </summary>
        CustomOem134 = 1577,

        /// <summary>
        /// Reserved for custom led 135.
        /// </summary>
        CustomOem135 = 1578,

        /// <summary>
        /// Reserved for custom led 136.
        /// </summary>
        CustomOem136 = 1579,

        /// <summary>
        /// Reserved for custom led 137.
        /// </summary>
        CustomOem137 = 1580,

        /// <summary>
        /// Reserved for custom led 138.
        /// </summary>
        CustomOem138 = 1581,

        /// <summary>
        /// Reserved for custom led 139.
        /// </summary>
        CustomOem139 = 1582,

        /// <summary>
        /// Reserved for custom led 140.
        /// </summary>
        CustomOem140 = 1583,

        /// <summary>
        /// Reserved for custom led 141.
        /// </summary>
        CustomOem141 = 1584,

        /// <summary>
        /// Reserved for custom led 142.
        /// </summary>
        CustomOem142 = 1585,

        /// <summary>
        /// Reserved for custom led 143.
        /// </summary>
        CustomOem143 = 1586,

        /// <summary>
        /// Reserved for custom led 144.
        /// </summary>
        CustomOem144 = 1587,

        /// <summary>
        /// Reserved for custom led 145.
        /// </summary>
        CustomOem145 = 1588,

        /// <summary>
        /// Reserved for custom led 146.
        /// </summary>
        CustomOem146 = 1589,

        /// <summary>
        /// Reserved for custom led 147.
        /// </summary>
        CustomOem147 = 1590,

        /// <summary>
        /// Reserved for custom led 148.
        /// </summary>
        CustomOem148 = 1591,

        /// <summary>
        /// Reserved for custom led 149.
        /// </summary>
        CustomOem149 = 1592,

        /// <summary>
        /// Reserved for custom led 150.
        /// </summary>
        CustomOem150 = 1593,

        /// <summary>
        /// Reserved for custom led 151.
        /// </summary>
        CustomOem151 = 1594,

        /// <summary>
        /// Reserved for custom led 152.
        /// </summary>
        CustomOem152 = 1595,

        /// <summary>
        /// Reserved for custom led 153.
        /// </summary>
        CustomOem153 = 1596,

        /// <summary>
        /// Reserved for custom led 154.
        /// </summary>
        CustomOem154 = 1597,

        /// <summary>
        /// Reserved for custom led 155.
        /// </summary>
        CustomOem155 = 1598,

        /// <summary>
        /// Reserved for custom led 156.
        /// </summary>
        CustomOem156 = 1599,

        /// <summary>
        /// Reserved for custom led 157.
        /// </summary>
        CustomOem157 = 1600,

        /// <summary>
        /// Reserved for custom led 158.
        /// </summary>
        CustomOem158 = 1601,

        /// <summary>
        /// Reserved for custom led 159.
        /// </summary>
        CustomOem159 = 1602,

        /// <summary>
        /// Reserved for custom led 160.
        /// </summary>
        CustomOem160 = 1603,

        /// <summary>
        /// Reserved for custom led 161.
        /// </summary>
        CustomOem161 = 1604,

        /// <summary>
        /// Reserved for custom led 162.
        /// </summary>
        CustomOem162 = 1605,

        /// <summary>
        /// Reserved for custom led 163.
        /// </summary>
        CustomOem163 = 1606,

        /// <summary>
        /// Reserved for custom led 164.
        /// </summary>
        CustomOem164 = 1607,

        /// <summary>
        /// Reserved for custom led 165.
        /// </summary>
        CustomOem165 = 1608,

        /// <summary>
        /// Reserved for custom led 166.
        /// </summary>
        CustomOem166 = 1609,

        /// <summary>
        /// Reserved for custom led 167.
        /// </summary>
        CustomOem167 = 1610,

        /// <summary>
        /// Reserved for custom led 168.
        /// </summary>
        CustomOem168 = 1611,

        /// <summary>
        /// Reserved for custom led 169.
        /// </summary>
        CustomOem169 = 1612,

        /// <summary>
        /// Reserved for custom led 170.
        /// </summary>
        CustomOem170 = 1613,

        /// <summary>
        /// Reserved for custom led 171.
        /// </summary>
        CustomOem171 = 1614,

        /// <summary>
        /// Reserved for custom led 172.
        /// </summary>
        CustomOem172 = 1615,

        /// <summary>
        /// Reserved for custom led 173.
        /// </summary>
        CustomOem173 = 1616,

        /// <summary>
        /// Reserved for custom led 174.
        /// </summary>
        CustomOem174 = 1617,

        /// <summary>
        /// Reserved for custom led 175.
        /// </summary>
        CustomOem175 = 1618,

        /// <summary>
        /// Reserved for custom led 176.
        /// </summary>
        CustomOem176 = 1619,

        /// <summary>
        /// Reserved for custom led 177.
        /// </summary>
        CustomOem177 = 1620,

        /// <summary>
        /// Reserved for custom led 178.
        /// </summary>
        CustomOem178 = 1621,

        /// <summary>
        /// Reserved for custom led 179.
        /// </summary>
        CustomOem179 = 1622,

        /// <summary>
        /// Reserved for custom led 180.
        /// </summary>
        CustomOem180 = 1623,

        /// <summary>
        /// Reserved for custom led 181.
        /// </summary>
        CustomOem181 = 1624,

        /// <summary>
        /// Reserved for custom led 182.
        /// </summary>
        CustomOem182 = 1625,

        /// <summary>
        /// Reserved for custom led 183.
        /// </summary>
        CustomOem183 = 1626,

        /// <summary>
        /// Reserved for custom led 184.
        /// </summary>
        CustomOem184 = 1627,

        /// <summary>
        /// Reserved for custom led 185.
        /// </summary>
        CustomOem185 = 1628,

        /// <summary>
        /// Reserved for custom led 186.
        /// </summary>
        CustomOem186 = 1629,

        /// <summary>
        /// Reserved for custom led 187.
        /// </summary>
        CustomOem187 = 1630,

        /// <summary>
        /// Reserved for custom led 188.
        /// </summary>
        CustomOem188 = 1631,

        /// <summary>
        /// Reserved for custom led 189.
        /// </summary>
        CustomOem189 = 1632,

        /// <summary>
        /// Reserved for custom led 190.
        /// </summary>
        CustomOem190 = 1633,

        /// <summary>
        /// Reserved for custom led 191.
        /// </summary>
        CustomOem191 = 1634,

        /// <summary>
        /// Reserved for custom led 192.
        /// </summary>
        CustomOem192 = 1635,

        /// <summary>
        /// Reserved for custom led 193.
        /// </summary>
        CustomOem193 = 1636,

        /// <summary>
        /// Reserved for custom led 194.
        /// </summary>
        CustomOem194 = 1637,

        /// <summary>
        /// Reserved for custom led 195.
        /// </summary>
        CustomOem195 = 1638,

        /// <summary>
        /// Reserved for custom led 196.
        /// </summary>
        CustomOem196 = 1639,

        /// <summary>
        /// Reserved for custom led 197.
        /// </summary>
        CustomOem197 = 1640,

        /// <summary>
        /// Reserved for custom led 198.
        /// </summary>
        CustomOem198 = 1641,

        /// <summary>
        /// Reserved for custom led 199.
        /// </summary>
        CustomOem199 = 1642,

        /// <summary>
        /// Reserved for custom led 200.
        /// </summary>
        CustomOem200 = 1643,

        /// <summary>
        /// Reserved for custom led 201.
        /// </summary>
        CustomOem201 = 1644,

        /// <summary>
        /// Reserved for custom led 202.
        /// </summary>
        CustomOem202 = 1645,

        /// <summary>
        /// Reserved for custom led 203.
        /// </summary>
        CustomOem203 = 1646,

        /// <summary>
        /// Reserved for custom led 204.
        /// </summary>
        CustomOem204 = 1647,

        /// <summary>
        /// Reserved for custom led 205.
        /// </summary>
        CustomOem205 = 1648,

        /// <summary>
        /// Reserved for custom led 206.
        /// </summary>
        CustomOem206 = 1649,

        /// <summary>
        /// Reserved for custom led 207.
        /// </summary>
        CustomOem207 = 1650,

        /// <summary>
        /// Reserved for custom led 208.
        /// </summary>
        CustomOem208 = 1651,

        /// <summary>
        /// Reserved for custom led 209.
        /// </summary>
        CustomOem209 = 1652,

        /// <summary>
        /// Reserved for custom led 210.
        /// </summary>
        CustomOem210 = 1653,

        /// <summary>
        /// Reserved for custom led 211.
        /// </summary>
        CustomOem211 = 1654,

        /// <summary>
        /// Reserved for custom led 212.
        /// </summary>
        CustomOem212 = 1655,

        /// <summary>
        /// Reserved for custom led 213.
        /// </summary>
        CustomOem213 = 1656,

        /// <summary>
        /// Reserved for custom led 214.
        /// </summary>
        CustomOem214 = 1657,

        /// <summary>
        /// Reserved for custom led 215.
        /// </summary>
        CustomOem215 = 1658,

        /// <summary>
        /// Reserved for custom led 216.
        /// </summary>
        CustomOem216 = 1659,

        /// <summary>
        /// Reserved for custom led 217.
        /// </summary>
        CustomOem217 = 1660,

        /// <summary>
        /// Reserved for custom led 218.
        /// </summary>
        CustomOem218 = 1661,

        /// <summary>
        /// Reserved for custom led 219.
        /// </summary>
        CustomOem219 = 1662,

        /// <summary>
        /// Reserved for custom led 220.
        /// </summary>
        CustomOem220 = 1663,

        /// <summary>
        /// Reserved for custom led 221.
        /// </summary>
        CustomOem221 = 1664,

        /// <summary>
        /// Reserved for custom led 222.
        /// </summary>
        CustomOem222 = 1665,

        /// <summary>
        /// Reserved for custom led 223.
        /// </summary>
        CustomOem223 = 1666,

        /// <summary>
        /// Reserved for custom led 224.
        /// </summary>
        CustomOem224 = 1667,

        /// <summary>
        /// Reserved for custom led 225.
        /// </summary>
        CustomOem225 = 1668,

        /// <summary>
        /// Reserved for custom led 226.
        /// </summary>
        CustomOem226 = 1669,

        /// <summary>
        /// Reserved for custom led 227.
        /// </summary>
        CustomOem227 = 1670,

        /// <summary>
        /// Reserved for custom led 228.
        /// </summary>
        CustomOem228 = 1671,

        /// <summary>
        /// Reserved for custom led 229.
        /// </summary>
        CustomOem229 = 1672,

        /// <summary>
        /// Reserved for custom led 230.
        /// </summary>
        CustomOem230 = 1673,

        /// <summary>
        /// Reserved for custom led 231.
        /// </summary>
        CustomOem231 = 1674,

        /// <summary>
        /// Reserved for custom led 232.
        /// </summary>
        CustomOem232 = 1675,

        /// <summary>
        /// Reserved for custom led 233.
        /// </summary>
        CustomOem233 = 1676,

        /// <summary>
        /// Reserved for custom led 234.
        /// </summary>
        CustomOem234 = 1677,

        /// <summary>
        /// Reserved for custom led 235.
        /// </summary>
        CustomOem235 = 1678,

        /// <summary>
        /// Reserved for custom led 236.
        /// </summary>
        CustomOem236 = 1679,

        /// <summary>
        /// Reserved for custom led 237.
        /// </summary>
        CustomOem237 = 1680,

        /// <summary>
        /// Reserved for custom led 238.
        /// </summary>
        CustomOem238 = 1681,

        /// <summary>
        /// Reserved for custom led 239.
        /// </summary>
        CustomOem239 = 1682,

        /// <summary>
        /// Reserved for custom led 240.
        /// </summary>
        CustomOem240 = 1683,

        /// <summary>
        /// Reserved for custom led 241.
        /// </summary>
        CustomOem241 = 1684,

        /// <summary>
        /// Reserved for custom led 242.
        /// </summary>
        CustomOem242 = 1685,

        /// <summary>
        /// Reserved for custom led 243.
        /// </summary>
        CustomOem243 = 1686,

        /// <summary>
        /// Reserved for custom led 244.
        /// </summary>
        CustomOem244 = 1687,

        /// <summary>
        /// Reserved for custom led 245.
        /// </summary>
        CustomOem245 = 1688,

        /// <summary>
        /// Reserved for custom led 246.
        /// </summary>
        CustomOem246 = 1689,

        /// <summary>
        /// Reserved for custom led 247.
        /// </summary>
        CustomOem247 = 1690,

        /// <summary>
        /// Reserved for custom led 248.
        /// </summary>
        CustomOem248 = 1691,

        /// <summary>
        /// Reserved for custom led 249.
        /// </summary>
        CustomOem249 = 1692,

        /// <summary>
        /// Reserved for custom led 250.
        /// </summary>
        CustomOem250 = 1693,

        /// <summary>
        /// For mouse 7 led.
        /// </summary>
        Mouse7 = 1694,

        /// <summary>
        /// For mouse 8 led.
        /// </summary>
        Mouse8 = 1695,

        /// <summary>
        /// For mouse 9 led.
        /// </summary>
        Mouse9 = 1696,

        /// <summary>
        /// For mouse 10 led.
        /// </summary>
        Mouse10 = 1697,

        /// <summary>
        /// For mouse 11 led.
        /// </summary>
        Mouse11 = 1698,

        /// <summary>
        /// For mouse 12 led.
        /// </summary>
        Mouse12 = 1699,

        /// <summary>
        /// For mouse 13 led.
        /// </summary>
        Mouse13 = 1700,

        /// <summary>
        /// For mouse 14 led.
        /// </summary>
        Mouse14 = 1701,

        /// <summary>
        /// For mouse 15 led.
        /// </summary>
        Mouse15 = 1702,

        /// <summary>
        /// For mouse 16 led.
        /// </summary>
        Mouse16 = 1703,

        /// <summary>
        /// For mouse 17 led.
        /// </summary>
        Mouse17 = 1704,

        /// <summary>
        /// For mouse 18 led.
        /// </summary>
        Mouse18 = 1705,

        /// <summary>
        /// For mouse 19 led.
        /// </summary>
        Mouse19 = 1706,

        /// <summary>
        /// For mouse 20 led.
        /// </summary>
        Mouse20 = 1707,

        /// <summary>
        /// The last available led.
        /// </summary>
        Last = Mouse20
    }
}
