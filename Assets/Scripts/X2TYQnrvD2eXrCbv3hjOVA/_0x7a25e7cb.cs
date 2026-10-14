using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Small factory for the runtime UGUI of this game. Everything is built from code
// because the scene template ships an empty panel body; nothing here looks anything
// up by name, so obfuscation cannot reach it.
public static class _0x7a25e7cb
{
    public static RectTransform Node(Transform _0xa2ee57a0, string _0x587c1ffc, Vector2 _0x4e1aa67e, Vector2 _0xad13b935, Vector2 _0xa9ca08ca)
    {
        GameObject _0x70dd6658 = new GameObject(_0x587c1ffc, typeof(RectTransform));
        RectTransform _0xd32dc03e = _0x70dd6658.GetComponent<RectTransform>();
        _0xd32dc03e.SetParent(_0xa2ee57a0, false);
        _0xd32dc03e.anchorMin = _0x4e1aa67e;
        _0xd32dc03e.anchorMax = _0x4e1aa67e;
        _0xd32dc03e.pivot = new Vector2(0.5f, 0.5f);
        _0xd32dc03e.anchoredPosition = _0xad13b935;
        _0xd32dc03e.sizeDelta = _0xa9ca08ca;
        _0xd32dc03e.localScale = Vector3.one;
        return _0xd32dc03e;
    }

    // A rounded plate. `plate` is the template's sliced_solid_round sprite, so the
    // corner radius is driven by pixelsPerUnitMultiplier: smaller = rounder.
    public static Image Plate(Transform _0x08f16530, string _0xb2944e69, Sprite _0x76e5e96b, Color _0x1777a6f9, Vector2 _0x22cd9d8f, Vector2 _0x7629373f, Vector2 _0x6044c700, float _0xce99860d)
    {
        RectTransform _0xeabcb193 = Node(_0x08f16530, _0xb2944e69, _0x22cd9d8f, _0x7629373f, _0x6044c700);
        Image _0x77810723 = _0xeabcb193.gameObject.AddComponent<Image>();
        _0x77810723.type = Image.Type.Sliced;
        _0x77810723.sprite = _0x76e5e96b;
        _0x77810723.color = _0x1777a6f9;
        _0x77810723.raycastTarget = false;
        _0x77810723.pixelsPerUnitMultiplier = Radius(_0x6044c700, _0xce99860d);
        return _0x77810723;
    }

    public static float Radius(Vector2 _0xf13c23b8, float _0x776ae39e)
    {
        float _0xd35c1303 = Mathf.Max(8f, Mathf.Min(_0xf13c23b8.x, _0xf13c23b8.y));
        return Mathf.Max(_0x776ae39e, PlateBorderPixels / _0xd35c1303);
    }

    public static void Punch(Transform _0xde6e35ea, float _0xd201ae6a, float _0x831f0262)
    {
        if (_0xde6e35ea == null)
            return;
        DG.Tweening.DOTween.Kill(_0xde6e35ea, true);
        _0xde6e35ea.localScale = Vector3.one;
        DG.Tweening.ShortcutExtensions.DOPunchScale(_0xde6e35ea, new Vector3(_0xd201ae6a, _0xd201ae6a, 0f), _0x831f0262, 6, 0.6f);
    }

    // A transparent surface that still takes raycasts. A fully transparent Image is
    // culled by the raycaster, so it needs a sliver of alpha and no transparent-mesh
    // culling.
    public static Image HitLayer(Transform _0x5a931cee, string _0x136e53b2)
    {
        RectTransform _0x0a3d7efb = Stretch(_0x5a931cee, _0x136e53b2);
        Image _0xf9d92f00 = _0x0a3d7efb.gameObject.AddComponent<Image>();
        _0xf9d92f00.color = new Color(1f, 1f, 1f, 0.004f);
        _0xf9d92f00.raycastTarget = true;
        _0xf9d92f00.canvasRenderer.cullTransparentMesh = false;
        return _0xf9d92f00;
    }

    public static Image Picture(Transform _0xe1b4c465, string _0xb5b6f90b, Sprite _0xfe5361dd, Color _0x0b7d89af, Vector2 _0x5f5045c3, Vector2 _0xefaf0ee7, Vector2 _0x07bcb876)
    {
        RectTransform _0xc6da627c = Node(_0xe1b4c465, _0xb5b6f90b, _0x5f5045c3, _0xefaf0ee7, _0x07bcb876);
        Image _0x56b9da04 = _0xc6da627c.gameObject.AddComponent<Image>();
        _0x56b9da04.preserveAspect = true;
        _0x56b9da04.sprite = _0xfe5361dd;
        _0x56b9da04.color = _0x0b7d89af;
        _0x56b9da04.raycastTarget = false;
        return _0x56b9da04;
    }

    public static RectTransform Stretch(Transform _0x49c000d6, string _0xdbc2cd55)
    {
        GameObject _0xb1e4131d = new GameObject(_0xdbc2cd55, typeof(RectTransform));
        RectTransform _0x32f21f24 = _0xb1e4131d.GetComponent<RectTransform>();
        _0x32f21f24.SetParent(_0x49c000d6, false);
        _0x32f21f24.anchorMin = Vector2.zero;
        _0x32f21f24.anchorMax = Vector2.one;
        _0x32f21f24.offsetMin = Vector2.zero;
        _0x32f21f24.offsetMax = Vector2.zero;
        _0x32f21f24.localScale = Vector3.one;
        return _0x32f21f24;
    }

    public static TMP_Text Label(Transform _0xbcf0088e, string _0x7a7a77e6, TMP_FontAsset _0x18d81c75, string _0x2843bd20, float _0x10b931fe, Color _0x8ae546d7, TextAlignmentOptions _0x3d1051e8, Vector2 _0xd382dfb3, Vector2 _0x10306eca, Vector2 _0x2aa08bb5)
    {
        RectTransform _0x37a76c59 = Node(_0xbcf0088e, _0x7a7a77e6, _0xd382dfb3, _0x10306eca, _0x2aa08bb5);
        TextMeshProUGUI _0xec492793 = _0x37a76c59.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0x18d81c75 != null)
            _0xec492793.font = _0x18d81c75;
        _0xec492793.text = _0x2843bd20;
        _0xec492793.color = _0x8ae546d7;
        _0xec492793.alignment = _0x3d1051e8;
        _0xec492793.raycastTarget = false;
        // C.10 / C.12: the engine never decides where a line ends, and autosize never
        // falls below the readability floor.
        _0xec492793.textWrappingMode = TextWrappingModes.NoWrap;
        _0xec492793.overflowMode = TextOverflowModes.Overflow;
        _0xec492793.enableAutoSizing = true;
        _0xec492793.fontSizeMin = 24f;
        _0xec492793.fontSizeMax = _0x10b931fe;
        _0xec492793.fontSize = _0x10b931fe;
        _0x30f3add0.ApplyOutline(_0xec492793);
        return _0xec492793;
    }

    // A framed button: accent frame, dark body, light caption. The caption is the LAST
    // child so it always draws over the body (C.13 / E.1).
    public static Button Action(Transform _0x94dec7bf, string _0xc17516ae, Sprite _0x2c81dd6f, TMP_FontAsset _0x53e33c24, string _0xb11d7725, Color _0x544ff921, Color _0xc11f82d4, Color _0x78134169, float _0x8c49f505, Vector2 _0x4e543196, Vector2 _0xb61c5c52, Vector2 _0xe608f9ae)
    {
        RectTransform _0x850cf2c0 = Node(_0x94dec7bf, _0xc17516ae, _0x4e543196, _0xb61c5c52, _0xe608f9ae);
        Image _0xa65563b0 = _0x850cf2c0.gameObject.AddComponent<Image>();
        _0xa65563b0.type = Image.Type.Sliced;
        _0xa65563b0.sprite = _0x2c81dd6f;
        _0xa65563b0.color = _0x544ff921;
        _0xa65563b0.raycastTarget = true;
        _0xa65563b0.pixelsPerUnitMultiplier = Radius(_0xe608f9ae, 1.4f);
        RectTransform _0x9528a4d6 = Stretch(_0x850cf2c0, _0x9720ae68._0xda6a4a83(new byte[4] { 95, 114, 121, 100 }, 29));
        _0x9528a4d6.offsetMin = new Vector2(7f, 7f);
        _0x9528a4d6.offsetMax = new Vector2(-7f, -7f);
        Image _0x0b62d2f4 = _0x9528a4d6.gameObject.AddComponent<Image>();
        _0x0b62d2f4.type = Image.Type.Sliced;
        _0x0b62d2f4.sprite = _0x2c81dd6f;
        _0x0b62d2f4.color = _0xc11f82d4;
        _0x0b62d2f4.raycastTarget = false;
        _0x0b62d2f4.pixelsPerUnitMultiplier = Radius(_0xe608f9ae - new Vector2(14f, 14f), 1.4f);
        if (!string.IsNullOrEmpty(_0xb11d7725))
            Label(_0x850cf2c0, _0x9720ae68._0xda6a4a83(new byte[7] { 29, 63, 46, 42, 55, 49, 48 }, 94), _0x53e33c24, _0xb11d7725, _0x8c49f505, _0x78134169, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xe608f9ae.x - 36f, _0xe608f9ae.y - 18f));
        Button _0xc168b702 = _0x850cf2c0.gameObject.AddComponent<Button>();
        _0xc168b702.targetGraphic = _0xa65563b0;
        ColorBlock _0x4ab80a63 = _0xc168b702.colors;
        _0x4ab80a63.normalColor = Color.white;
        _0x4ab80a63.highlightedColor = Color.white;
        _0x4ab80a63.pressedColor = new Color(0.68f, 0.68f, 0.78f, 1f);
        _0x4ab80a63.selectedColor = Color.white;
        _0x4ab80a63.disabledColor = new Color(0.5f, 0.5f, 0.5f, 0.6f);
        _0xc168b702.colors = _0x4ab80a63;
        return _0xc168b702;
    }

    // The template's own rounded 9-slice plate. Using it instead of a generated PNG
    // removes every "missing sprite = white rectangle" risk from the chrome (B.1).
    // Its sprite carries a 127px border per side, so the two borders of a 9-slice meet
    // - and the plate renders as a sliver - unless 254/multiplier stays under the
    // SHORTEST drawn side. 300 keeps an 18% margin on top of that.
    private const float PlateBorderPixels = 300f;
}

internal static class _0x9720ae68
{
    internal static string _0xda6a4a83(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}