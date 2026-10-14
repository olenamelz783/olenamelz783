using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xfb1f6453 : MonoBehaviour
{
    private Touch? _0x248d6bcc(Bounds _0x910aae7a)
    {
        if (!_0xf7ac444f.Instance._0x9909bd1b)
            return null;
        foreach (Touch _0x470dc105 in Touch.activeTouches)
            if (_0x470dc105.ended)
            {
                Vector3 _0x3797067c = Camera.main.ScreenToWorldPoint(_0x470dc105.screenPosition);
                Vector3 _0x99b45340 = new(_0x3797067c.x, _0x3797067c.y, _0x910aae7a.center.z);
                if (_0x910aae7a.Contains(_0x99b45340) && this._0xc046891f(_0x470dc105))
                    return _0x470dc105;
            }

        return null;
    }

    private void _0x587fe5f8(Touch? _0x48a972b6)
    {
        if (!_0xf7ac444f.Instance._0x9909bd1b)
        {
            _0x48a972b6 = null;
            return;
        }

        int _0x4613281a = _0x48a972b6.Value.touchId;
        _0x48a972b6 = Touch.activeTouches.FirstOrDefault(_0x3196176d => _0x3196176d.touchId == _0x4613281a);
        if (!this._0xc046891f(_0x48a972b6.Value))
            _0x48a972b6 = null;
    }

    private bool _0xc046891f(Touch? _0x8e5b58a8)
    {
        if (!_0x8e5b58a8.HasValue)
            return false;
        Vector3 _0xc427d397 = Camera.main.ScreenToWorldPoint(_0x8e5b58a8.Value.screenPosition);
        Vector3 _0x07555317 = _0xc427d397;
        _0x07555317.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x07555317))
            return true;
        _0x8e5b58a8 = null;
        return false;
    }

    private Touch? _0x77ef018c(Bounds _0x32d8d6a6, TouchPhase _0x5770c586)
    {
        if (!_0xf7ac444f.Instance._0x9909bd1b)
            return null;
        foreach (Touch _0x8f14f381 in Touch.activeTouches)
            if (_0x8f14f381.phase == _0x5770c586)
            {
                Vector3 _0x1a43faea = Camera.main.ScreenToWorldPoint(_0x8f14f381.screenPosition);
                Vector3 _0x1ffc8502 = new(_0x1a43faea.x, _0x1a43faea.y, _0x32d8d6a6.center.z);
                if (_0x32d8d6a6.Contains(_0x1ffc8502) && this._0xc046891f(_0x8f14f381))
                    return _0x8f14f381;
            }

        return null;
    }

    private Touch? _0x72483cae(Bounds _0x2f1bfc0b)
    {
        if (!_0xf7ac444f.Instance._0x9909bd1b)
            return null;
        foreach (Touch _0xec59cf6c in Touch.activeTouches)
            if (!_0xec59cf6c.ended)
            {
                Vector3 _0x3ebaccdb = Camera.main.ScreenToWorldPoint(_0xec59cf6c.screenPosition);
                Vector3 _0xc90362b0 = new(_0x3ebaccdb.x, _0x3ebaccdb.y, _0x2f1bfc0b.center.z);
                if (_0x2f1bfc0b.Contains(_0xc90362b0) && this._0xc046891f(_0xec59cf6c))
                    return _0xec59cf6c;
            }

        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x2337d6fa = this.gameObject.GetComponent<_0xfb1f6453>();
    }

    private static _0xfb1f6453 _0x2337d6fa;
    private bool _0x75fad577(Touch? _0x391284d2, Bounds _0x51f0b9a0, TouchPhase _0xaf8f56d4)
    {
        if (!_0xf7ac444f.Instance._0x9909bd1b)
        {
            _0x391284d2 = null;
            return false;
        }

        if (_0x391284d2 != null)
            if (_0x391284d2.Value.phase == _0xaf8f56d4)
            {
                Vector3 _0xbdc0a577 = Camera.main.ScreenToWorldPoint(_0x391284d2.Value.screenPosition);
                Vector3 _0x0d1e45e2 = new(_0xbdc0a577.x, _0xbdc0a577.y, _0x51f0b9a0.center.z);
                if (_0x51f0b9a0.Contains(_0x0d1e45e2) && this._0xc046891f(_0x391284d2.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0x1f194c44()
    {
        if (!_0xf7ac444f.Instance._0x9909bd1b)
            return null;
        foreach (Touch _0xd303c42f in Touch.activeTouches)
            if (_0xd303c42f.ended)
                if (this._0xc046891f(_0xd303c42f))
                    return _0xd303c42f;
        return null;
    }

    private Touch? _0x93a5d6ea()
    {
        if (!_0xf7ac444f.Instance._0x9909bd1b)
            return null;
        foreach (Touch _0xb90203f4 in Touch.activeTouches)
            if (!_0xb90203f4.ended)
                if (this._0xc046891f(_0xb90203f4))
                    return _0xb90203f4;
        return null;
    }

    public BoxCollider2D CameraTouchBounds;
}