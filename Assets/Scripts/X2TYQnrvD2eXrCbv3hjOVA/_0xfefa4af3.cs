using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0xfefa4af3 : MonoBehaviour
{
    private void OnEnable()
    {
        if (this._0x4325fc7c == null)
            this._0x4325fc7c = _0x1c7453db => this._0xc6f3a09c(_0x1c7453db);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x4325fc7c);
    }

    private static void Fix(TMP_Text _0x9d774630)
    {
        if (_0x9d774630 == null || !_0x9d774630.isActiveAndEnabled)
            return;
        Material _0x10ef04d3 = _0x9d774630.fontSharedMaterial;
        if (_0x10ef04d3 == null || !_0x10ef04d3.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x10ef04d3.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x10ef04d3.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x03e7d688 = _0x9d774630.color;
        if (_0x03e7d688.a <= 0f)
            return;
        Color _0x03055be1 = _0x10ef04d3.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x03e7d688, _0x03055be1) >= MinRatio)
            return;
        Color _0x016b9834 = Luminance(_0x03055be1) < 0.5f ? Color.white : Color.black;
        Color _0xe896a9d1;
        if (Ratio(_0x016b9834, _0x03055be1) < TargetRatio)
        {
            _0xe896a9d1 = _0x016b9834;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x9b107d1c = 0f;
            float _0x091af84f = 1f;
            for (int _0xc6988e41 = 0; _0xc6988e41 < 20; _0xc6988e41++)
            {
                float _0x93306b80 = (_0x9b107d1c + _0x091af84f) * 0.5f;
                if (Ratio(Color.Lerp(_0x03e7d688, _0x016b9834, _0x93306b80), _0x03055be1) >= TargetRatio)
                    _0x091af84f = _0x93306b80;
                else
                    _0x9b107d1c = _0x93306b80;
            }

            _0xe896a9d1 = Color.Lerp(_0x03e7d688, _0x016b9834, _0x091af84f);
        }

        _0xe896a9d1.a = _0x03e7d688.a;
        _0x9d774630.color = _0xe896a9d1;
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0xf953473c)
    {
        return 0.2126f * Linear(_0xf953473c.r) + 0.7152f * Linear(_0xf953473c.g) + 0.0722f * Linear(_0xf953473c.b);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x3e22b671 != null)
            return;
        GameObject _0x60358404 = new GameObject(_0xe236e8a8._0xf503da8b(new byte[16] { 163, 154, 135, 180, 152, 153, 131, 133, 150, 132, 131, 176, 130, 150, 133, 147 }, 247));
        _0x60358404.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x60358404);
        _0x3e22b671 = _0x60358404.AddComponent<_0xfefa4af3>();
    }

    private static float Ratio(Color _0xd43daf35, Color _0x190e4afd)
    {
        float _0xaa5fea4f = Luminance(_0xd43daf35);
        float _0xc78d23a1 = Luminance(_0x190e4afd);
        return (Mathf.Max(_0xaa5fea4f, _0xc78d23a1) + 0.05f) / (Mathf.Min(_0xaa5fea4f, _0xc78d23a1) + 0.05f);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xc6f3a09c(Object _0x22e6f76d)
    {
        TMP_Text _0x07d1cef5 = _0x22e6f76d as TMP_Text;
        if (_0x07d1cef5 != null)
            this._0xf97e88fe.Add(_0x07d1cef5);
    }

    private const float TargetRatio = 7f;
    private static float Linear(float _0xa34a02df)
    {
        _0xa34a02df = Mathf.Clamp01(_0xa34a02df);
        return _0xa34a02df <= 0.03928f ? _0xa34a02df / 12.92f : Mathf.Pow((_0xa34a02df + 0.055f) / 1.055f, 2.4f);
    }

    private const float MinRatio = 4.5f;
    private readonly HashSet<TMP_Text> _0xf97e88fe = new HashSet<TMP_Text>();
    private const float MinOutlineWidth = 0.01f;
    private void LateUpdate()
    {
        if (this._0xf97e88fe.Count == 0)
            return;
        this._0x0fcea311.Clear();
        this._0x0fcea311.AddRange(this._0xf97e88fe);
        this._0xf97e88fe.Clear();
        for (int _0xcd579bc5 = 0; _0xcd579bc5 < this._0x0fcea311.Count; _0xcd579bc5++)
            Fix(this._0x0fcea311[_0xcd579bc5]);
    }

    private readonly List<TMP_Text> _0x0fcea311 = new List<TMP_Text>();
    private void OnDisable()
    {
        if (this._0x4325fc7c != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x4325fc7c);
    }

    private static _0xfefa4af3 _0x3e22b671;
    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x4325fc7c;
}

internal static class _0xe236e8a8
{
    internal static string _0xf503da8b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}