using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The orbit picker. A full-screen shade doubles as the close control, so a tap that
// misses the corner glyph still closes the sheet instead of parking the screen on it.
// An empty list never shows a blank card - it shows a themed line.
public sealed class _0x3dccafdc : MonoBehaviour
{
    private Color _0x20488617(int _0x1911293f, bool _0xcea293fe)
    {
        if (!_0xcea293fe)
            return _0xc3a31033.WithAlpha(_0xc3a31033.Muted, 0.35f);
        return _0x1911293f == _0xf3b0ae9c._0x577c14bf ? _0xc3a31033.Gold : _0xc3a31033.WithAlpha(_0xc3a31033.Beacon, 0.7f);
    }

    private void _0x8d1dcf30(int _0xd44a1b96)
    {
        if (!_0xf3b0ae9c.IsUnlocked(_0xd44a1b96))
        {
            if (_0xd44a1b96 < this._0x5affb4f2.Count)
            {
                this._0x5affb4f2[_0xd44a1b96].transform.DOKill(true);
                this._0x5affb4f2[_0xd44a1b96].transform.DOShakePosition(0.3f, 14f, 18, 90f, false, true);
            }

            return;
        }

        _0xf3b0ae9c._0x577c14bf = _0xd44a1b96;
        PlayerPrefs.Save();
        for (int _0xa0dda7e3 = 0; _0xa0dda7e3 < this._0x5affb4f2.Count; _0xa0dda7e3++)
            this._0x5affb4f2[_0xa0dda7e3].color = this._0x20488617(_0xa0dda7e3, _0xf3b0ae9c.IsUnlocked(_0xa0dda7e3));
        if (_0xd44a1b96 < this._0x5affb4f2.Count)
            _0x7a25e7cb.Punch(this._0x5affb4f2[_0xd44a1b96].transform, 0.06f, 0.24f);
        if (this.MissionPicked != null)
            this.MissionPicked.Invoke(_0xd44a1b96);
        DOVirtual.DelayedCall(0.3f, () => this._0xb094de5c());
    }

    private const float TextWidth = 700f;
    private RectTransform _0xc60f385f;
    public void _0xb6ac8602(Transform _0x8ed7d7bc)
    {
        this._0xc60f385f = _0x7a25e7cb.Stretch(_0x8ed7d7bc, _0x03093a81._0x4f3b26f2(new byte[11] { 6, 27, 11, 0, 29, 22, 26, 1, 12, 12, 29 }, 73));
        // No sprite: a plain fill keeps the shade's corners square across the screen.
        Image _0xbfd4ce5d = this._0xc60f385f.gameObject.AddComponent<Image>();
        _0xbfd4ce5d.color = _0xc3a31033.WithAlpha(_0xc3a31033.VoidDeep, 0.84f);
        _0xbfd4ce5d.raycastTarget = true;
        Button _0xaaa96910 = this._0xc60f385f.gameObject.AddComponent<Button>();
        _0xaaa96910.transition = Selectable.Transition.None;
        _0xaaa96910.onClick.AddListener(() => this._0xb094de5c());
        RectTransform _0x0f7a58ab = _0x7a25e7cb.Node(this._0xc60f385f, _0x03093a81._0x4f3b26f2(new byte[9] { 38, 29, 16, 16, 1, 54, 20, 7, 17 }, 117), new Vector2(0.5f, 0.52f), Vector2.zero, new Vector2(1080f, 1380f));
        Image _0x843710b6 = _0x0f7a58ab.gameObject.AddComponent<Image>();
        _0x843710b6.type = Image.Type.Sliced;
        _0x843710b6.sprite = this._plate;
        _0x843710b6.color = _0xc3a31033.WithAlpha(_0xc3a31033.Beacon, 0.9f);
        _0x843710b6.raycastTarget = true;
        _0x843710b6.pixelsPerUnitMultiplier = _0x7a25e7cb.Radius(new Vector2(1080f, 1380f), 1.4f);
        RectTransform _0xc9a4a4a7 = _0x7a25e7cb.Stretch(_0x0f7a58ab, _0x03093a81._0x4f3b26f2(new byte[9] { 32, 27, 22, 22, 7, 49, 28, 23, 10 }, 115));
        _0xc9a4a4a7.offsetMin = new Vector2(10f, 10f);
        _0xc9a4a4a7.offsetMax = new Vector2(-10f, -10f);
        Image _0xa6b85158 = _0xc9a4a4a7.gameObject.AddComponent<Image>();
        _0xa6b85158.type = Image.Type.Sliced;
        _0xa6b85158.sprite = this._plate;
        _0xa6b85158.color = _0xc3a31033.WithAlpha(_0xc3a31033.Card, 0.98f);
        _0xa6b85158.raycastTarget = true;
        _0xa6b85158.pixelsPerUnitMultiplier = _0x7a25e7cb.Radius(new Vector2(1060f, 1360f), 1.5f);
        _0x7a25e7cb.Label(_0xc9a4a4a7, _0x03093a81._0x4f3b26f2(new byte[10] { 238, 213, 216, 216, 201, 233, 212, 201, 209, 216 }, 189), this._font, _0x03093a81._0x4f3b26f2(new byte[12] { 25, 15, 6, 15, 9, 30, 106, 5, 24, 8, 3, 30 }, 74), 58f, _0xc3a31033.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, 0.915f), Vector2.zero, new Vector2(820f, 92f));
        Button _0x6819aa1e = _0x7a25e7cb.Action(_0xc9a4a4a7, _0x03093a81._0x4f3b26f2(new byte[10] { 249, 194, 207, 207, 222, 233, 198, 197, 217, 207 }, 170), this._plate, this._font, string.Empty, _0xc3a31033.WithAlpha(_0xc3a31033.Rose, 0.9f), _0xc3a31033.Surface, _0xc3a31033.Cream, 34f, new Vector2(0.915f, 0.945f), Vector2.zero, new Vector2(92f, 92f));
        _0x7a25e7cb.Picture(_0x6819aa1e.transform, _0x03093a81._0x4f3b26f2(new byte[14] { 100, 95, 82, 82, 67, 116, 91, 88, 68, 82, 126, 84, 88, 89 }, 55), this._closeIcon, _0xc3a31033.Cream, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(44f, 44f));
        _0x6819aa1e.onClick.AddListener(() => this._0xb094de5c());
        int _0xfc614874 = 0;
        for (int _0x8d6796f6 = 0; _0x8d6796f6 < _0x9a1309ef._0x79d002e7 && _0x8d6796f6 < 3; _0x8d6796f6++)
        {
            this.BuildRow(_0xc9a4a4a7, _0x8d6796f6);
            _0xfc614874++;
        }

        // G: a list that can be empty says so in words, never with blank space.
        if (_0xfc614874 == 0)
            _0x7a25e7cb.Label(_0xc9a4a4a7, _0x03093a81._0x4f3b26f2(new byte[10] { 222, 229, 232, 232, 249, 200, 224, 253, 249, 244 }, 141), this._font, _0x03093a81._0x4f3b26f2(new byte[42] { 75, 74, 81, 77, 76, 75, 66, 37, 80, 75, 73, 74, 70, 78, 64, 65, 37, 92, 64, 81, 15, 85, 73, 68, 92, 37, 81, 74, 37, 74, 85, 64, 75, 37, 68, 75, 37, 74, 87, 71, 76, 81 }, 5), 40f, _0xc3a31033.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(820f, 200f));
        this._0xc60f385f.gameObject.SetActive(false);
    }

    private const float GutterWidth = 56f;
    private const float GutterCentre = -400f;
    public void _0x50befe38()
    {
        if (this._0xc60f385f == null)
            return;
        this._0xece87abc = true;
        this._0xc60f385f.gameObject.SetActive(true);
        this._0xc60f385f.localScale = new Vector3(0.94f, 0.94f, 1f);
        this._0xc60f385f.DOScale(1f, 0.22f).SetEase(Ease.OutBack);
        // A sheet with no way out would park the capture run on it.
        DOVirtual.DelayedCall(22f, () =>
        {
            if (this._0xece87abc)
                this._0xb094de5c();
        });
    }

    public System.Action<int> MissionPicked;
    [SerializeField]
    private Sprite _badgeIcon;
    private void BuildRow(Transform _0xd9a96c00, int _0x95b28c6c)
    {
        _0x9a1309ef _0x27f772ec = _0x9a1309ef.Row(_0x95b28c6c);
        bool _0x8191489a = _0xf3b0ae9c.IsUnlocked(_0x95b28c6c);
        float _0x245aa10c = 0.645f - _0x95b28c6c * 0.145f;
        RectTransform _0x6f296d56 = _0x7a25e7cb.Node(_0xd9a96c00, _0x03093a81._0x4f3b26f2(new byte[8] { 121, 68, 84, 95, 66, 100, 89, 65 }, 54) + _0x95b28c6c, new Vector2(0.5f, _0x245aa10c), Vector2.zero, new Vector2(940f, 180f));
        Image _0x14fb0285 = _0x6f296d56.gameObject.AddComponent<Image>();
        _0x14fb0285.type = Image.Type.Sliced;
        _0x14fb0285.sprite = this._plate;
        _0x14fb0285.color = this._0x20488617(_0x95b28c6c, _0x8191489a);
        _0x14fb0285.raycastTarget = true;
        _0x14fb0285.pixelsPerUnitMultiplier = _0x7a25e7cb.Radius(new Vector2(940f, 180f), 1.6f);
        this._0x5affb4f2.Add(_0x14fb0285);
        RectTransform _0x67afc86a = _0x7a25e7cb.Stretch(_0x6f296d56, _0x03093a81._0x4f3b26f2(new byte[7] { 225, 220, 196, 241, 220, 215, 202 }, 179));
        _0x67afc86a.offsetMin = new Vector2(7f, 7f);
        _0x67afc86a.offsetMax = new Vector2(-7f, -7f);
        Image _0x5bae16ba = _0x67afc86a.gameObject.AddComponent<Image>();
        _0x5bae16ba.type = Image.Type.Sliced;
        _0x5bae16ba.sprite = this._plate;
        _0x5bae16ba.color = _0x8191489a ? _0xc3a31033.WithAlpha(_0xc3a31033.Surface, 0.95f) : _0xc3a31033.WithAlpha(_0xc3a31033.Surface, 0.45f);
        _0x5bae16ba.raycastTarget = false;
        _0x5bae16ba.pixelsPerUnitMultiplier = _0x7a25e7cb.Radius(new Vector2(926f, 166f), 1.7f);
        // C.25: the difficulty column owns the left gutter; no label ever enters it.
        for (int _0x0cb2aef3 = 0; _0x0cb2aef3 < 3; _0x0cb2aef3++)
        {
            Color _0x5e9a373a = _0x0cb2aef3 < _0x27f772ec.Difficulty ? (_0x27f772ec.Difficulty == 1 ? _0xc3a31033.Beacon : _0x27f772ec.Difficulty == 2 ? _0xc3a31033.Gold : _0xc3a31033.Rose) : _0xc3a31033.WithAlpha(_0xc3a31033.Muted, 0.3f);
            _0x7a25e7cb.Picture(_0x67afc86a, _0x03093a81._0x4f3b26f2(new byte[4] { 94, 117, 116, 109 }, 29) + _0x0cb2aef3, this._badgeIcon, _0x8191489a ? _0x5e9a373a : _0xc3a31033.WithAlpha(_0x5e9a373a, 0.35f), new Vector2(0.5f, 0.5f), new Vector2(GutterCentre, 46f - _0x0cb2aef3 * 46f), new Vector2(GutterWidth, 38f));
        }

        _0x7a25e7cb.Label(_0x67afc86a, _0x03093a81._0x4f3b26f2(new byte[8] { 196, 249, 225, 194, 255, 226, 250, 243 }, 150), this._font, _0x27f772ec.Title, 50f, _0x8191489a ? _0xc3a31033.Cream : _0xc3a31033.Muted, TextAlignmentOptions.Left, new Vector2(0.5f, 0.5f), new Vector2(TextLeft + TextWidth * 0.5f, 34f), new Vector2(TextWidth, 62f));
        _0x7a25e7cb.Label(_0x67afc86a, _0x03093a81._0x4f3b26f2(new byte[7] { 1, 60, 36, 26, 61, 53, 60 }, 83), this._font, _0x8191489a ? _0x27f772ec._0xd836d311() : _0x03093a81._0x4f3b26f2(new byte[29] { 135, 132, 136, 128, 142, 143, 235, 230, 235, 136, 135, 142, 138, 153, 235, 248, 235, 153, 132, 158, 159, 142, 152, 235, 141, 130, 153, 152, 159 }, 203), 30f, _0xc3a31033.Muted, TextAlignmentOptions.Left, new Vector2(0.5f, 0.5f), new Vector2(TextLeft + TextWidth * 0.5f, -34f), new Vector2(TextWidth, 48f));
        Button _0x69ec0ba7 = _0x6f296d56.gameObject.AddComponent<Button>();
        _0x69ec0ba7.targetGraphic = _0x14fb0285;
        ColorBlock _0x21e5d1d5 = _0x69ec0ba7.colors;
        _0x21e5d1d5.normalColor = Color.white;
        _0x21e5d1d5.highlightedColor = Color.white;
        _0x21e5d1d5.pressedColor = new Color(0.7f, 0.7f, 0.8f, 1f);
        _0x21e5d1d5.selectedColor = Color.white;
        _0x21e5d1d5.disabledColor = new Color(0.55f, 0.55f, 0.6f, 0.8f);
        _0x69ec0ba7.colors = _0x21e5d1d5;
        int _0x2d5e0f52 = _0x95b28c6c;
        _0x69ec0ba7.onClick.AddListener(() => this._0x8d1dcf30(_0x2d5e0f52));
    }

    [SerializeField]
    private Sprite _plate;
    public bool _0xa9c276c1
    {
        get
        {
            return this._0xece87abc;
        }
    }

    [SerializeField]
    private Sprite _closeIcon;
    public void _0xb094de5c()
    {
        if (this._0xc60f385f == null || !this._0xece87abc)
            return;
        this._0xece87abc = false;
        this._0xc60f385f.DOKill(true);
        this._0xc60f385f.gameObject.SetActive(false);
    }

    private const float TextLeft = -326f;
    private bool _0xece87abc;
    [SerializeField]
    private TMP_FontAsset _font;
    private readonly List<Image> _0x5affb4f2 = new List<Image>(3);
}

internal static class _0x03093a81
{
    internal static string _0x4f3b26f2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}