using DG.Tweening;
using UnityEngine;

// One beacon on the chart. Size is driven through SpriteRenderer.size so the explicit
// m_Size authored in the prefab stays the single source of truth (C.0) and the
// transform scale stays at 1.
public sealed class _0xf1ad5331 : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _renderer;
    public void _0xf8a6a214()
    {
        this._0xd4e44222++;
        if (this._renderer == null)
            return;
        DOTween.Kill(this._renderer, true);
        this._renderer.sprite = this._litSprite;
        this._renderer.color = _0xc3a31033.Gold;
        this._0xd6f1a5e3(1.2f, 0.22f);
    }

    [SerializeField]
    private Sprite _idleSprite;
    private int _0xd4e44222;
    public void _0xc8854792(bool _0x1dc1973d, float _0x131603e9)
    {
        this._0xd4e44222++;
        int _0x2803fa0a = this._0xd4e44222;
        if (this._renderer == null)
            return;
        DOTween.Kill(this._renderer, true);
        this._renderer.sprite = _0x1dc1973d ? this._decoySprite : this._litSprite;
        this._renderer.color = _0x1dc1973d ? _0xc3a31033.Rose : _0xc3a31033.Beacon;
        this._0xd6f1a5e3(_0x1dc1973d ? 1.08f : 1.18f, _0x131603e9 * 0.45f);
        DOVirtual.DelayedCall(_0x131603e9, () =>
        {
            if (_0x2803fa0a == this._0xd4e44222)
                this._0x3f72872f();
        });
    }

    [SerializeField]
    private Sprite _decoySprite;
    public void _0x3f72872f()
    {
        this._0xd4e44222++;
        if (this._renderer == null)
            return;
        DOTween.Kill(this._renderer, true);
        this._renderer.sprite = this._idleSprite;
        this._renderer.color = new Color(0.72f, 0.78f, 0.95f, 1f);
        this._renderer.size = new Vector2(this._0x2a307c6c, this._0x2a307c6c);
    }

    [SerializeField]
    private Sprite _litSprite;
    private void _0xd6f1a5e3(float _0x58e61fc0, float _0x8c3624f4)
    {
        SpriteRenderer _0x8e54e463 = this._renderer;
        float _0x69f3599c = this._0x2a307c6c * _0x58e61fc0;
        float _0x95d93865 = this._0x2a307c6c;
        DOTween.To(() => _0x8e54e463.size, _0x384aff84 => _0x8e54e463.size = _0x384aff84, new Vector2(_0x69f3599c, _0x69f3599c), _0x8c3624f4).SetEase(Ease.OutBack).OnComplete(() => DOTween.To(() => _0x8e54e463.size, _0x384aff84 => _0x8e54e463.size = _0x384aff84, new Vector2(_0x95d93865, _0x95d93865), _0x8c3624f4).SetEase(Ease.OutSine));
    }

    public void _0x8e667602(int _0xba8375fb, float _0xf9851f61)
    {
        this._0x01d7e3de = _0xba8375fb;
        this._0x2a307c6c = _0xf9851f61;
        if (this._renderer != null)
        {
            this._renderer.size = new Vector2(_0xf9851f61, _0xf9851f61);
            this._renderer.sprite = this._idleSprite;
            this._renderer.color = _0xc3a31033.Cream;
        }
    }

    private float _0x2a307c6c = 0.62f;
    public void _0xbbd67f0a()
    {
        this._0xd4e44222++;
        if (this._renderer == null)
            return;
        DOTween.Kill(this._renderer, true);
        this._renderer.sprite = this._litSprite;
        this._renderer.color = _0xc3a31033.Beacon;
        this._0xd6f1a5e3(1.14f, 0.16f);
    }

    public void _0x7cf9874e()
    {
        this._0xd4e44222++;
        int _0xb6f2c9b1 = this._0xd4e44222;
        if (this._renderer == null)
            return;
        DOTween.Kill(this._renderer, true);
        this._renderer.sprite = this._decoySprite;
        this._renderer.color = _0xc3a31033.Rose;
        this._0xd6f1a5e3(1.1f, 0.12f);
        DOVirtual.DelayedCall(0.55f, () =>
        {
            if (_0xb6f2c9b1 == this._0xd4e44222)
                this._0x3f72872f();
        });
    }

    public int _0x01d7e3de { get; private set; }
}