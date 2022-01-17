using System.Collections.Generic;

namespace Chip8_CP
{
    public class Constants
    {
        public class Keyword
        {
            public enum KeyType
            {
                KEY_0,
                KEY_1,
                KEY_2,
                KEY_3,
                KEY_4,
                KEY_5,
                KEY_6,
                KEY_7,
                KEY_8,
                KEY_9,
                KEY_A,
                KEY_B,
                KEY_C,
                KEY_D,
                KEY_E,
                KEY_F
            }

            public static Dictionary<KeyType, int> Keys { get; } = new Dictionary<KeyType, int>() {
                { KeyType.KEY_0, 0x0 },
                { KeyType.KEY_1, 0x1 },
                { KeyType.KEY_2, 0x2 },
                { KeyType.KEY_3, 0x3 },
                { KeyType.KEY_4, 0x4 },
                { KeyType.KEY_5, 0x5 },
                { KeyType.KEY_6, 0x6 },
                { KeyType.KEY_7, 0x7 },
                { KeyType.KEY_8, 0x8 },
                { KeyType.KEY_9, 0x9 },
                { KeyType.KEY_A, 0xA },
                { KeyType.KEY_B, 0xB },
                { KeyType.KEY_C, 0xC },
                { KeyType.KEY_D, 0xD },
                { KeyType.KEY_E, 0xE },
                { KeyType.KEY_F, 0xF }
            };
        }
    }
}
