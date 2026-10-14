using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x06affc93 : MonoBehaviour
{
    private static void ResolutionChanged()
    {
        _0x3da61693.x = Screen.width;
        _0x3da61693.y = Screen.height;
        _0x670ee5d4 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xdc69914c.Invoke();
    }

    private static bool _0x63114004;
    private Vector2 _0x471eab2c;
    private static void SafeAreaChanged()
    {
        _0x670ee5d4 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static Vector2 _0x3da61693 = Vector2.zero;
    private void _0x503521e9()
    {
        if (this._0x858b9f5b == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0xc1d8aabb = Screen.safeArea;
        Vector2 _0x9f296050 = _0xc1d8aabb.position;
        Vector2 _0x44344264 = _0xc1d8aabb.position + _0xc1d8aabb.size;
        _0x9f296050.x /= screenWidth;
        _0x9f296050.y /= screenHeight;
        _0x44344264.x /= screenWidth;
        _0x44344264.y /= screenHeight;
        this._0x858b9f5b.anchorMin = _0x9f296050;
        this._0x858b9f5b.anchorMax = _0x44344264;
        this._0x858b9f5b.offsetMin = Vector2.zero;
        this._0x858b9f5b.offsetMax = Vector2.zero;
        if (this._0x055c0d1a == null)
            return;
        Vector2 _0xe6a36879 = _0x44344264 - _0x9f296050;
        float _0x1e2bef88 = 2f - _0xe6a36879.x;
        float _0x0350d318 = 2f - _0xe6a36879.y;
        this._0x055c0d1a.referenceResolution = this._0x471eab2c * new Vector2(_0x1e2bef88, _0x0350d318);
    }

    private static UnityEvent _0xdc69914c = new();
    private static void ApplySafeAreaToAll()
    {
        for (int _0xa90bcd43 = 0; _0xa90bcd43 < _0x729b7b84.Count; _0xa90bcd43++)
            _0x729b7b84[_0xa90bcd43]._0x503521e9();
    }

    private void OnDestroy()
    {
        if (_0x729b7b84 != null && _0x729b7b84.Contains(this))
            _0x729b7b84.Remove(this);
    }

    private RectTransform _0x484b1d64;
    private void Awake()
    {
        if (!_0x729b7b84.Contains(this))
            _0x729b7b84.Add(this);
        this._0xde58a4af = this.GetComponent<Canvas>();
        this._0x055c0d1a = this.GetComponent<CanvasScaler>();
        if (this._0x055c0d1a != null)
            this._0x471eab2c = this._0x055c0d1a.referenceResolution;
        this._0x484b1d64 = this.GetComponent<RectTransform>();
        this._0x858b9f5b = this.transform.Find(_0xf55446c6._0x256e2748(new byte[8] { 247, 197, 194, 193, 229, 214, 193, 197 }, 164)) as RectTransform;
        if (!_0x63114004)
        {
            _0xb40f11a8 = Screen.orientation;
            _0x3da61693.x = Screen.width;
            _0x3da61693.y = Screen.height;
            _0x670ee5d4 = Screen.safeArea;
            _0x63114004 = true;
        }

        this._0x503521e9();
    }

    private static readonly List<_0x06affc93> _0x729b7b84 = new();
    private void Start()
    {
    }

    private static Rect _0x670ee5d4 = Rect.zero;
    private RectTransform _0x858b9f5b;
    private void Update()
    {
        if (_0x729b7b84.Count == 0 || _0x729b7b84[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xb40f11a8)
            OrientationChanged();
        if (Screen.safeArea != _0x670ee5d4)
            SafeAreaChanged();
        if (Screen.width != _0x3da61693.x || Screen.height != _0x3da61693.y)
            ResolutionChanged();
    }

    private Canvas _0xde58a4af;
    private static void OrientationChanged()
    {
        _0xb40f11a8 = Screen.orientation;
        _0x3da61693.x = Screen.width;
        _0x3da61693.y = Screen.height;
        _0x670ee5d4 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xdc69914c.Invoke();
    }

    private static ScreenOrientation _0xb40f11a8 = ScreenOrientation.LandscapeLeft;
    private CanvasScaler _0x055c0d1a;
}

internal static class _0xf55446c6
{
    internal static string _0x256e2748(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}