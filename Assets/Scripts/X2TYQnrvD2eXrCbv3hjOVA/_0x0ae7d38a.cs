using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

// Builds the world-space orbit chart from the generated prefabs and answers "which
// beacon is under this world point". Every sorting order comes from a named constant
// inside the -19..-1 corridor (C.0 / C.21).
public sealed class _0x0ae7d38a : MonoBehaviour
{
    public void _0xcb9c4c7e(Vector2 _0x27bc802b, Color _0xc3c63465)
    {
        if (this._sparkPrefab == null)
            return;
        for (int _0xb3706b2f = 0; _0xb3706b2f < 5; _0xb3706b2f++)
        {
            GameObject _0x3aaea108 = Instantiate(this._sparkPrefab, this._0x91376654, false);
            _0x3aaea108.name = _0xed05da45._0x3274e065(new byte[5] { 85, 86, 71, 84, 77 }, 6);
            _0x3aaea108.transform.position = new Vector3(_0x27bc802b.x, _0x27bc802b.y, 0f);
            SpriteRenderer _0xd20c5bd7 = _0x3aaea108.GetComponent<SpriteRenderer>();
            if (_0xd20c5bd7 == null)
            {
                Destroy(_0x3aaea108);
                continue;
            }

            _0xd20c5bd7.sortingOrder = SparkOrder;
            _0xd20c5bd7.color = _0xc3c63465;
            float _0x009f1311 = _0xb3706b2f * 72f + Random.Range(-18f, 18f);
            Vector3 _0xddabd000 = Quaternion.Euler(0f, 0f, _0x009f1311) * Vector3.right * (this._0x175f2acd.BeaconDiameter * 0.85f);
            _0x3aaea108.transform.DOMove(_0x3aaea108.transform.position + _0xddabd000, 0.45f).SetEase(Ease.OutQuad);
            _0xd20c5bd7.DOFade(0f, 0.45f).OnComplete(() => Destroy(_0x3aaea108));
        }
    }

    public const int BeaconOrder = -8;
    public Vector2 _0x28b8a48b(int _0xe02f2d1c)
    {
        return this._0x175f2acd != null ? this._0x175f2acd._0x8f302b5e(_0xe02f2d1c) : Vector2.zero;
    }

    private _0x55c8835b _0x175f2acd;
    public void _0x37b97e0f()
    {
        if (this._0x175f2acd == null)
            return;
        this._0xc22a9758.position = new Vector3(this._0x175f2acd.Centre.x, this._0x175f2acd.Centre.y, 0f);
        for (int _0x2d8d5002 = 0; _0x2d8d5002 < this._0x20932f40.Count; _0x2d8d5002++)
        {
            float _0xa48e1d1f = this._0x175f2acd.RingRadius[_0x2d8d5002] * 2f;
            this._0x20932f40[_0x2d8d5002].size = new Vector2(_0xa48e1d1f, _0xa48e1d1f);
        }

        if (this._0x9ee4c767 != null)
        {
            this._0x9ee4c767.transform.position = new Vector3(this._0x175f2acd.Centre.x, this._0x175f2acd.Centre.y, 0f);
            this._0x9ee4c767.size = new Vector2(this._0x633f5cb6, this._0x633f5cb6);
        }

        if (this._0x626c8c78 != null)
        {
            this._0x626c8c78.transform.position = new Vector3(this._0x175f2acd.Centre.x, this._0x175f2acd.Centre.y, 0f);
            this._0x626c8c78.size = new Vector2(this._0x633f5cb6 * 2.1f, this._0x633f5cb6 * 2.1f);
        }

        for (int _0xbf59ad7b = 0; _0xbf59ad7b < this._0xb1126f98.Count; _0xbf59ad7b++)
        {
            Vector2 _0x95d08c2b = this._0x175f2acd._0x8f302b5e(_0xbf59ad7b);
            this._0xb1126f98[_0xbf59ad7b].transform.position = new Vector3(_0x95d08c2b.x, _0x95d08c2b.y, 0f);
            this._0xb1126f98[_0xbf59ad7b]._0x8e667602(_0xbf59ad7b, this._0x175f2acd.BeaconDiameter);
            this._0xb1126f98[_0xbf59ad7b]._0x3f72872f();
        }
    }

    public Vector2 _0xcbff6a52
    {
        get
        {
            return this._0x175f2acd != null ? this._0x175f2acd.Centre : Vector2.zero;
        }
    }

    private float _0x633f5cb6 = 0.78f;
    [SerializeField]
    private GameObject _coreHubPrefab;
    public void _0xde23faeb(_0x55c8835b _0xb836efbb, float _0xb68abd16)
    {
        this._0x175f2acd = _0xb836efbb;
        this._0x633f5cb6 = _0xb68abd16;
        this._0x4b893fdb();
        this._0x9c624789();
        this._0xe9f9ad9a();
        this._0x2caeebe8();
        this._0x37b97e0f();
    }

    public const int CoreGlowOrder = -12;
    public void _0x2f0c6d7f()
    {
        for (int _0xe872835d = 0; _0xe872835d < this._0xb1126f98.Count; _0xe872835d++)
            this._0xb1126f98[_0xe872835d]._0x3f72872f();
    }

    public IList<_0xf1ad5331> _0xa3e3c728
    {
        get
        {
            return this._0xb1126f98;
        }
    }

    private readonly List<SpriteRenderer> _0x20932f40 = new List<SpriteRenderer>(3);
    public const int CoreOrder = -7;
    public const int SparkOrder = -3;
    private Transform _0xc22a9758;
    private void _0x4b893fdb()
    {
        if (this._0xc22a9758 == null)
        {
            GameObject _0x1b9b492b = new GameObject(_0xed05da45._0x3274e065(new byte[11] { 230, 251, 235, 224, 253, 246, 251, 224, 231, 238, 250 }, 169));
            _0x1b9b492b.transform.SetParent(this.transform, false);
            this._0xc22a9758 = _0x1b9b492b.transform;
        }

        if (this._0x91376654 == null)
        {
            GameObject _0xe730388a = new GameObject(_0xed05da45._0x3274e065(new byte[13] { 174, 179, 163, 168, 181, 190, 163, 164, 160, 162, 174, 175, 178 }, 225));
            _0xe730388a.transform.SetParent(this.transform, false);
            this._0x91376654 = _0xe730388a.transform;
        }
    }

    public void _0xb64c8d36()
    {
        if (this._0x9ee4c767 == null)
            return;
        SpriteRenderer _0x2f6c0de0 = this._0x9ee4c767;
        float _0x99bcda3b = this._0x633f5cb6 * 1.16f;
        float _0xab5996ee = this._0x633f5cb6;
        DOTween.Kill(_0x2f6c0de0, true);
        DOTween.To(() => _0x2f6c0de0.size, _0x384aff84 => _0x2f6c0de0.size = _0x384aff84, new Vector2(_0x99bcda3b, _0x99bcda3b), 0.16f).SetEase(Ease.OutBack).OnComplete(() => DOTween.To(() => _0x2f6c0de0.size, _0x384aff84 => _0x2f6c0de0.size = _0x384aff84, new Vector2(_0xab5996ee, _0xab5996ee), 0.2f));
    }

    public bool _0x7308fdf7(Vector2 _0x348e7a29)
    {
        if (this._0x175f2acd == null)
            return false;
        return Vector2.Distance(_0x348e7a29, this._0x175f2acd.Centre) < this._0x633f5cb6 * 1.1f;
    }

    public void _0xd91b830b()
    {
        this._0x91376654.DOKill(true);
        this._0x91376654.localPosition = Vector3.zero;
        this._0x91376654.DOShakePosition(0.26f, 0.18f, 22, 90f, false, true);
    }

    private SpriteRenderer _0x626c8c78;
    [SerializeField]
    private GameObject _orbitRingPrefab;
    public const int OrbitRingOrder = -16;
    private void _0x9c624789()
    {
        if (this._0x20932f40.Count > 0 || this._orbitRingPrefab == null)
            return;
        float[] _0x658dbe26 =
        {
            48f,
            36f,
            26f
        };
        for (int _0x41dc090c = 0; _0x41dc090c < 3; _0x41dc090c++)
        {
            GameObject _0xd76d5ac6 = Instantiate(this._orbitRingPrefab, this._0xc22a9758, false);
            _0xd76d5ac6.name = _0xed05da45._0x3274e065(new byte[11] { 105, 116, 100, 111, 114, 121, 116, 111, 104, 97, 121 }, 38) + _0x41dc090c;
            SpriteRenderer _0xe8a02514 = _0xd76d5ac6.GetComponent<SpriteRenderer>();
            if (_0xe8a02514 != null)
            {
                _0xe8a02514.sortingOrder = OrbitRingOrder + _0x41dc090c;
                _0xe8a02514.color = _0xc3a31033.WithAlpha(_0xc3a31033.Cobalt, 0.34f + _0x41dc090c * 0.14f);
                this._0x20932f40.Add(_0xe8a02514);
            }

            _0xd76d5ac6.transform.localRotation = Quaternion.Euler(0f, 0f, _0x41dc090c * 37f);
            _0xd76d5ac6.transform.DORotate(new Vector3(0f, 0f, 360f), _0x658dbe26[_0x41dc090c], RotateMode.FastBeyond360).SetRelative(true).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
        }
    }

    // Which beacon sits under this world point? -1 when none is close enough.
    public int _0xf5380fa5(Vector2 _0xce2ae4aa, float _0xd9a0ce89)
    {
        if (this._0x175f2acd == null)
            return -1;
        float _0x22960f37 = this._0x175f2acd.BeaconDiameter * _0xd9a0ce89;
        int _0xc9691f1b = -1;
        for (int _0xfecea0d3 = 0; _0xfecea0d3 < _0x55c8835b.BeaconCount; _0xfecea0d3++)
        {
            float _0xda7d09db = Vector2.Distance(_0xce2ae4aa, this._0x175f2acd._0x8f302b5e(_0xfecea0d3));
            if (_0xda7d09db < _0x22960f37)
            {
                _0x22960f37 = _0xda7d09db;
                _0xc9691f1b = _0xfecea0d3;
            }
        }

        return _0xc9691f1b;
    }

    private void _0x2caeebe8()
    {
        if (this._0xb1126f98.Count > 0 || this._beaconPrefab == null)
            return;
        for (int _0xa48031ba = 0; _0xa48031ba < _0x55c8835b.BeaconCount; _0xa48031ba++)
        {
            GameObject _0x8688dac0 = Instantiate(this._beaconPrefab, this._0x91376654, false);
            _0x8688dac0.name = _0xed05da45._0x3274e065(new byte[7] { 165, 162, 166, 164, 168, 169, 184 }, 231) + _0xa48031ba;
            SpriteRenderer _0xd9481433 = _0x8688dac0.GetComponent<SpriteRenderer>();
            if (_0xd9481433 != null)
                _0xd9481433.sortingOrder = BeaconOrder;
            _0xf1ad5331 _0x5407e66e = _0x8688dac0.GetComponent<_0xf1ad5331>();
            if (_0x5407e66e != null)
                this._0xb1126f98.Add(_0x5407e66e);
        }
    }

    private Transform _0x91376654;
    [SerializeField]
    private GameObject _beaconPrefab;
    private void _0xe9f9ad9a()
    {
        if (this._0x9ee4c767 == null && this._coreHubPrefab != null)
        {
            GameObject _0xf76c463a = Instantiate(this._coreHubPrefab, this._0x91376654, false);
            _0xf76c463a.name = _0xed05da45._0x3274e065(new byte[8] { 12, 0, 29, 10, 16, 7, 26, 13 }, 79);
            this._0x9ee4c767 = _0xf76c463a.GetComponent<SpriteRenderer>();
            if (this._0x9ee4c767 != null)
            {
                this._0x9ee4c767.sortingOrder = CoreOrder;
                this._0x9ee4c767.color = _0xc3a31033.Cream;
            }
        }

        if (this._0x626c8c78 == null && this._coreGlowPrefab != null)
        {
            GameObject _0x64d6b4d5 = Instantiate(this._coreGlowPrefab, this._0x91376654, false);
            _0x64d6b4d5.name = _0xed05da45._0x3274e065(new byte[9] { 232, 228, 249, 238, 244, 236, 231, 228, 252 }, 171);
            this._0x626c8c78 = _0x64d6b4d5.GetComponent<SpriteRenderer>();
            if (this._0x626c8c78 != null)
            {
                this._0x626c8c78.sortingOrder = CoreGlowOrder;
                this._0x626c8c78.color = _0xc3a31033.WithAlpha(_0xc3a31033.Cobalt, 0.4f);
            }
        }
    }

    public const int BeaconFlareOrder = -6;
    [SerializeField]
    private GameObject _coreGlowPrefab;
    private readonly List<_0xf1ad5331> _0xb1126f98 = new List<_0xf1ad5331>(_0x55c8835b.BeaconCount);
    private SpriteRenderer _0x9ee4c767;
    [SerializeField]
    private GameObject _sparkPrefab;
    public void _0xf67221dd(Color _0x16dab937)
    {
        if (this._0x626c8c78 != null)
            this._0x626c8c78.color = _0xc3a31033.WithAlpha(_0x16dab937, 0.46f);
    }
}

internal static class _0xed05da45
{
    internal static string _0x3274e065(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}