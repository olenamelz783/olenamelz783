using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// C.3: the result cards are rebuilt completely - palette, own close glyph, own
// captions - instead of borrowing the template's grey card and its leftover
// "Score:" / "Reward:" rows. Every template child of the pop body is switched off
// once, so nothing of the template's wording can show through.
public sealed class _0xb63e253a : MonoBehaviour
{
    // Fills a card. `rows` are the metric lines of THIS game - no template labels.
    public void _0xf0c452ef(_0x5ecf526f _0x6317330e, int _0x0e7d4d85, string _0x3535ead2, Color _0xd1950619, string _0x2151cc39, IList<string> _0x34168f5b, string _0x20b982b6, System.Action _0xf82b4464, string _0x576c3120, System.Action _0xc4b22139, System.Action _0x68c941ba)
    {
        RectTransform _0xf8bd41f9 = this._0x85f15e54(_0x6317330e, _0x0e7d4d85);
        if (_0xf8bd41f9 == null)
            return;
        Transform _0x76bb332b = _0xf8bd41f9.childCount > 0 ? _0xf8bd41f9.GetChild(0) : _0xf8bd41f9;
        for (int _0x747e12d8 = _0x76bb332b.childCount - 1; _0x747e12d8 >= 0; _0x747e12d8--)
        {
            GameObject _0xd2f6179e = _0x76bb332b.GetChild(_0x747e12d8).gameObject;
            _0xd2f6179e.SetActive(false);
            Destroy(_0xd2f6179e);
        }

        _0x7a25e7cb.Picture(_0x76bb332b, _0x729aa851._0x6a87b52f(new byte[9] { 201, 235, 248, 238, 204, 230, 235, 248, 239 }, 138), this._flareIcon, _0xc3a31033.WithAlpha(_0xd1950619, 0.85f), new Vector2(0.5f, 0.845f), Vector2.zero, new Vector2(132f, 132f));
        TMP_Text _0x5564fd64 = _0x7a25e7cb.Label(_0x76bb332b, _0x729aa851._0x6a87b52f(new byte[10] { 57, 27, 8, 30, 50, 31, 27, 30, 31, 8 }, 122), this._font, _0x3535ead2, 76f, _0xd1950619, TextAlignmentOptions.Center, new Vector2(0.5f, 0.715f), Vector2.zero, new Vector2(860f, 104f));
        _0x30f3add0.ApplyOutline(_0x5564fd64);
        _0x7a25e7cb.Label(_0x76bb332b, _0x729aa851._0x6a87b52f(new byte[8] { 189, 159, 140, 154, 178, 155, 159, 154 }, 254), this._font, _0x2151cc39, 38f, _0xc3a31033.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, 0.625f), Vector2.zero, new Vector2(860f, 70f));
        float _0xfc56020e = 0.52f;
        for (int _0xfbc93827 = 0; _0xfbc93827 < _0x34168f5b.Count && _0xfbc93827 < 3; _0xfbc93827++)
        {
            float _0x4e9bc31a = _0xfc56020e - _0xfbc93827 * 0.105f;
            _0x7a25e7cb.Plate(_0x76bb332b, _0x729aa851._0x6a87b52f(new byte[3] { 157, 160, 184 }, 207) + _0xfbc93827, this._plate, _0xc3a31033.WithAlpha(_0xc3a31033.Surface, 0.85f), new Vector2(0.5f, _0x4e9bc31a), Vector2.zero, new Vector2(820f, 92f), 1.5f);
            _0x7a25e7cb.Label(_0x76bb332b, _0x729aa851._0x6a87b52f(new byte[7] { 98, 95, 71, 100, 85, 72, 68 }, 48) + _0xfbc93827, this._font, _0x34168f5b[_0xfbc93827], 40f, _0xc3a31033.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, _0x4e9bc31a), Vector2.zero, new Vector2(780f, 70f));
        }

        Button _0x77f76753 = _0x7a25e7cb.Action(_0x76bb332b, _0x729aa851._0x6a87b52f(new byte[13] { 108, 78, 85, 81, 93, 78, 69, 125, 95, 72, 85, 83, 82 }, 60), this._plate, this._font, _0x20b982b6, _0xc3a31033.WithAlpha(_0xc3a31033.Gold, 0.95f), _0xc3a31033.Surface, _0xc3a31033.Cream, 46f, new Vector2(0.5f, 0.165f), Vector2.zero, new Vector2(700f, 132f));
        _0x77f76753.onClick.AddListener(() => this._0xc9acd516(_0xf82b4464));
        Button _0x8e7d7216 = _0x7a25e7cb.Action(_0x76bb332b, _0x729aa851._0x6a87b52f(new byte[15] { 119, 65, 71, 75, 74, 64, 69, 86, 93, 101, 71, 80, 77, 75, 74 }, 36), this._plate, this._font, _0x576c3120, _0xc3a31033.WithAlpha(_0xc3a31033.Beacon, 0.9f), _0xc3a31033.Surface, _0xc3a31033.Cream, 42f, new Vector2(0.5f, 0.06f), Vector2.zero, new Vector2(560f, 112f));
        _0x8e7d7216.onClick.AddListener(() => this._0xc9acd516(_0xc4b22139));
        // C.17: the corner glyph carries an icon, never a caption.
        Button _0xcb004947 = _0x7a25e7cb.Action(_0x76bb332b, _0x729aa851._0x6a87b52f(new byte[11] { 182, 153, 154, 134, 144, 180, 150, 129, 156, 154, 155 }, 245), this._plate, this._font, string.Empty, _0xc3a31033.WithAlpha(_0xc3a31033.Rose, 0.9f), _0xc3a31033.Surface, _0xc3a31033.Cream, 36f, new Vector2(0.92f, 0.945f), Vector2.zero, new Vector2(94f, 94f));
        _0x7a25e7cb.Picture(_0xcb004947.transform, _0x729aa851._0x6a87b52f(new byte[9] { 57, 22, 21, 9, 31, 51, 25, 21, 20 }, 122), this._closeIcon, _0xc3a31033.Cream, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(46f, 46f));
        _0xcb004947.onClick.AddListener(() => this._0xc9acd516(_0x68c941ba));
    }

    private void _0xc9acd516(System.Action _0x4483c302)
    {
        if (_0x4483c302 != null)
            _0x4483c302.Invoke();
    }

    private readonly Dictionary<int, RectTransform> _0xeeed3cea = new Dictionary<int, RectTransform>();
    public RectTransform _0x85f15e54(_0x5ecf526f _0x403322a5, int _0x7e4ee9f6)
    {
        if (_0x403322a5 == null || _0x403322a5.Content == null)
            return null;
        RectTransform _0x322460b4;
        if (this._0xeeed3cea.TryGetValue(_0x7e4ee9f6, out _0x322460b4) && _0x322460b4 != null)
            return _0x322460b4;
        Transform _0x6ef2d358 = _0x403322a5.Content.transform;
        for (int _0x05856092 = _0x6ef2d358.childCount - 1; _0x05856092 >= 0; _0x05856092--)
        {
            Transform _0x680fb079 = _0x6ef2d358.GetChild(_0x05856092);
            if (_0x680fb079 != null)
                _0x680fb079.gameObject.SetActive(false);
        }

        RectTransform _0xf38e4b8d = _0x7a25e7cb.Node(_0x6ef2d358, _0x729aa851._0x6a87b52f(new byte[9] { 126, 67, 83, 88, 69, 114, 80, 67, 85 }, 49), new Vector2(0.5f, 0.5f), new Vector2(0f, 40f), new Vector2(980f, 1120f));
        Image _0xd87fc21e = _0xf38e4b8d.gameObject.AddComponent<Image>();
        _0xd87fc21e.type = Image.Type.Sliced;
        _0xd87fc21e.sprite = this._plate;
        _0xd87fc21e.color = _0xc3a31033.WithAlpha(_0xc3a31033.Beacon, 0.9f);
        _0xd87fc21e.raycastTarget = true;
        _0xd87fc21e.pixelsPerUnitMultiplier = _0x7a25e7cb.Radius(new Vector2(980f, 1120f), 1.5f);
        RectTransform _0x1662a39c = _0x7a25e7cb.Stretch(_0xf38e4b8d, _0x729aa851._0x6a87b52f(new byte[8] { 140, 174, 189, 171, 141, 160, 171, 182 }, 207));
        _0x1662a39c.offsetMin = new Vector2(9f, 9f);
        _0x1662a39c.offsetMax = new Vector2(-9f, -9f);
        Image _0x3988963f = _0x1662a39c.gameObject.AddComponent<Image>();
        _0x3988963f.type = Image.Type.Sliced;
        _0x3988963f.sprite = this._plate;
        _0x3988963f.color = _0xc3a31033.WithAlpha(_0xc3a31033.Card, 0.98f);
        _0x3988963f.raycastTarget = false;
        _0x3988963f.pixelsPerUnitMultiplier = _0x7a25e7cb.Radius(new Vector2(962f, 1102f), 1.6f);
        this._0xeeed3cea[_0x7e4ee9f6] = _0xf38e4b8d;
        return _0xf38e4b8d;
    }

    [SerializeField]
    private Sprite _flareIcon;
    [SerializeField]
    private Sprite _plate;
    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite _closeIcon;
}

internal static class _0x729aa851
{
    internal static string _0x6a87b52f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}