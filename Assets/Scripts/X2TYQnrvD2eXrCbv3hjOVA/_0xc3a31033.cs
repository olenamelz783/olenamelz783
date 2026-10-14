using UnityEngine;

// Palette of the beacon-route game. Every entry is a literal; no static field here
// reads another one, so the obfuscator may reorder the declarations freely (C.52).
public static class _0xc3a31033
{
    public static readonly Color Surface = new Color(0.1059f, 0.1373f, 0.3137f, 1f);
    public static readonly Color VoidDeep = new Color(0.0392f, 0.0471f, 0.1098f, 1f);
    public static readonly Color Rose = new Color(0.9255f, 0.3569f, 0.4784f, 1f);
    public static readonly Color Card = new Color(0.0784f, 0.1059f, 0.2275f, 1f);
    public static readonly Color Gold = new Color(0.9608f, 0.8235f, 0.3020f, 1f);
    public static readonly Color Beacon = new Color(0.2235f, 0.7843f, 0.8353f, 1f);
    public static readonly Color Void = new Color(0.0667f, 0.0784f, 0.1725f, 1f);
    public static readonly Color Cobalt = new Color(0.2039f, 0.3059f, 0.8157f, 1f);
    public static readonly Color Muted = new Color(0.5569f, 0.5922f, 0.7882f, 1f);
    public static readonly Color Cream = new Color(0.9686f, 0.9569f, 0.9216f, 1f);
    public static Color WithAlpha(Color _0x0fede3b0, float _0xbbf2c091)
    {
        return new Color(_0x0fede3b0.r, _0x0fede3b0.g, _0x0fede3b0.b, _0xbbf2c091);
    }
}