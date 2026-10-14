using UnityEngine;

// One selectable orbit. The table is literal data: no entry reads another static
// field, so declaration order after obfuscation cannot matter (C.52).
public sealed class _0x9a1309ef
{
    public static int _0x79d002e7
    {
        get
        {
            return _0xead7c3da.Length;
        }
    }

    public readonly string Title;
    public readonly int FirstLength;
    private static readonly _0x9a1309ef[] _0xead7c3da =
    {
        new _0x9a1309ef(_0xbe856f45._0x0c7d3291(new byte[7] { 224, 253, 237, 230, 251, 143, 230 }, 175), 5, 3, 5, 0, 1, 32f, 1),
        new _0x9a1309ef(_0xbe856f45._0x0c7d3291(new byte[8] { 40, 53, 37, 46, 51, 71, 46, 46 }, 103), 5, 4, 6, 1, 2, 28f, 2),
        new _0x9a1309ef(_0xbe856f45._0x0c7d3291(new byte[9] { 133, 152, 136, 131, 158, 234, 131, 131, 131 }, 202), 5, 5, 7, 2, 3, 25f, 3),
    };
    public int _0xd7b8cc18(int _0x4fe1a66c)
    {
        if (this.Routes <= 1)
            return this.FirstDecoys;
        float _0xaeaa966d = Mathf.Clamp01((float)_0x4fe1a66c / (this.Routes - 1));
        return Mathf.Max(0, Mathf.RoundToInt(Mathf.Lerp(this.FirstDecoys, this.LastDecoys, _0xaeaa966d)));
    }

    // Route n of this mission: length and decoy count ramp from first to last.
    public int _0x422d12d5(int _0x68d831bc)
    {
        if (this.Routes <= 1)
            return this.FirstLength;
        float _0xc8d06c08 = Mathf.Clamp01((float)_0x68d831bc / (this.Routes - 1));
        return Mathf.Clamp(Mathf.RoundToInt(Mathf.Lerp(this.FirstLength, this.LastLength, _0xc8d06c08)), 2, 7);
    }

    public readonly int Routes;
    public readonly int LastLength;
    public string _0xd836d311()
    {
        return this.Routes + _0xbe856f45._0x0c7d3291(new byte[9] { 6, 116, 105, 115, 114, 99, 117, 6, 6 }, 38) + this.FirstLength + _0xbe856f45._0x0c7d3291(new byte[1] { 215 }, 250) + this.LastLength + _0xbe856f45._0x0c7d3291(new byte[8] { 179, 223, 218, 221, 216, 192, 179, 179 }, 147) + Mathf.RoundToInt(this.WindowSeconds) + _0xbe856f45._0x0c7d3291(new byte[1] { 150 }, 197);
    }

    public readonly int FirstDecoys;
    public readonly int Difficulty;
    public readonly int LastDecoys;
    public readonly float WindowSeconds;
    public static _0x9a1309ef Row(int _0x5fb643ae)
    {
        return _0xead7c3da[Mathf.Clamp(_0x5fb643ae, 0, _0xead7c3da.Length - 1)];
    }

    public _0x9a1309ef(string _0x99891a9e, int _0x2a16a626, int _0x9284d5f3, int _0x95b63cdb, int _0x5ec9668f, int _0xc9e6de9c, float _0x1437a2bd, int _0x4f969e40)
    {
        this.Title = _0x99891a9e;
        this.Routes = _0x2a16a626;
        this.FirstLength = _0x9284d5f3;
        this.LastLength = _0x95b63cdb;
        this.FirstDecoys = _0x5ec9668f;
        this.LastDecoys = _0xc9e6de9c;
        this.WindowSeconds = _0x1437a2bd;
        this.Difficulty = _0x4f969e40;
    }
}

internal static class _0xbe856f45
{
    internal static string _0x0c7d3291(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}