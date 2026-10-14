using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xddcc2409
{
    public class _0x459e7976
    {
        private static readonly _0x459e7976 _0x16f41b77 = new();
        public static readonly _0x459e7976[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x16f41b77,
            _0x16f41b77,
            _0x16f41b77,
        };
        private int _0xf07fa010 => 0;
        private int _0x117830ac => 10;
        private string _0x8c9ea87c => _0x8034d49b._0xd8e2de42(new byte[4] { 105, 65, 74, 81 }, 36);
        private string _0xaab1bd30 => _0x8034d49b._0xd8e2de42(new byte[8] { 138, 131, 144, 131, 138, 189, 246, 187 }, 198);

        private int _0x3ed975ca
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x8034d49b._0xd8e2de42(new byte[25] { 16, 38, 33, 33, 54, 61, 39, 20, 63, 60, 49, 50, 63, 16, 59, 50, 35, 39, 54, 33, 26, 61, 55, 54, 43 }, 83)))
                    PlayerPrefs.SetInt(_0x8034d49b._0xd8e2de42(new byte[25] { 17, 39, 32, 32, 55, 60, 38, 21, 62, 61, 48, 51, 62, 17, 58, 51, 34, 38, 55, 32, 27, 60, 54, 55, 42 }, 82), 0);
                return PlayerPrefs.GetInt(_0x8034d49b._0xd8e2de42(new byte[25] { 166, 144, 151, 151, 128, 139, 145, 162, 137, 138, 135, 132, 137, 166, 141, 132, 149, 145, 128, 151, 172, 139, 129, 128, 157 }, 229));
            }

            set => PlayerPrefs.SetInt(_0x8034d49b._0xd8e2de42(new byte[25] { 172, 154, 157, 157, 138, 129, 155, 168, 131, 128, 141, 142, 131, 172, 135, 142, 159, 155, 138, 157, 166, 129, 139, 138, 151 }, 239), value);
        }

        public int _0x6b7258e4
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x8c9ea87c}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x8c9ea87c}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x8c9ea87c}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x8c9ea87c}CurrentLevelIndex", value);
        }

        public int _0x9083f820
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x8c9ea87c}BestScore"))
                    this._0x9083f820 = 0;
                return PlayerPrefs.GetInt($"{this._0x8c9ea87c}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x8c9ea87c}BestScore", value);
        }

        public bool _0x24d9f9fc
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x8c9ea87c}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x8c9ea87c}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x8c9ea87c}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x8c9ea87c}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x899f8e60
    {
        public static int _0xa9265fb2
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x8034d49b._0xd8e2de42(new byte[5] { 220, 240, 246, 241, 236 }, 159)))
                    PlayerPrefs.SetInt(_0x8034d49b._0xd8e2de42(new byte[5] { 191, 147, 149, 146, 143 }, 252), 0);
                return PlayerPrefs.GetInt(_0x8034d49b._0xd8e2de42(new byte[5] { 195, 239, 233, 238, 243 }, 128));
            }

            set
            {
                PlayerPrefs.SetInt(_0x8034d49b._0xd8e2de42(new byte[5] { 249, 213, 211, 212, 201 }, 186), value);
                _0xf7ac444f.Instance._0x843628c2();
            }
        }
    }

    public static class _0x9dbe1dc7
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x09c5101a
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0xe09069ce
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }
}

internal static class _0x8034d49b
{
    internal static string _0xd8e2de42(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}