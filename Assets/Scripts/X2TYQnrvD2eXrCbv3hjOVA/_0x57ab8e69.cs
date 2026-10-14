using System.Collections.Generic;
using UnityEngine;

// C.11: the chart, the route and the noise are generated per attempt from a seed,
// then PROVEN runnable before they are shown. A hard-wired chart is the fallback,
// not the game.
public sealed class _0x57ab8e69
{
    public List<int> _0xec76e863(System.Random _0xc42a6d48, List<int> _0x9b4bd0cd, int _0xa87ef62e)
    {
        List<int> _0xf1951479 = new List<int>(_0x55c8835b.BeaconCount);
        for (int _0x310a08dc = 0; _0x310a08dc < _0x55c8835b.BeaconCount; _0x310a08dc++)
            if (!_0x9b4bd0cd.Contains(_0x310a08dc))
                _0xf1951479.Add(_0x310a08dc);
        for (int _0x4a480716 = _0xf1951479.Count - 1; _0x4a480716 > 0; _0x4a480716--)
        {
            int _0xa35fb2df = _0xc42a6d48.Next(0, _0x4a480716 + 1);
            int _0xbd4ff90f = _0xf1951479[_0x4a480716];
            _0xf1951479[_0x4a480716] = _0xf1951479[_0xa35fb2df];
            _0xf1951479[_0xa35fb2df] = _0xbd4ff90f;
        }

        List<int> _0xe4269c7b = new List<int>(_0xa87ef62e);
        for (int _0x442db472 = 0; _0x442db472 < _0xa87ef62e && _0x442db472 < _0xf1951479.Count; _0x442db472++)
            _0xe4269c7b.Add(_0xf1951479[_0x442db472]);
        return _0xe4269c7b;
    }

    // Hard-wired safety net: evenly spread slots on alternating rings, three-link route.
    public _0x55c8835b _0x739521a1(float _0xa0ce5883, Vector2 _0xd54614db, float _0x5d699c4f)
    {
        _0x55c8835b _0xb0ab7e74 = new _0x55c8835b();
        _0xb0ab7e74.Centre = _0xd54614db;
        _0xb0ab7e74.BeaconDiameter = _0x5d699c4f;
        for (int _0xd611938d = 0; _0xd611938d < 3; _0xd611938d++)
            _0xb0ab7e74.RingRadius[_0xd611938d] = _0x48243533[_0xd611938d] * _0xa0ce5883;
        for (int _0x063bee3e = 0; _0x063bee3e < _0x55c8835b.BeaconCount; _0x063bee3e++)
        {
            _0xb0ab7e74.Rings[_0x063bee3e] = _0x32b98a49[_0x063bee3e];
            _0xb0ab7e74.Angles[_0x063bee3e] = _0x063bee3e * (360f / _0x55c8835b.BeaconCount);
        }

        return _0xb0ab7e74;
    }

    public List<int> FallbackRoute(int _0xd7ae4a27)
    {
        List<int> _0x56bd776a = new List<int>
        {
            0,
            3,
            5,
            1,
            6,
            2,
            4
        };
        if (_0xd7ae4a27 < _0x56bd776a.Count)
            _0x56bd776a.RemoveRange(_0xd7ae4a27, _0x56bd776a.Count - _0xd7ae4a27);
        return _0x56bd776a;
    }

    // Rules 2 and 3: one comfortable gesture that cannot graze a beacon it did not aim
    // for. Together with IsChartUsable this is the "prove it before you show it" step.
    public bool _0x7a77c83a(_0x55c8835b _0x695ed10f, List<int> _0x8b70fe62, float _0x0db5a5bc)
    {
        if (_0x8b70fe62 == null || _0x8b70fe62.Count < 2)
            return false;
        float _0xd289d0b1 = _0x695ed10f.BeaconDiameter;
        float _0xeb18469f = Vector2.Distance(_0x695ed10f.Centre, _0x695ed10f._0x8f302b5e(_0x8b70fe62[0]));
        for (int _0xbde17c74 = 0; _0xbde17c74 + 1 < _0x8b70fe62.Count; _0xbde17c74++)
        {
            _0xeb18469f += _0x695ed10f._0xc9a5a23c(_0x8b70fe62[_0xbde17c74], _0x8b70fe62[_0xbde17c74 + 1]);
            for (int _0xed08689a = 0; _0xed08689a < _0x55c8835b.BeaconCount; _0xed08689a++)
            {
                if (_0xed08689a == _0x8b70fe62[_0xbde17c74] || _0xed08689a == _0x8b70fe62[_0xbde17c74 + 1])
                    continue;
                if (_0x695ed10f._0xadc632f8(_0xed08689a, _0x8b70fe62[_0xbde17c74], _0x8b70fe62[_0xbde17c74 + 1]) < _0xd289d0b1 * ClearanceFactor)
                    return false;
            }
        }

        return _0xeb18469f <= _0x0db5a5bc * 1.25f * (_0x8b70fe62.Count + 1);
    }

    public const float AngleJitter = 9f;
    // Rule 1: the seven beacons stay on screen and never crowd each other.
    public bool _0x9c58827a(_0x55c8835b _0xeb8bd875, float _0x4f45d567, float _0x6441a9e0)
    {
        float _0x1cfce114 = _0xeb8bd875.BeaconDiameter;
        float _0x7128e575 = _0x1cfce114 * 0.5f + 0.06f;
        for (int _0x66469ced = 0; _0x66469ced < _0x55c8835b.BeaconCount; _0x66469ced++)
        {
            Vector2 _0xf7cd7fad = _0xeb8bd875._0x8f302b5e(_0x66469ced);
            if (Mathf.Abs(_0xf7cd7fad.x) + _0x7128e575 > _0x4f45d567)
                return false;
            if (Mathf.Abs(_0xf7cd7fad.y) + _0x7128e575 > _0x6441a9e0)
                return false;
            for (int _0x714c342c = _0x66469ced + 1; _0x714c342c < _0x55c8835b.BeaconCount; _0x714c342c++)
                if (_0xeb8bd875._0xc9a5a23c(_0x66469ced, _0x714c342c) < _0x1cfce114 * SeparationFactor)
                    return false;
        }

        return true;
    }

    public List<int> _0xfb48c64d(System.Random _0xb97cbc2f, int _0xbe9a6eed)
    {
        this._0x577ac0af.Clear();
        for (int _0x73c5da12 = 0; _0x73c5da12 < _0x55c8835b.BeaconCount; _0x73c5da12++)
            this._0x577ac0af.Add(_0x73c5da12);
        for (int _0xe0c20fa6 = this._0x577ac0af.Count - 1; _0xe0c20fa6 > 0; _0xe0c20fa6--)
        {
            int _0xea9d2e11 = _0xb97cbc2f.Next(0, _0xe0c20fa6 + 1);
            int _0xedec8f0b = this._0x577ac0af[_0xe0c20fa6];
            this._0x577ac0af[_0xe0c20fa6] = this._0x577ac0af[_0xea9d2e11];
            this._0x577ac0af[_0xea9d2e11] = _0xedec8f0b;
        }

        List<int> _0x8fb3489b = new List<int>(_0xbe9a6eed);
        for (int _0x1f849a86 = 0; _0x1f849a86 < _0xbe9a6eed && _0x1f849a86 < this._0x577ac0af.Count; _0x1f849a86++)
            _0x8fb3489b.Add(this._0x577ac0af[_0x1f849a86]);
        return _0x8fb3489b;
    }

    public _0x55c8835b _0x981b6033(System.Random _0xdb038346, float _0xd8483627, Vector2 _0x2ffdae89, float _0x5579cc1f)
    {
        _0x55c8835b _0x1b812b4c = new _0x55c8835b();
        _0x1b812b4c.Centre = _0x2ffdae89;
        _0x1b812b4c.BeaconDiameter = _0x5579cc1f;
        int _0xed7a37fe = _0xdb038346.Next(0, _0x55c8835b.BeaconCount);
        bool _0xf330bd2a = _0xdb038346.Next(0, 2) == 1;
        float _0xc07e554b = (float)(_0xdb038346.NextDouble() * 360.0);
        for (int _0x0d127bd1 = 0; _0x0d127bd1 < 3; _0x0d127bd1++)
        {
            float _0x5eb608f8 = (float)(_0xdb038346.NextDouble() * 0.06 - 0.03);
            _0x1b812b4c.RingRadius[_0x0d127bd1] = Mathf.Clamp(_0x48243533[_0x0d127bd1] + _0x5eb608f8, 0.3f, 0.86f) * _0xd8483627;
        }

        for (int _0xf3423bee = 0; _0xf3423bee < _0x55c8835b.BeaconCount; _0xf3423bee++)
        {
            int _0x27dbe002 = _0xf330bd2a ? (_0x55c8835b.BeaconCount - 1 - _0xf3423bee) : _0xf3423bee;
            _0x1b812b4c.Rings[_0xf3423bee] = _0x32b98a49[(_0x27dbe002 + _0xed7a37fe) % _0x55c8835b.BeaconCount];
            float _0x453d07fe = _0xc07e554b + _0xf3423bee * (360f / _0x55c8835b.BeaconCount);
            _0x1b812b4c.Angles[_0xf3423bee] = _0x453d07fe + (float)(_0xdb038346.NextDouble() * (AngleJitter * 2.0) - AngleJitter);
        }

        return _0x1b812b4c;
    }

    public const float ClearanceFactor = 0.70f;
    private readonly List<int> _0x577ac0af = new List<int>(_0x55c8835b.BeaconCount);
    public const float SeparationFactor = 1.12f;
    private static readonly float[] _0x48243533 =
    {
        0.34f,
        0.56f,
        0.74f
    };
    // Adjacent slots never share a ring, so two beacons can only come close when they
    // sit on the same ring several slots apart - which is far in angle.
    private static readonly int[] _0x32b98a49 =
    {
        0,
        1,
        2,
        0,
        1,
        2,
        1
    };
    // Hit radius for a beacon, and the clearance a link segment must keep from any
    // beacon that is not its endpoint. Clearance stays ABOVE the hit radius, so a
    // finger following the beam can never graze a beacon it did not aim for.
    public const float HitRadiusFactor = 0.52f;
}