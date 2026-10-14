using TMPro;
using UnityEngine;

// C.10: labels built in code never reach stage 5c3 (it only reads scenes and prefabs),
// so the outline that keeps them readable has to be applied here, per label.
// Reading fontMaterial creates an INSTANCE, so the shared font asset stays untouched.
public static class _0x30f3add0
{
    public static void ApplyOutline(TMP_Text _0xfd2c0e5c)
    {
        if (_0xfd2c0e5c == null)
            return;
        Material _0x6ba5c938 = _0xfd2c0e5c.fontMaterial;
        if (_0x6ba5c938 == null)
            return;
        Color _0x9d039470 = _0xfd2c0e5c.color;
        float _0xd61b759e = 0.299f * _0x9d039470.r + 0.587f * _0x9d039470.g + 0.114f * _0x9d039470.b;
        Color _0x039c9657 = _0xd61b759e < 0.5f ? _0xc3a31033.Cream : _0xc3a31033.VoidDeep;
        _0x6ba5c938.EnableKeyword(_0xc2a0b424._0x1ae91d46(new byte[10] { 174, 180, 181, 173, 168, 175, 164, 190, 174, 175 }, 225));
        _0x6ba5c938.SetColor(ShaderUtilities.ID_OutlineColor, _0x039c9657);
        _0x6ba5c938.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.18f);
        _0x6ba5c938.SetFloat(ShaderUtilities.ID_FaceDilate, 0.16f);
    }
}

internal static class _0xc2a0b424
{
    internal static string _0x1ae91d46(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}