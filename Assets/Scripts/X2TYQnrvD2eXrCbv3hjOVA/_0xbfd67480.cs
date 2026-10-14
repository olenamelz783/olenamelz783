using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Pointer input for the chart. The template's InputController exposes nothing public,
// so the gesture is read off UGUI instead: one near-transparent surface under the HUD
// that reports press, drag and release as WORLD points.
// It accepts a continuous drag AND a sequence of taps through the same path.
public sealed class _0xbfd67480 : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    private Camera _0x87d56da0;
    public void _0x2081b2d5(bool _0x372adfd9)
    {
        if (this._0x43a05a7e != null)
            this._0x43a05a7e.raycastTarget = _0x372adfd9;
    }

    public bool _0xa2634fb0 { get; set; }

    public void OnPointerDown(PointerEventData _0xf95a6a55)
    {
        if (!this._0xa2634fb0 || this.Pressed == null)
            return;
        this.Pressed.Invoke(this._0x61cd8ca6(_0xf95a6a55));
    }

    private Vector2 _0x61cd8ca6(PointerEventData _0xdd525381)
    {
        if (this._0x87d56da0 == null)
            return Vector2.zero;
        Vector3 _0x259d601c = this._0x87d56da0.ScreenToWorldPoint(new Vector3(_0xdd525381.position.x, _0xdd525381.position.y, -this._0x87d56da0.transform.position.z));
        return new Vector2(_0x259d601c.x, _0x259d601c.y);
    }

    public System.Action<Vector2> Dragged;
    public void OnPointerUp(PointerEventData _0x0bc676a9)
    {
        if (!this._0xa2634fb0 || this.Released == null)
            return;
        this.Released.Invoke(this._0x61cd8ca6(_0x0bc676a9));
    }

    public void _0x32f15483(Camera _0x445d7fb9, Image _0xbf8f2b94)
    {
        this._0x87d56da0 = _0x445d7fb9;
        this._0x43a05a7e = _0xbf8f2b94;
        this._0xa2634fb0 = false;
    }

    private Image _0x43a05a7e;
    public void OnDrag(PointerEventData _0xa82b9550)
    {
        if (!this._0xa2634fb0 || this.Dragged == null)
            return;
        this.Dragged.Invoke(this._0x61cd8ca6(_0xa82b9550));
    }

    public System.Action<Vector2> Pressed;
    public System.Action<Vector2> Released;
}