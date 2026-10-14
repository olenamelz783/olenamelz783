using UnityEngine;

// The two numbers that outlive a session. Keys are literal strings that never reach
// the screen, so the obfuscator leaves them alone and saved progress survives updates.
public static class _0xf3b0ae9c
{
    // The first two orbits are always open so a fresh install can pick either one;
    // the hardest one asks for three cleared routes first.
    public static bool IsUnlocked(int _0x5e9acbf7)
    {
        if (_0x5e9acbf7 <= 1)
            return true;
        return _0x0e1da376 >= 3;
    }

    private static readonly string ClearedKey = _0xe2911679._0x4a259ccf(new byte[18] { 231, 250, 234, 225, 252, 166, 234, 237, 251, 252, 166, 235, 228, 237, 233, 250, 237, 236 }, 136);
    private static readonly string MissionKey = _0xe2911679._0x4a259ccf(new byte[13] { 182, 171, 187, 176, 173, 247, 180, 176, 170, 170, 176, 182, 183 }, 217);
    public static void RecordRun(int _0xe24773de, int _0x6b4e3843)
    {
        if (_0xe24773de > _0x5564f4ac)
            _0x5564f4ac = _0xe24773de;
        if (_0x6b4e3843 > _0x0e1da376)
            _0x0e1da376 = _0x6b4e3843;
        PlayerPrefs.Save();
    }

    private static readonly string StreakKey = _0xe2911679._0x4a259ccf(new byte[17] { 115, 110, 126, 117, 104, 50, 126, 121, 111, 104, 50, 111, 104, 110, 121, 125, 119 }, 28);
    public static int _0x0e1da376
    {
        get
        {
            return Mathf.Max(0, PlayerPrefs.GetInt(ClearedKey, 0));
        }

        set
        {
            PlayerPrefs.SetInt(ClearedKey, Mathf.Max(0, value));
        }
    }

    public static int _0x577c14bf
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(MissionKey, 0), 0, _0x9a1309ef._0x79d002e7 - 1);
        }

        set
        {
            PlayerPrefs.SetInt(MissionKey, Mathf.Clamp(value, 0, _0x9a1309ef._0x79d002e7 - 1));
        }
    }

    public static int _0x5564f4ac
    {
        get
        {
            return Mathf.Max(0, PlayerPrefs.GetInt(StreakKey, 0));
        }

        set
        {
            PlayerPrefs.SetInt(StreakKey, Mathf.Max(0, value));
        }
    }
}

internal static class _0xe2911679
{
    internal static string _0x4a259ccf(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}