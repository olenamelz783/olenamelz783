using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The menu screen: an abstract mark on the splash, a living orbit chart behind the
// buttons, the mission banner and the start control. The template's start button is
// re-used as the tap target - this only gives it a face (its own layers are stencil
// gated and draw nothing).
public sealed class _0xb5da2608 : MonoBehaviour
{
    private TMP_Text _0x8e943846;
    private void _0x541866a9()
    {
        _0x9a1309ef _0x7de2b5e0 = _0x9a1309ef.Row(_0xf3b0ae9c._0x577c14bf);
        if (this._0xd79d0857 != null)
            this._0xd79d0857.text = _0x7de2b5e0.Title;
        if (this._0x2d6de3c9 != null)
            this._0x2d6de3c9.text = _0x7de2b5e0._0xd836d311();
        if (this._0x8e943846 != null)
            this._0x8e943846.text = _0xf3b0ae9c._0x5564f4ac.ToString();
    }

    [SerializeField]
    private Sprite _beaconLit;
    private void _0x1a5a2658()
    {
        if (this._sheet != null)
            this._sheet._0x50befe38();
    }

    // The template's start control is an EMPTY button variant: all of its own layers
    // are switched off or stencil gated, so it renders nothing. Giving it a face as a
    // CHILD keeps the template's own scene-loading driver in charge of the click.
    private void _0x26a49fa0()
    {
        if (this._playButtonRect == null)
            return;
        RectTransform _0x7c7a5f71 = _0x7a25e7cb.Stretch(this._playButtonRect, _0x8c985bc2._0xa72802ba(new byte[9] { 147, 180, 161, 178, 180, 134, 161, 163, 165 }, 192));
        Image _0xfd852666 = _0x7c7a5f71.gameObject.AddComponent<Image>();
        _0xfd852666.type = Image.Type.Sliced;
        _0xfd852666.sprite = this._plate;
        _0xfd852666.color = _0xc3a31033.Gold;
        _0xfd852666.raycastTarget = true;
        _0xfd852666.pixelsPerUnitMultiplier = _0x7a25e7cb.Radius(this._playButtonRect.rect.size, 1.4f);
        RectTransform _0xefcbdf1c = _0x7a25e7cb.Stretch(_0x7c7a5f71, _0x8c985bc2._0xa72802ba(new byte[9] { 121, 94, 75, 88, 94, 104, 69, 78, 83 }, 42));
        _0xefcbdf1c.offsetMin = new Vector2(9f, 9f);
        _0xefcbdf1c.offsetMax = new Vector2(-9f, -9f);
        Image _0x272a0f03 = _0xefcbdf1c.gameObject.AddComponent<Image>();
        _0x272a0f03.type = Image.Type.Sliced;
        _0x272a0f03.sprite = this._plate;
        _0x272a0f03.color = _0xc3a31033.Cobalt;
        _0x272a0f03.raycastTarget = false;
        _0x272a0f03.pixelsPerUnitMultiplier = _0x7a25e7cb.Radius(this._playButtonRect.rect.size - new Vector2(18f, 18f), 1.5f);
        _0x7a25e7cb.Picture(_0xefcbdf1c, _0x8c985bc2._0xa72802ba(new byte[9] { 165, 130, 151, 132, 130, 177, 154, 153, 129 }, 246), this._flareSprite, _0xc3a31033.WithAlpha(_0xc3a31033.Beacon, 0.8f), new Vector2(0.11f, 0.5f), Vector2.zero, new Vector2(64f, 64f));
        _0x7a25e7cb.Label(_0xefcbdf1c, _0x8c985bc2._0xa72802ba(new byte[12] { 226, 197, 208, 195, 197, 242, 208, 193, 197, 216, 222, 223 }, 177), this._font, _0x8c985bc2._0xa72802ba(new byte[11] { 227, 228, 241, 226, 228, 144, 226, 255, 229, 228, 245 }, 176), 56f, _0xc3a31033.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(34f, 0f), new Vector2(560f, 86f));
        _0x7c7a5f71.localScale = Vector3.one;
        _0x7c7a5f71.DOScale(1.03f, 1.1f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    private bool _0x64779a42;
    [SerializeField]
    private _0x4459ba5f _preview;
    private TMP_Text _0xd79d0857;
    [SerializeField]
    private Sprite _plate;
    private TMP_Text _0x2d6de3c9;
    private RectTransform _0xa2a460cd;
    [SerializeField]
    private TMP_FontAsset _font;
    private void _0x8cfc8f56(int _0xad14e9c1)
    {
        this._0x541866a9();
        if (this._0xa2a460cd != null)
            _0x7a25e7cb.Punch(this._0xa2a460cd, 0.08f, 0.3f);
        if (this._preview != null)
            this._preview._0x2c79c7cf();
    }

    [SerializeField]
    private Sprite _ringSprite;
    // - splash: an abstract mark, never the application's name (hard rule 1) -
    private void _0x856540e0()
    {
        Transform _0x71ce3f84 = _0x57d17e4b.PanelBody(_0xddcc2409._0xe09069ce.SPLASH);
        if (_0x71ce3f84 == null)
            return;
        RectTransform _0x94a5f12c = _0x7a25e7cb.Node(_0x71ce3f84, _0x8c985bc2._0xa72802ba(new byte[10] { 78, 109, 113, 124, 110, 117, 80, 124, 111, 118 }, 29), new Vector2(0.5f, 0.57f), Vector2.zero, new Vector2(620f, 620f));
        _0x7a25e7cb.Picture(_0x94a5f12c, _0x8c985bc2._0xa72802ba(new byte[8] { 144, 188, 175, 182, 143, 180, 179, 186 }, 221), this._ringSprite, _0xc3a31033.WithAlpha(_0xc3a31033.Gold, 0.85f), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(560f, 560f));
        for (int _0x59524cd6 = 0; _0x59524cd6 < _0x55c8835b.BeaconCount; _0x59524cd6++)
        {
            float _0x61c4c96f = 200f - _0x59524cd6 * 36f;
            float _0x8a192b79 = _0x61c4c96f * Mathf.Deg2Rad;
            Vector2 _0xc77920e0 = new Vector2(Mathf.Cos(_0x8a192b79) * 248f, Mathf.Sin(_0x8a192b79) * 248f);
            Image _0xe3a54464 = _0x7a25e7cb.Picture(_0x94a5f12c, _0x8c985bc2._0xa72802ba(new byte[7] { 61, 17, 2, 27, 52, 31, 4 }, 112) + _0x59524cd6, this._beaconLit, _0xc3a31033.WithAlpha(_0xc3a31033.Beacon, 0.85f), new Vector2(0.5f, 0.5f), _0xc77920e0, new Vector2(96f, 96f));
            _0xe3a54464.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
            _0xe3a54464.transform.DOScale(1f, 0.34f).SetEase(Ease.OutBack).SetDelay(0.18f + _0x59524cd6 * 0.09f);
            DOTween.ToAlpha(() => _0xe3a54464.color, _0xef0bce19 => _0xe3a54464.color = _0xef0bce19, 1f, 0.8f).SetLoops(-1, LoopType.Yoyo).SetDelay(1f + _0x59524cd6 * 0.09f);
        }

        _0x7a25e7cb.Label(_0x71ce3f84, _0x8c985bc2._0xa72802ba(new byte[13] { 201, 234, 246, 251, 233, 242, 217, 251, 234, 238, 243, 245, 244 }, 154), this._font, _0x8c985bc2._0xa72802ba(new byte[7] { 11, 8, 6, 3, 14, 9, 0 }, 71), 30f, _0xc3a31033.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.19f), Vector2.zero, new Vector2(520f, 50f));
        // Built first so the template's loading bar stays the last sibling and keeps
        // drawing on top of anything added here.
        _0x94a5f12c.SetAsFirstSibling();
    }

    private void Start()
    {
        float _0xf4435b06 = 5f;
        float _0x3602b40d = 2.25f;
        Camera _0x25b66668 = Camera.main;
        if (_0x25b66668 != null)
        {
            _0xf4435b06 = _0x25b66668.orthographicSize;
            _0x3602b40d = _0xf4435b06 * _0x25b66668.aspect;
        }

        _0x57d17e4b.BlankTutorialPanels();
        this._0x856540e0();
        Transform _0x790a3c98 = _0x57d17e4b.PanelBody(_0xddcc2409._0xe09069ce.DEFAULT);
        if (_0x790a3c98 == null)
            return;
        this._0x857f9344(_0x790a3c98);
        if (this._sheet != null)
        {
            this._sheet._0xb6ac8602(_0x790a3c98);
            this._sheet.MissionPicked = _0x08ab0851 => this._0x8cfc8f56(_0x08ab0851);
        }

        if (this._preview != null)
            this._preview._0x7aa3f1d4(_0x3602b40d, _0xf4435b06);
        this._0x541866a9();
    }

    [SerializeField]
    private RectTransform _playButtonRect;
    [SerializeField]
    private _0x3dccafdc _sheet;
    // - menu body -
    private void _0x857f9344(Transform _0xb606fde0)
    {
        RectTransform _0xd5039a5d = _0x7a25e7cb.Node(_0xb606fde0, _0x8c985bc2._0xa72802ba(new byte[9] { 220, 251, 237, 234, 206, 242, 255, 234, 251 }, 158), new Vector2(0.78f, 0.945f), Vector2.zero, new Vector2(420f, 104f));
        Image _0xe75c4668 = _0xd5039a5d.gameObject.AddComponent<Image>();
        _0xe75c4668.type = Image.Type.Sliced;
        _0xe75c4668.sprite = this._plate;
        _0xe75c4668.color = _0xc3a31033.WithAlpha(_0xc3a31033.Beacon, 0.75f);
        _0xe75c4668.raycastTarget = false;
        _0xe75c4668.pixelsPerUnitMultiplier = _0x7a25e7cb.Radius(new Vector2(420f, 104f), 1.5f);
        RectTransform _0xf7b73714 = _0x7a25e7cb.Stretch(_0xd5039a5d, _0x8c985bc2._0xa72802ba(new byte[8] { 40, 15, 25, 30, 40, 5, 14, 19 }, 106));
        _0xf7b73714.offsetMin = new Vector2(6f, 6f);
        _0xf7b73714.offsetMax = new Vector2(-6f, -6f);
        Image _0x9f38e9d9 = _0xf7b73714.gameObject.AddComponent<Image>();
        _0x9f38e9d9.type = Image.Type.Sliced;
        _0x9f38e9d9.sprite = this._plate;
        _0x9f38e9d9.color = _0xc3a31033.WithAlpha(_0xc3a31033.Card, 0.95f);
        _0x9f38e9d9.raycastTarget = false;
        _0x9f38e9d9.pixelsPerUnitMultiplier = _0x7a25e7cb.Radius(new Vector2(408f, 92f), 1.6f);
        // C.25: the icon keeps its own gutter, the text column starts clear of it.
        _0x7a25e7cb.Picture(_0xf7b73714, _0x8c985bc2._0xa72802ba(new byte[8] { 4, 35, 53, 50, 15, 37, 41, 40 }, 70), this._flareSprite, _0xc3a31033.Gold, new Vector2(0.5f, 0.5f), new Vector2(-168f, 0f), new Vector2(52f, 52f));
        _0x7a25e7cb.Label(_0xf7b73714, _0x8c985bc2._0xa72802ba(new byte[11] { 24, 63, 41, 46, 25, 59, 42, 46, 51, 53, 52 }, 90), this._font, _0x8c985bc2._0xa72802ba(new byte[11] { 223, 216, 206, 201, 189, 206, 201, 207, 216, 220, 214 }, 157), 26f, _0xc3a31033.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(34f, 22f), new Vector2(300f, 36f));
        this._0x8e943846 = _0x7a25e7cb.Label(_0xf7b73714, _0x8c985bc2._0xa72802ba(new byte[9] { 183, 144, 134, 129, 163, 148, 153, 128, 144 }, 245), this._font, _0xf3b0ae9c._0x5564f4ac.ToString(), 44f, _0xc3a31033.Gold, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(34f, -20f), new Vector2(300f, 52f));
        this._0xa2a460cd = _0x7a25e7cb.Node(_0xb606fde0, _0x8c985bc2._0xa72802ba(new byte[13] { 174, 138, 144, 144, 138, 140, 141, 161, 130, 141, 141, 134, 145 }, 227), new Vector2(0.5f, 0.405f), Vector2.zero, new Vector2(920f, 136f));
        Image _0xca607898 = this._0xa2a460cd.gameObject.AddComponent<Image>();
        _0xca607898.type = Image.Type.Sliced;
        _0xca607898.sprite = this._plate;
        _0xca607898.color = _0xc3a31033.WithAlpha(_0xc3a31033.Gold, 0.85f);
        _0xca607898.raycastTarget = false;
        _0xca607898.pixelsPerUnitMultiplier = _0x7a25e7cb.Radius(new Vector2(920f, 136f), 1.4f);
        RectTransform _0x92bb71af = _0x7a25e7cb.Stretch(this._0xa2a460cd, _0x8c985bc2._0xa72802ba(new byte[10] { 123, 88, 87, 87, 92, 75, 123, 86, 93, 64 }, 57));
        _0x92bb71af.offsetMin = new Vector2(7f, 7f);
        _0x92bb71af.offsetMax = new Vector2(-7f, -7f);
        Image _0x9212ef61 = _0x92bb71af.gameObject.AddComponent<Image>();
        _0x9212ef61.type = Image.Type.Sliced;
        _0x9212ef61.sprite = this._plate;
        _0x9212ef61.color = _0xc3a31033.WithAlpha(_0xc3a31033.Card, 0.96f);
        _0x9212ef61.raycastTarget = false;
        _0x9212ef61.pixelsPerUnitMultiplier = _0x7a25e7cb.Radius(new Vector2(906f, 122f), 1.5f);
        this._0xd79d0857 = _0x7a25e7cb.Label(_0x92bb71af, _0x8c985bc2._0xa72802ba(new byte[11] { 146, 177, 190, 190, 181, 162, 132, 185, 164, 188, 181 }, 208), this._font, _0x8c985bc2._0xa72802ba(new byte[7] { 181, 168, 184, 179, 174, 218, 179 }, 250), 50f, _0xc3a31033.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0f, 28f), new Vector2(840f, 60f));
        this._0x2d6de3c9 = _0x7a25e7cb.Label(_0x92bb71af, _0x8c985bc2._0xa72802ba(new byte[10] { 47, 12, 3, 3, 8, 31, 36, 3, 11, 2 }, 109), this._font, _0x8c985bc2._0xa72802ba(new byte[8] { 91, 78, 60, 33, 59, 58, 43, 61 }, 110), 30f, _0xc3a31033.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0f, -30f), new Vector2(840f, 46f));
        this._0x26a49fa0();
        Button _0xd64407ad = _0x7a25e7cb.Action(_0xb606fde0, _0x8c985bc2._0xa72802ba(new byte[12] { 17, 44, 60, 55, 42, 45, 28, 43, 42, 42, 49, 48 }, 94), this._plate, this._font, _0x8c985bc2._0xa72802ba(new byte[6] { 142, 147, 131, 136, 149, 146 }, 193), _0xc3a31033.WithAlpha(_0xc3a31033.Beacon, 0.9f), _0xc3a31033.Surface, _0xc3a31033.Beacon, 44f, new Vector2(0.5f, 0.195f), Vector2.zero, new Vector2(520f, 116f));
        _0xd64407ad.onClick.AddListener(() => this._0x1a5a2658());
        _0x7a25e7cb.Label(_0xb606fde0, _0x8c985bc2._0xa72802ba(new byte[8] { 36, 12, 7, 28, 33, 0, 7, 29 }, 105), this._font, _0x8c985bc2._0xa72802ba(new byte[45] { 29, 4, 14, 6, 109, 12, 3, 109, 2, 31, 15, 4, 25, 97, 109, 25, 5, 8, 3, 109, 1, 4, 3, 6, 71, 25, 5, 8, 109, 15, 8, 12, 14, 2, 3, 30, 109, 4, 3, 109, 2, 31, 9, 8, 31 }, 77), 30f, _0xc3a31033.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.105f), Vector2.zero, new Vector2(900f, 86f));
    }

    [SerializeField]
    private Sprite _flareSprite;
    private void Update()
    {
        _0xc5708f85 _0x5b0f04d1 = _0xc5708f85.Instance;
        if (_0x5b0f04d1 == null)
            return;
        bool _0xda1643b2 = _0x5b0f04d1.CurrentPanelIndex == _0xddcc2409._0xe09069ce.DEFAULT;
        if (_0xda1643b2 == this._0x64779a42)
            return;
        this._0x64779a42 = _0xda1643b2;
        if (this._preview != null)
            this._preview._0xfae49468(_0xda1643b2);
    }
}

internal static class _0x8c985bc2
{
    internal static string _0xa72802ba(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}