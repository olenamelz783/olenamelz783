using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The game screen's own HUD. Built from code into the template's empty panel body, so
// nothing here leans on a template placeholder (C.2). The three readouts sit in
// columns that never share an x-band with the attempt pips (C.25).
public sealed class _0x9ead1196 : MonoBehaviour
{
    private TMP_Text _0xa873e0b4;
    public void _0x414f6cf2(int _0x502547f8)
    {
        if (this._0xa873e0b4 != null)
            this._0xa873e0b4.text = _0x2457e199._0xce1415c8(new byte[4] { 165, 167, 167, 196 }, 228) + _0x502547f8 + _0x2457e199._0xce1415c8(new byte[1] { 185 }, 156);
    }

    private TMP_Text _0x45f8afb8;
    public void _0x91031a35(bool _0x8a6b6b03)
    {
        if (this._0x33bbb1ec != null)
            this._0x33bbb1ec.interactable = _0x8a6b6b03;
    }

    public void SetRoute(int _0x921e8bc7, int _0x7febafdf)
    {
        if (this._0x65e1a2a6 != null)
            this._0x65e1a2a6.text = _0x2457e199._0xce1415c8(new byte[6] { 50, 47, 53, 52, 37, 64 }, 96) + _0x921e8bc7 + _0x2457e199._0xce1415c8(new byte[3] { 37, 42, 37 }, 5) + _0x7febafdf;
    }

    private RectTransform _0xe5dee3cf;
    [SerializeField]
    private Sprite _pauseIcon;
    [SerializeField]
    private Sprite _pipSprite;
    private Button _0x33bbb1ec;
    public System.Action PauseRequested;
    public System.Action BackRequested;
    [SerializeField]
    private Sprite _plate;
    private TMP_Text _0x65e1a2a6;
    private readonly List<Image> _0x5f3fbaef = new List<Image>(3);
    private void _0x38efb790()
    {
        if (this.PauseRequested != null)
            this.PauseRequested.Invoke();
    }

    private Image _0x274a7c50;
    public void _0xd0e9450a(string _0x2ccc5ed9, Color _0x26df7015)
    {
        if (this._0x09122161 == null)
            return;
        this._0x09122161.text = _0x2ccc5ed9;
        this._0x09122161.color = _0x26df7015;
        _0x30f3add0.ApplyOutline(this._0x09122161);
        _0x7a25e7cb.Punch(this._0xe5dee3cf, 0.08f, 0.26f);
    }

    public System.Action ReplayRequested;
    public void _0x38f29288(string _0xd9f97ffc, string _0x02db2379, float _0x44a68418)
    {
        this._0x3aef17eb(_0xd9f97ffc);
        DOVirtual.DelayedCall(_0x44a68418, () => this._0x3aef17eb(_0x02db2379));
    }

    public void _0xefe22bb2(Transform _0x1f56b732)
    {
        RectTransform _0x094ff50f = _0x7a25e7cb.Stretch(_0x1f56b732, _0x2457e199._0xce1415c8(new byte[9] { 187, 166, 182, 189, 160, 171, 188, 161, 176 }, 244));
        // - top bar -
        _0x7a25e7cb.Plate(_0x094ff50f, _0x2457e199._0xce1415c8(new byte[8] { 97, 90, 69, 102, 93, 84, 81, 80 }, 53), this._plate, _0xc3a31033.WithAlpha(_0xc3a31033.VoidDeep, 0.72f), new Vector2(0.5f, 0.915f), Vector2.zero, new Vector2(1242f, 420f), 1.1f);
        Button _0xee27fe91 = _0x7a25e7cb.Action(_0x094ff50f, _0x2457e199._0xce1415c8(new byte[10] { 236, 207, 205, 197, 236, 219, 218, 218, 193, 192 }, 174), this._plate, this._font, string.Empty, _0xc3a31033.WithAlpha(_0xc3a31033.Beacon, 0.9f), _0xc3a31033.Surface, _0xc3a31033.Cream, 36f, new Vector2(0.085f, 0.952f), Vector2.zero, new Vector2(104f, 104f));
        _0x7a25e7cb.Picture(_0xee27fe91.transform, _0x2457e199._0xce1415c8(new byte[8] { 24, 59, 57, 49, 19, 57, 53, 52 }, 90), this._backIcon, _0xc3a31033.Cream, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(54f, 54f));
        _0xee27fe91.onClick.AddListener(() => this._0xfd747d0e());
        Button _0x91afbc06 = _0x7a25e7cb.Action(_0x094ff50f, _0x2457e199._0xce1415c8(new byte[11] { 31, 46, 58, 60, 42, 13, 58, 59, 59, 32, 33 }, 79), this._plate, this._font, string.Empty, _0xc3a31033.WithAlpha(_0xc3a31033.Beacon, 0.9f), _0xc3a31033.Surface, _0xc3a31033.Cream, 36f, new Vector2(0.915f, 0.952f), Vector2.zero, new Vector2(104f, 104f));
        _0x7a25e7cb.Picture(_0x91afbc06.transform, _0x2457e199._0xce1415c8(new byte[9] { 236, 221, 201, 207, 217, 245, 223, 211, 210 }, 188), this._pauseIcon, _0xc3a31033.Cream, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(50f, 50f));
        _0x91afbc06.onClick.AddListener(() => this._0x38efb790());
        this._0x65e1a2a6 = _0x7a25e7cb.Label(_0x094ff50f, _0x2457e199._0xce1415c8(new byte[10] { 161, 156, 134, 135, 150, 191, 146, 145, 150, 159 }, 243), this._font, _0x2457e199._0xce1415c8(new byte[11] { 1, 28, 6, 7, 22, 115, 98, 115, 124, 115, 102 }, 83), 60f, _0xc3a31033.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, 0.952f), Vector2.zero, new Vector2(520f, 86f));
        // - readout row: pips | streak | accuracy, three separate x-columns -
        RectTransform _0xb943079c = _0x7a25e7cb.Node(_0x094ff50f, _0x2457e199._0xce1415c8(new byte[11] { 235, 222, 222, 207, 199, 218, 222, 250, 195, 218, 217 }, 170), new Vector2(0.17f, 0.893f), Vector2.zero, new Vector2(260f, 60f));
        for (int _0x32716312 = 0; _0x32716312 < 3; _0x32716312++)
        {
            Image _0x88dd3ecd = _0x7a25e7cb.Picture(_0xb943079c, _0x2457e199._0xce1415c8(new byte[3] { 90, 99, 122 }, 10) + _0x32716312, this._pipSprite, _0xc3a31033.Beacon, new Vector2(0.5f, 0.5f), new Vector2(-72f + _0x32716312 * 72f, 0f), new Vector2(50f, 50f));
            this._0x5f3fbaef.Add(_0x88dd3ecd);
        }

        _0x7a25e7cb.Label(_0xb943079c, _0x2457e199._0xce1415c8(new byte[10] { 169, 144, 137, 186, 152, 137, 141, 144, 150, 151 }, 249), this._font, _0x2457e199._0xce1415c8(new byte[10] { 208, 213, 210, 215, 207, 188, 208, 217, 218, 200 }, 156), 26f, _0xc3a31033.Muted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0f, -46f), new Vector2(260f, 36f));
        this._0x45f8afb8 = _0x7a25e7cb.Label(_0x094ff50f, _0x2457e199._0xce1415c8(new byte[11] { 167, 128, 134, 145, 149, 159, 184, 149, 150, 145, 152 }, 244), this._font, _0x2457e199._0xce1415c8(new byte[8] { 244, 243, 245, 226, 230, 236, 135, 151 }, 167), 52f, _0xc3a31033.Gold, TextAlignmentOptions.Center, new Vector2(0.52f, 0.893f), Vector2.zero, new Vector2(420f, 70f));
        this._0xa873e0b4 = _0x7a25e7cb.Label(_0x094ff50f, _0x2457e199._0xce1415c8(new byte[13] { 35, 1, 1, 23, 16, 3, 1, 27, 46, 3, 0, 7, 14 }, 98), this._font, _0x2457e199._0xce1415c8(new byte[8] { 62, 60, 60, 95, 78, 79, 79, 90 }, 127), 40f, _0xc3a31033.Muted, TextAlignmentOptions.Center, new Vector2(0.855f, 0.893f), Vector2.zero, new Vector2(280f, 60f));
        // - answer window bar -
        _0x7a25e7cb.Plate(_0x094ff50f, _0x2457e199._0xce1415c8(new byte[11] { 126, 64, 71, 77, 70, 94, 125, 91, 72, 74, 66 }, 41), this._plate, _0xc3a31033.WithAlpha(_0xc3a31033.Surface, 0.92f), new Vector2(0.5f, 0.846f), Vector2.zero, new Vector2(880f, 26f), 1.4f);
        this._0x274a7c50 = _0x7a25e7cb.Plate(_0x094ff50f, _0x2457e199._0xce1415c8(new byte[10] { 46, 16, 23, 29, 22, 14, 63, 16, 21, 21 }, 121), this._plate, _0xc3a31033.Beacon, new Vector2(0.5f, 0.846f), Vector2.zero, new Vector2(880f, 26f), 1.4f);
        this._0x274a7c50.type = Image.Type.Filled;
        this._0x274a7c50.fillMethod = Image.FillMethod.Horizontal;
        this._0x274a7c50.fillOrigin = 0;
        this._0x274a7c50.fillAmount = 1f;
        // - phase badge + gesture hint + replay (C.6: the gesture is spelled out) -
        this._0xe5dee3cf = _0x7a25e7cb.Node(_0x094ff50f, _0x2457e199._0xce1415c8(new byte[10] { 35, 27, 18, 0, 22, 49, 18, 23, 20, 22 }, 115), new Vector2(0.5f, 0.295f), Vector2.zero, new Vector2(900f, 96f));
        _0x7a25e7cb.Plate(this._0xe5dee3cf, _0x2457e199._0xce1415c8(new byte[10] { 218, 226, 235, 249, 239, 218, 230, 235, 254, 239 }, 138), this._plate, _0xc3a31033.WithAlpha(_0xc3a31033.Card, 0.9f), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(620f, 96f), 1.4f);
        this._0x09122161 = _0x7a25e7cb.Label(this._0xe5dee3cf, _0x2457e199._0xce1415c8(new byte[10] { 231, 223, 214, 196, 210, 251, 214, 213, 210, 219 }, 183), this._font, _0x2457e199._0xce1415c8(new byte[5] { 54, 32, 53, 34, 41 }, 97), 56f, _0xc3a31033.Beacon, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(590f, 86f));
        this._0x4f3774ed = _0x7a25e7cb.Label(_0x094ff50f, _0x2457e199._0xce1415c8(new byte[9] { 230, 199, 192, 218, 226, 207, 204, 203, 194 }, 174), this._font, _0x2457e199._0xce1415c8(new byte[54] { 252, 234, 249, 255, 152, 254, 234, 247, 245, 152, 236, 240, 253, 152, 251, 247, 234, 253, 152, 236, 240, 234, 247, 237, 255, 240, 178, 236, 240, 253, 152, 250, 253, 249, 251, 247, 246, 235, 152, 149, 152, 236, 249, 232, 235, 152, 239, 247, 234, 243, 152, 236, 247, 247 }, 184), 36f, _0xc3a31033.Beacon, TextAlignmentOptions.Center, new Vector2(0.5f, 0.192f), Vector2.zero, new Vector2(1080f, 110f));
        this._0x33bbb1ec = _0x7a25e7cb.Action(_0x094ff50f, _0x2457e199._0xce1415c8(new byte[12] { 143, 184, 173, 177, 188, 164, 159, 168, 169, 169, 178, 179 }, 221), this._plate, this._font, _0x2457e199._0xce1415c8(new byte[12] { 204, 219, 206, 210, 223, 199, 190, 204, 209, 203, 202, 219 }, 158), _0xc3a31033.WithAlpha(_0xc3a31033.Beacon, 0.95f), _0xc3a31033.Surface, _0xc3a31033.Cream, 44f, new Vector2(0.5f, 0.098f), Vector2.zero, new Vector2(560f, 128f));
        this._0x33bbb1ec.onClick.AddListener(() => this._0xe0e6f14f());
    }

    [SerializeField]
    private Sprite _backIcon;
    private void _0xe0e6f14f()
    {
        if (this.ReplayRequested != null)
            this.ReplayRequested.Invoke();
    }

    public void _0xc4880c0a(int _0x88aeaf88)
    {
        if (this._0x45f8afb8 != null)
            this._0x45f8afb8.text = _0x2457e199._0xce1415c8(new byte[7] { 6, 1, 7, 16, 20, 30, 117 }, 85) + _0x88aeaf88;
    }

    public void SetWindow(float _0xad08756e)
    {
        if (this._0x274a7c50 == null)
            return;
        float _0xa1975ce8 = Mathf.Clamp01(_0xad08756e);
        this._0x274a7c50.fillAmount = _0xa1975ce8;
        this._0x274a7c50.color = _0xa1975ce8 < 0.22f ? _0xc3a31033.Rose : _0xc3a31033.Beacon;
    }

    [SerializeField]
    private TMP_FontAsset _font;
    public void SetAttempts(int _0xb8453587)
    {
        for (int _0xb0f9a971 = 0; _0xb0f9a971 < this._0x5f3fbaef.Count; _0xb0f9a971++)
        {
            bool _0x1f02492a = _0xb0f9a971 < _0xb8453587;
            this._0x5f3fbaef[_0xb0f9a971].color = _0x1f02492a ? _0xc3a31033.Beacon : _0xc3a31033.WithAlpha(_0xc3a31033.Muted, 0.28f);
            if (_0x1f02492a)
                _0x7a25e7cb.Punch(this._0x5f3fbaef[_0xb0f9a971].transform, 0.16f, 0.3f);
        }
    }

    public void _0x3aef17eb(string _0xf30e29ef)
    {
        if (this._0x4f3774ed != null)
            this._0x4f3774ed.text = _0xf30e29ef;
    }

    private TMP_Text _0x4f3774ed;
    private TMP_Text _0x09122161;
    private void _0xfd747d0e()
    {
        if (this.BackRequested != null)
            this.BackRequested.Invoke();
    }
}

internal static class _0x2457e199
{
    internal static string _0xce1415c8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}