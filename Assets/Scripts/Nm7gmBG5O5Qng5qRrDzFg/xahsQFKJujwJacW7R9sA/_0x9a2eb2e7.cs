using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x9a2eb2e7 : MonoBehaviour
{
    private static void SafeAreaChanged()
    {
        _0xb2341ff5 = Screen.safeArea;
        for (int _0x8842cfe2 = 0; _0x8842cfe2 < _0x0f7f589c.Count; _0x8842cfe2++)
            _0x0f7f589c[_0x8842cfe2]._0x9d983498();
    }

    private RectTransform _0x3572518e;
    private void _0x9d983498()
    {
        if (this._0x3572518e == null)
            return;
        Rect _0x31ad90db = Screen.safeArea;
        Vector2 _0x40954af1 = _0x31ad90db.position;
        Vector2 _0xe88effcd = _0x31ad90db.position + _0x31ad90db.size;
        _0x40954af1.x /= this._0xa56a6e1f.pixelRect.width;
        _0x40954af1.y /= this._0xa56a6e1f.pixelRect.height;
        _0xe88effcd.x /= this._0xa56a6e1f.pixelRect.width;
        _0xe88effcd.y /= this._0xa56a6e1f.pixelRect.height;
        this._0x3572518e.anchorMin = _0x40954af1;
        this._0x3572518e.anchorMax = _0xe88effcd;
    }

    private void Awake()
    {
        if (!_0x0f7f589c.Contains(this))
            _0x0f7f589c.Add(this);
        this._0xa56a6e1f = this.GetComponent<Canvas>();
        this._0xcfa3209d = this.GetComponent<RectTransform>();
        this._0x3572518e = this.transform.Find(_0xe63c86c8._0xf0a956ee(new byte[8] { 6, 52, 51, 48, 20, 39, 48, 52 }, 85)) as RectTransform;
        if (!_0x20218ac2)
        {
            _0xdcf2c01e = Screen.orientation;
            _0x7ee33df7.x = Screen.width;
            _0x7ee33df7.y = Screen.height;
            _0xb2341ff5 = Screen.safeArea;
            _0x20218ac2 = true;
        }

        this._0x9d983498();
    }

    private void Update()
    {
        if (_0x0f7f589c[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xdcf2c01e)
            OrientationChanged();
        if (Screen.safeArea != _0xb2341ff5)
            SafeAreaChanged();
        if (Screen.width != _0x7ee33df7.x || Screen.height != _0x7ee33df7.y)
            ResolutionChanged();
    }

    private static Vector2 _0x7ee33df7 = Vector2.zero;
    private static void OrientationChanged()
    {
        _0xdcf2c01e = Screen.orientation;
        _0x7ee33df7.x = Screen.width;
        _0x7ee33df7.y = Screen.height;
        _0x4a8569b1.Invoke();
    }

    private static ScreenOrientation _0xdcf2c01e = ScreenOrientation.LandscapeLeft;
    private static void ResolutionChanged()
    {
        _0x7ee33df7.x = Screen.width;
        _0x7ee33df7.y = Screen.height;
        _0x4a8569b1.Invoke();
    }

    private Canvas _0xa56a6e1f;
    private static readonly List<_0x9a2eb2e7> _0x0f7f589c = new();
    private static Rect _0xb2341ff5 = Rect.zero;
    private static bool _0x20218ac2;
    private void OnDestroy()
    {
        if (_0x0f7f589c != null && _0x0f7f589c.Contains(this))
            _0x0f7f589c.Remove(this);
    }

    private RectTransform _0xcfa3209d;
    private static UnityEvent _0x4a8569b1 = new();
}

internal static class _0xe63c86c8
{
    internal static string _0xf0a956ee(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}