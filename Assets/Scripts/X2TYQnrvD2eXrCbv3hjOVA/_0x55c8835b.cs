using UnityEngine;

// Where the seven beacons hang this attempt, in world units. Positions are derived
// from the camera (C.0), never from constants: the caller passes the half-extents it
// measured off Camera.main.
public sealed class _0x55c8835b
{
    public readonly float[] Angles = new float[BeaconCount]; // degrees
    public readonly int[] Rings = new int[BeaconCount]; // 0..2
    public Vector2 _0x8f302b5e(int _0x27618fac)
    {
        float _0x4d4969fd = this.Angles[_0x27618fac] * Mathf.Deg2Rad;
        float _0xe51c83a8 = this.RingRadius[Mathf.Clamp(this.Rings[_0x27618fac], 0, 2)];
        return new Vector2(this.Centre.x + Mathf.Cos(_0x4d4969fd) * _0xe51c83a8, this.Centre.y + Mathf.Sin(_0x4d4969fd) * _0xe51c83a8);
    }

    public float BeaconDiameter;
    public Vector2 Centre;
    public float _0xc9a5a23c(int _0x4d7429d0, int _0x49e396f9)
    {
        return Vector2.Distance(this._0x8f302b5e(_0x4d7429d0), this._0x8f302b5e(_0x49e396f9));
    }

    // Shortest distance from beacon `probe` to the straight segment a->b.
    public float _0xadc632f8(int _0x77d8ffbb, int _0x51d1b56d, int _0x1b280090)
    {
        Vector2 _0x4b46073b = this._0x8f302b5e(_0x77d8ffbb);
        Vector2 _0x99644fbd = this._0x8f302b5e(_0x51d1b56d);
        Vector2 _0x7b82177f = this._0x8f302b5e(_0x1b280090);
        Vector2 _0x27d2a011 = _0x7b82177f - _0x99644fbd;
        float _0x88de4f58 = _0x27d2a011.sqrMagnitude;
        if (_0x88de4f58 < 0.0001f)
            return Vector2.Distance(_0x4b46073b, _0x99644fbd);
        float _0x7c2c8c3b = Mathf.Clamp01(Vector2.Dot(_0x4b46073b - _0x99644fbd, _0x27d2a011) / _0x88de4f58);
        return Vector2.Distance(_0x4b46073b, _0x99644fbd + _0x27d2a011 * _0x7c2c8c3b);
    }

    public const int BeaconCount = 7;
    public readonly float[] RingRadius = new float[3];
}