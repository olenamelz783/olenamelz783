using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// The whole round: transmit a route, take the answer, score it, raise the right card.
// Panels and pops are addressed by SETTINGS index; nothing is looked up by name.
public sealed class _0x0527a3fa : MonoBehaviour
{
    private void _0x64306685(int _0xe925a62e)
    {
        if (_0xe925a62e != this._0x3bc03839)
            return;
        this._0x05e0a86f = _0xb491a358.Responding;
        this._0x722124a6 = false;
        this._0x838767fa = 0;
        this._0x28a7b623 = this._0xcf022789.WindowSeconds;
        this._0x6c379ccd = this._0x28a7b623;
        if (this._board != null)
        {
            this._board._0x2f0c6d7f();
            this._board._0xf67221dd(_0xc3a31033.Gold);
            this._board._0xb64c8d36();
        }

        if (this._trail != null)
        {
            this._trail._0x5e493031();
            this._trail._0xf09fe1b7(_0xc3a31033.Beacon);
        }

        if (this._0xc111920d != null)
            this._0xc111920d._0xa2634fb0 = !this._0x31779e68;
        if (this._hud != null)
        {
            this._hud._0xd0e9450a(_0x0554d9c8._0x44d976cc(new byte[9] { 197, 211, 201, 206, 188, 200, 201, 206, 210 }, 156), _0xc3a31033.Gold);
            this._hud._0x3aef17eb(_0x0554d9c8._0x44d976cc(new byte[54] { 249, 239, 252, 250, 157, 251, 239, 242, 240, 157, 233, 245, 248, 157, 254, 242, 239, 248, 157, 233, 245, 239, 242, 232, 250, 245, 183, 233, 245, 248, 157, 255, 248, 252, 254, 242, 243, 238, 157, 144, 157, 233, 252, 237, 238, 157, 234, 242, 239, 246, 157, 233, 242, 242 }, 189));
            this._hud.SetWindow(1f);
            this._hud._0x91031a35(true);
        }
    }

    private readonly List<int> _0x8fcd5a1c = new List<int>(3);
    private readonly _0x57ab8e69 _0x5dec338c = new _0x57ab8e69();
    private void _0x30e2f0d3(int _0x7937c2ff, int _0xea0effb1, bool _0x25ae860c, float _0x0f2d86f4)
    {
        if (_0x7937c2ff != this._0x3bc03839 || this._board == null)
            return;
        if (_0xea0effb1 < 0 || _0xea0effb1 >= this._board._0xa3e3c728.Count)
            return;
        this._board._0xa3e3c728[_0xea0effb1]._0xc8854792(_0x25ae860c, _0x0f2d86f4);
        if (!_0x25ae860c)
            this._board._0xb64c8d36();
    }

    private void Update()
    {
        if (this._0x31779e68 || this._0x05e0a86f != _0xb491a358.Responding)
            return;
        this._0x6c379ccd -= Time.deltaTime;
        if (this._hud != null)
            this._hud.SetWindow(this._0x6c379ccd / Mathf.Max(0.01f, this._0x28a7b623));
        if (this._0x6c379ccd <= 0f)
            this._0x3987d9ee(_0x0554d9c8._0x44d976cc(new byte[12] { 252, 230, 232, 225, 238, 227, 143, 233, 238, 235, 234, 235 }, 175));
    }

    private const float LitSeconds = 0.42f;
    private const int CleanRunForRefund = 3;
    // - building a route -
    private void _0x0d899d4a()
    {
        if (this._0xcf022789 == null)
            return;
        int _0xc5882cfa = this._0xcf022789._0x422d12d5(this._0x366e3020);
        int _0x42fb2aaf = this._0xcf022789._0xd7b8cc18(this._0x366e3020);
        int _0x01100519 = (_0xf3b0ae9c._0x577c14bf * 7919) ^ (this._0x366e3020 * 104729) ^ ((MaxAttempts - this._0x6d6f53e2) * 15485863);
        System.Random _0xd00b1aac = new System.Random(_0x01100519);
        {
#if B_LOGS
            {
                Debug.Log($"[route] mission={_0xf3b0ae9c._0x577c14bf} route={this._0x366e3020} seed={_0x01100519} length={_0xc5882cfa}");
            }
#endif
        }

        Vector2 _0xdaed7d87 = new Vector2(0f, this._0x66c437a4 * 0.07f);
        _0x55c8835b _0xfcd86b70 = null;
        List<int> _0xd2217d30 = null;
        bool _0xd84c5e24 = false;
        for (int _0x1e62661c = 0; _0x1e62661c < 20 && !_0xd84c5e24; _0x1e62661c++)
        {
            _0xfcd86b70 = this._0x5dec338c._0x981b6033(_0xd00b1aac, this._0x22cdb213, _0xdaed7d87, this._0x6ab3d1b5);
            if (!this._0x5dec338c._0x9c58827a(_0xfcd86b70, this._0x22cdb213, this._0x66c437a4))
                continue;
            for (int _0x23ae03ce = 0; _0x23ae03ce < 24; _0x23ae03ce++)
            {
                _0xd2217d30 = this._0x5dec338c._0xfb48c64d(_0xd00b1aac, _0xc5882cfa);
                if (this._0x5dec338c._0x7a77c83a(_0xfcd86b70, _0xd2217d30, this._0x22cdb213))
                {
                    _0xd84c5e24 = true;
                    break;
                }
            }
        }

        if (!_0xd84c5e24)
        {
            _0xfcd86b70 = this._0x5dec338c._0x739521a1(this._0x22cdb213, _0xdaed7d87, this._0x6ab3d1b5);
            _0xd2217d30 = this._0x5dec338c.FallbackRoute(Mathf.Min(_0xc5882cfa, 5));
        }

        this._0x8e29026a = _0xfcd86b70;
        this._0x62584b82 = _0xd2217d30;
        this._0x8fcd5a1c.Clear();
        List<int> _0x2a7913f9 = this._0x5dec338c._0xec76e863(_0xd00b1aac, _0xd2217d30, _0x42fb2aaf);
        for (int _0x06a836bb = 0; _0x06a836bb < _0x2a7913f9.Count; _0x06a836bb++)
            this._0x8fcd5a1c.Add(_0x2a7913f9[_0x06a836bb]);
        if (this._board != null)
            this._board._0xde23faeb(this._0x8e29026a, this._0x22cdb213 * 0.345f);
        this._0xa08ee094();
    }

    private int _0x838767fa;
    private void _0x7d9c64d6(Vector2 _0x927fdc4e)
    {
        if (this._0x05e0a86f != _0xb491a358.Responding || !this._0x722124a6)
            return;
        if (this._trail != null)
            this._trail._0x3bda0b09(_0x927fdc4e);
        this._0xf795bd4a(_0x927fdc4e);
    }

    [SerializeField]
    private _0x9ead1196 _hud;
    private const float PauseReleaseSeconds = 25f;
    private int _0x3bc03839;
    private int _0xe636b14a;
    private void _0x11b9ec40(string _0xff8d8d7d)
    {
        this._0x3bc03839++;
        this._0x05e0a86f = _0xb491a358.Finished;
        if (this._0xc111920d != null)
            this._0xc111920d._0xa2634fb0 = false;
        _0xf3b0ae9c.RecordRun(this._0x16c6428d, this._0x183a63a9);
        _0x5ecf526f _0x713babde = _0x5e9cfca6.Instance._0xf34bf5ec(_0xddcc2409._0x9dbe1dc7.LOSE);
        if (_0x713babde != null && this._pops != null)
        {
            List<string> _0x48c46919 = new List<string>
            {
                _0x0554d9c8._0x44d976cc(new byte[8] { 78, 83, 73, 72, 89, 79, 60, 60 }, 28) + this._0x183a63a9 + _0x0554d9c8._0x44d976cc(new byte[3] { 42, 37, 42 }, 10) + this._0xcf022789.Routes,
                _0x0554d9c8._0x44d976cc(new byte[10] { 98, 96, 96, 118, 113, 98, 96, 122, 3, 3 }, 35) + this._0xfda172ab() + _0x0554d9c8._0x44d976cc(new byte[1] { 14 }, 43),
                _0x0554d9c8._0x44d976cc(new byte[13] { 119, 112, 102, 97, 21, 102, 97, 103, 112, 116, 126, 21, 21 }, 53) + _0xf3b0ae9c._0x5564f4ac,
            };
            this._pops._0xf0c452ef(_0x713babde, _0xddcc2409._0x9dbe1dc7.LOSE, _0xff8d8d7d, _0xc3a31033.Rose, this._0xcf022789.Title + _0x0554d9c8._0x44d976cc(new byte[10] { 64, 55, 37, 46, 52, 64, 36, 33, 50, 43 }, 96), _0x48c46919, _0x0554d9c8._0x44d976cc(new byte[12] { 184, 191, 164, 202, 163, 190, 202, 171, 173, 171, 163, 164 }, 234), () => this._0x2c34f248(), _0x0554d9c8._0x44d976cc(new byte[12] { 57, 58, 56, 48, 91, 47, 52, 91, 54, 62, 53, 46 }, 123), () => this._0x870fd160(), () => this._0x870fd160());
        }

        _0x5e9cfca6.Instance._0xbcac08a8(_0xddcc2409._0x9dbe1dc7.LOSE);
    }

    private int _0x6d6f53e2 = MaxAttempts;
    private _0xb491a358 _0x05e0a86f = _0xb491a358.Booting;
    private float _0x6c379ccd;
    private const float GapSeconds = 0.22f;
    private const float DecoySeconds = 0.30f;
    private void _0xefce9105()
    {
        if (this._0x05e0a86f == _0xb491a358.Finished)
            return;
        this._0x31779e68 = true;
        if (this._0xc111920d != null)
            this._0xc111920d._0xa2634fb0 = false;
        _0xf7ac444f.Instance._0x6f710bba(false);
        _0x5ecf526f _0xab3130b6 = _0x5e9cfca6.Instance._0xf34bf5ec(_0xddcc2409._0x9dbe1dc7.PAUSE);
        if (_0xab3130b6 != null && this._pops != null)
        {
            List<string> _0x2ec1efff = new List<string>
            {
                _0x0554d9c8._0x44d976cc(new byte[7] { 138, 151, 141, 140, 157, 248, 248 }, 216) + Mathf.Min(this._0x366e3020 + 1, this._0xcf022789.Routes) + _0x0554d9c8._0x44d976cc(new byte[3] { 227, 236, 227 }, 195) + this._0xcf022789.Routes,
                _0x0554d9c8._0x44d976cc(new byte[8] { 19, 20, 18, 5, 1, 11, 96, 96 }, 64) + this._0x16c6428d,
                _0x0554d9c8._0x44d976cc(new byte[10] { 167, 165, 165, 179, 180, 167, 165, 191, 198, 198 }, 230) + this._0xfda172ab() + _0x0554d9c8._0x44d976cc(new byte[1] { 164 }, 129),
            };
            this._pops._0xf0c452ef(_0xab3130b6, _0xddcc2409._0x9dbe1dc7.PAUSE, _0x0554d9c8._0x44d976cc(new byte[10] { 132, 153, 137, 130, 159, 235, 131, 142, 135, 143 }, 203), _0xc3a31033.Beacon, _0x0554d9c8._0x44d976cc(new byte[22] { 7, 27, 22, 115, 0, 7, 18, 7, 26, 28, 29, 115, 26, 0, 115, 4, 18, 26, 7, 26, 29, 20 }, 83), _0x2ec1efff, _0x0554d9c8._0x44d976cc(new byte[6] { 66, 85, 67, 69, 93, 85 }, 16), () => this._0x79b2c3df(), _0x0554d9c8._0x44d976cc(new byte[9] { 248, 243, 249, 157, 239, 242, 232, 233, 248 }, 189), () => this._0xb7a8263d(), () => this._0x79b2c3df());
        }

        _0x5e9cfca6.Instance._0xbcac08a8(_0xddcc2409._0x9dbe1dc7.PAUSE);
        int _0xe8dd9930 = this._0x3bc03839;
        DOVirtual.DelayedCall(PauseReleaseSeconds, () =>
        {
            if (this._0x31779e68 && _0xe8dd9930 == this._0x3bc03839)
                this._0x79b2c3df();
        });
    }

    [SerializeField]
    private _0xb63e253a _pops;
    private bool _0x31779e68;
    private float _0x28a7b623 = 1f;
    private void _0x870fd160()
    {
        _0xf7ac444f.Instance._0x6f710bba(true);
        _0xf7ac444f.Instance.LoadSceneByIndex(_0xddcc2409._0x09c5101a.SCENE_0);
    }

    private bool _0x722124a6;
    // - result cards -
    private void _0x53535b13()
    {
        this._0x3bc03839++;
        this._0x05e0a86f = _0xb491a358.Finished;
        if (this._0xc111920d != null)
            this._0xc111920d._0xa2634fb0 = false;
        _0xf3b0ae9c.RecordRun(this._0x16c6428d, this._0x183a63a9);
        _0x5ecf526f _0x85287259 = _0x5e9cfca6.Instance._0xf34bf5ec(_0xddcc2409._0x9dbe1dc7.WIN);
        if (_0x85287259 != null && this._pops != null)
        {
            List<string> _0xb0199600 = new List<string>
            {
                _0x0554d9c8._0x44d976cc(new byte[8] { 62, 35, 57, 56, 41, 63, 76, 76 }, 108) + this._0x183a63a9 + _0x0554d9c8._0x44d976cc(new byte[3] { 82, 93, 82 }, 114) + this._0xcf022789.Routes,
                _0x0554d9c8._0x44d976cc(new byte[10] { 21, 23, 23, 1, 6, 21, 23, 13, 116, 116 }, 84) + this._0xfda172ab() + _0x0554d9c8._0x44d976cc(new byte[1] { 123 }, 94),
                _0x0554d9c8._0x44d976cc(new byte[13] { 65, 70, 80, 87, 35, 80, 87, 81, 70, 66, 72, 35, 35 }, 3) + _0xf3b0ae9c._0x5564f4ac,
            };
            this._pops._0xf0c452ef(_0x85287259, _0xddcc2409._0x9dbe1dc7.WIN, _0x0554d9c8._0x44d976cc(new byte[12] { 121, 100, 116, 127, 98, 22, 122, 121, 117, 125, 115, 114 }, 54), _0xc3a31033.Gold, this._0xcf022789.Title + _0x0554d9c8._0x44d976cc(new byte[10] { 176, 217, 195, 176, 195, 196, 209, 210, 220, 213 }, 144), _0xb0199600, _0x0554d9c8._0x44d976cc(new byte[10] { 1, 10, 23, 27, 111, 0, 29, 13, 6, 27 }, 79), () => this._0x6fb36968(), _0x0554d9c8._0x44d976cc(new byte[12] { 143, 140, 142, 134, 237, 153, 130, 237, 128, 136, 131, 152 }, 205), () => this._0x870fd160(), () => this._0x870fd160());
        }

        _0x5e9cfca6.Instance._0xbcac08a8(_0xddcc2409._0x9dbe1dc7.WIN);
    }

    private void _0x1aaff715(Vector2 _0xbc8aa578)
    {
        if (this._0x05e0a86f != _0xb491a358.Responding || !this._0x722124a6)
            return;
        this._0xf795bd4a(_0xbc8aa578);
        if (this._trail != null && this._0x838767fa > 0)
            this._trail._0x3bda0b09(this._board._0x28b8a48b(this._0x62584b82[this._0x838767fa - 1]));
    }

    private int _0x5c880a4d;
    private void _0x79b2c3df()
    {
        if (!this._0x31779e68)
            return;
        this._0x31779e68 = false;
        _0x5e9cfca6.Instance._0x484c05c6();
        _0xf7ac444f.Instance._0x6f710bba(true);
        if (this._0xc111920d != null)
            this._0xc111920d._0xa2634fb0 = this._0x05e0a86f == _0xb491a358.Responding;
    }

    private float _0x66c437a4 = 5f;
    private void _0x5d648382()
    {
        if (this._hud == null)
            return;
        this._hud.SetRoute(Mathf.Min(this._0x366e3020 + 1, this._0xcf022789.Routes), this._0xcf022789.Routes);
        this._hud._0xc4880c0a(this._0x16c6428d);
        this._hud._0x414f6cf2(this._0xfda172ab());
        this._hud.SetAttempts(Mathf.Max(0, this._0x6d6f53e2));
    }

    private int _0xfda172ab()
    {
        int _0x5f7ead80 = this._0x183a63a9 + this._0xe636b14a;
        if (_0x5f7ead80 <= 0)
            return 100;
        return Mathf.RoundToInt(100f * this._0x183a63a9 / _0x5f7ead80);
    }

    // - answering -
    private void _0xf6940a4b(Vector2 _0x3116aa11)
    {
        if (this._0x05e0a86f != _0xb491a358.Responding)
            return;
        if (!this._0x722124a6)
        {
            bool _0x55055446 = this._board != null && this._board._0x7308fdf7(_0x3116aa11);
            int _0x6fa9d4b3 = this._board != null ? this._board._0xf5380fa5(_0x3116aa11, _0x57ab8e69.HitRadiusFactor) : -1;
            if (!_0x55055446 && _0x6fa9d4b3 < 0)
                return;
            this._0x722124a6 = true;
            if (this._trail != null)
                this._trail._0xa36b3cc1(this._board._0xcbff6a52);
            if (this._board != null)
            {
                this._board._0xb64c8d36();
                this._board._0xf67221dd(_0xc3a31033.Beacon);
                this._board._0xcb9c4c7e(this._board._0xcbff6a52, _0xc3a31033.Beacon);
            }

            if (this._hud != null)
            {
                this._hud._0xd0e9450a(_0x0554d9c8._0x44d976cc(new byte[7] { 182, 179, 180, 177, 179, 180, 189 }, 250), _0xc3a31033.Beacon);
                this._hud._0x3aef17eb(_0x0554d9c8._0x44d976cc(new byte[52] { 79, 65, 65, 84, 36, 67, 75, 77, 74, 67, 36, 41, 36, 86, 65, 69, 71, 76, 36, 80, 76, 65, 36, 70, 65, 69, 71, 75, 74, 87, 14, 77, 74, 36, 80, 76, 65, 36, 75, 86, 64, 65, 86, 36, 80, 76, 65, 93, 36, 72, 77, 80 }, 4));
            }
        }

        this._0xf795bd4a(_0x3116aa11);
    }

    private _0x9a1309ef _0xcf022789;
    private int _0x366e3020;
    private float _0x22cdb213 = 2.25f;
    private Camera _0xeb7c6373;
    private void _0x4403df31()
    {
        if (this._0x05e0a86f == _0xb491a358.Responding || this._0x05e0a86f == _0xb491a358.Transmitting)
            this._0xa08ee094();
    }

    private _0x55c8835b _0x8e29026a;
    private void _0x3987d9ee(string _0x8127fa05)
    {
        this._0x3bc03839++;
        this._0x05e0a86f = _0xb491a358.Missed;
        if (this._0xc111920d != null)
            this._0xc111920d._0xa2634fb0 = false;
        this._0xe636b14a++;
        this._0x16c6428d = 0;
        this._0x5c880a4d = 0;
        this._0x6d6f53e2--;
        if (this._trail != null)
            this._trail._0xf09fe1b7(_0xc3a31033.Rose);
        if (this._board != null)
        {
            this._board._0xd91b830b();
            this._board._0xf67221dd(_0xc3a31033.Rose);
        }

        if (this._hud != null)
        {
            this._hud._0xd0e9450a(_0x8127fa05, _0xc3a31033.Rose);
            this._hud._0x91031a35(false);
        }

        this._0x5d648382();
        if (this._0x6d6f53e2 <= 0)
            DOVirtual.DelayedCall(1.5f, () => this._0x11b9ec40(_0x0554d9c8._0x44d976cc(new byte[11] { 202, 208, 222, 215, 216, 213, 185, 213, 214, 202, 205 }, 153)));
        else
            DOVirtual.DelayedCall(1.6f, () => this._0xa08ee094());
    }

    private enum _0xb491a358
    {
        Booting,
        Transmitting,
        Responding,
        Cleared,
        Missed,
        Finished,
    }

    private _0xbfd67480 _0xc111920d;
    private List<int> _0x62584b82 = new List<int>(_0x55c8835b.BeaconCount);
    [SerializeField]
    private _0xda148a47 _trail;
    [SerializeField]
    private _0x0ae7d38a _board;
    private void _0xa08ee094()
    {
        this._0x3bc03839++;
        int _0x613503c8 = this._0x3bc03839;
        this._0x05e0a86f = _0xb491a358.Transmitting;
        this._0x722124a6 = false;
        this._0x838767fa = 0;
        if (this._0xc111920d != null)
            this._0xc111920d._0xa2634fb0 = false;
        if (this._trail != null)
            this._trail._0x5e493031();
        if (this._board != null)
        {
            this._board._0x2f0c6d7f();
            this._board._0xf67221dd(_0xc3a31033.Cobalt);
        }

        if (this._hud != null)
        {
            this._hud.SetWindow(1f);
            this._hud._0xd0e9450a(_0x0554d9c8._0x44d976cc(new byte[5] { 143, 153, 140, 155, 144 }, 216), _0xc3a31033.Beacon);
            this._hud._0x3aef17eb(_0x0554d9c8._0x44d976cc(new byte[37] { 105, 127, 106, 125, 118, 30, 106, 118, 123, 30, 124, 123, 127, 125, 113, 112, 109, 52, 106, 118, 123, 103, 30, 114, 119, 121, 118, 106, 30, 119, 112, 30, 113, 108, 122, 123, 108 }, 62));
            this._hud._0x91031a35(false);
        }

        float _0x77ba6326 = 0.35f;
        int _0x1936e28e = 0;
        for (int _0x1f8b4b5a = 0; _0x1f8b4b5a < this._0x62584b82.Count; _0x1f8b4b5a++)
        {
            int _0x6fcce04a = this._0x62584b82[_0x1f8b4b5a];
            float _0x1161e251 = _0x77ba6326;
            DOVirtual.DelayedCall(_0x1161e251, () => this._0x30e2f0d3(_0x613503c8, _0x6fcce04a, false, LitSeconds));
            _0x77ba6326 += LitSeconds + GapSeconds;
            if (_0x1936e28e < this._0x8fcd5a1c.Count && _0x1f8b4b5a % 2 == 1)
            {
                int _0x7c6d6e1e = this._0x8fcd5a1c[_0x1936e28e];
                _0x1936e28e++;
                float _0x2fdb5bd5 = _0x77ba6326;
                DOVirtual.DelayedCall(_0x2fdb5bd5, () => this._0x30e2f0d3(_0x613503c8, _0x7c6d6e1e, true, DecoySeconds));
                _0x77ba6326 += DecoySeconds + GapSeconds * 0.6f;
            }
        }

        while (_0x1936e28e < this._0x8fcd5a1c.Count)
        {
            int _0xbae0003b = this._0x8fcd5a1c[_0x1936e28e];
            _0x1936e28e++;
            float _0xd2d56098 = _0x77ba6326;
            DOVirtual.DelayedCall(_0xd2d56098, () => this._0x30e2f0d3(_0x613503c8, _0xbae0003b, true, DecoySeconds));
            _0x77ba6326 += DecoySeconds + GapSeconds * 0.6f;
        }

        DOVirtual.DelayedCall(_0x77ba6326 + 0.25f, () => this._0x64306685(_0x613503c8));
    }

    private void _0x6fb36968()
    {
        int _0x97abcb6a = Mathf.Min(_0xf3b0ae9c._0x577c14bf + 1, _0x9a1309ef._0x79d002e7 - 1);
        _0xf3b0ae9c._0x577c14bf = _0x97abcb6a;
        PlayerPrefs.Save();
        _0xf7ac444f.Instance.LoadSceneByIndex(_0xddcc2409._0x09c5101a.SCENE_1);
    }

    private float _0x6ab3d1b5 = 0.62f;
    private void Start()
    {
        this._0xeb7c6373 = Camera.main;
        if (this._0xeb7c6373 != null)
        {
            this._0x66c437a4 = this._0xeb7c6373.orthographicSize;
            this._0x22cdb213 = this._0x66c437a4 * this._0xeb7c6373.aspect;
        }

        this._0x6ab3d1b5 = this._0x22cdb213 * 0.275f;
        _0x57d17e4b.BlankTutorialPanels();
        Transform _0xc066ffa9 = _0x57d17e4b.PanelBody(_0xddcc2409._0xe09069ce.DEFAULT);
        if (_0xc066ffa9 == null)
            return;
        _0x57d17e4b.ClearPanelBody(_0xc066ffa9);
        // The pointer surface goes in FIRST so every button built after it wins the
        // raycast; the HUD then sits on top of the chart.
        Image _0x19afa6e1 = _0x7a25e7cb.HitLayer(_0xc066ffa9, _0x0554d9c8._0x44d976cc(new byte[13] { 12, 17, 1, 10, 23, 28, 16, 22, 17, 5, 2, 0, 6 }, 67));
        this._0xc111920d = _0x19afa6e1.gameObject.AddComponent<_0xbfd67480>();
        this._0xc111920d._0x32f15483(this._0xeb7c6373, _0x19afa6e1);
        this._0xc111920d.Pressed = _0xa4e90cc0 => this._0xf6940a4b(_0xa4e90cc0);
        this._0xc111920d.Dragged = _0xa4e90cc0 => this._0x7d9c64d6(_0xa4e90cc0);
        this._0xc111920d.Released = _0xa4e90cc0 => this._0x1aaff715(_0xa4e90cc0);
        if (this._hud != null)
        {
            this._hud._0xefe22bb2(_0xc066ffa9);
            this._hud.BackRequested = () => this._0x870fd160();
            this._hud.PauseRequested = () => this._0xefce9105();
            this._hud.ReplayRequested = () => this._0x4403df31();
        }

        if (this._trail != null)
            this._trail._0xce3f3cc9(this._0x6ab3d1b5 * 0.17f);
        this._0xcf022789 = _0x9a1309ef.Row(_0xf3b0ae9c._0x577c14bf);
        this._0x6d6f53e2 = MaxAttempts;
        this._0x5d648382();
        DOVirtual.DelayedCall(1.1f, () => this._0x0d899d4a());
    }

    private void _0x2c34f248()
    {
        _0xf7ac444f.Instance.LoadSceneByIndex(_0xddcc2409._0x09c5101a.SCENE_1);
    }

    private int _0x183a63a9;
    private void _0xf795bd4a(Vector2 _0x145e6d23)
    {
        if (this._board == null || this._0x838767fa >= this._0x62584b82.Count)
            return;
        int _0x461e46d9 = this._board._0xf5380fa5(_0x145e6d23, _0x57ab8e69.HitRadiusFactor);
        if (_0x461e46d9 < 0)
            return;
        if (_0x461e46d9 == this._0x62584b82[this._0x838767fa])
        {
            Vector2 _0x6ea46e5d = this._board._0x28b8a48b(_0x461e46d9);
            this._board._0xa3e3c728[_0x461e46d9]._0xbbd67f0a();
            this._board._0xcb9c4c7e(_0x6ea46e5d, _0xc3a31033.Beacon);
            if (this._trail != null)
                this._trail._0x41dda0e0(_0x6ea46e5d);
            this._0x838767fa++;
            if (this._hud != null)
                this._hud._0xd0e9450a(_0x0554d9c8._0x44d976cc(new byte[7] { 34, 39, 32, 37, 43, 42, 78 }, 110) + this._0x838767fa + _0x0554d9c8._0x44d976cc(new byte[3] { 51, 60, 51 }, 19) + this._0x62584b82.Count, _0xc3a31033.Beacon);
            if (this._0x838767fa >= this._0x62584b82.Count)
                this._0x0974bd86();
            return;
        }

        for (int _0x5991e9bc = 0; _0x5991e9bc < this._0x838767fa; _0x5991e9bc++)
            if (this._0x62584b82[_0x5991e9bc] == _0x461e46d9)
                return;
        this._board._0xa3e3c728[_0x461e46d9]._0x7cf9874e();
        this._0x3987d9ee(_0x0554d9c8._0x44d976cc(new byte[12] { 20, 17, 12, 13, 4, 99, 1, 6, 2, 0, 12, 13 }, 67));
    }

    private int _0x16c6428d;
    private const int MaxAttempts = 3;
    // - scoring -
    private void _0x0974bd86()
    {
        this._0x3bc03839++;
        this._0x05e0a86f = _0xb491a358.Cleared;
        if (this._0xc111920d != null)
            this._0xc111920d._0xa2634fb0 = false;
        this._0x183a63a9++;
        this._0x16c6428d++;
        this._0x5c880a4d++;
        if (this._trail != null)
            this._trail._0xf09fe1b7(_0xc3a31033.Gold);
        if (this._board != null)
        {
            for (int _0x4d0ee3e3 = 0; _0x4d0ee3e3 < this._0x62584b82.Count; _0x4d0ee3e3++)
                this._board._0xa3e3c728[this._0x62584b82[_0x4d0ee3e3]]._0xf8a6a214();
            this._board._0xf67221dd(_0xc3a31033.Gold);
            this._board._0xcb9c4c7e(this._board._0xcbff6a52, _0xc3a31033.Gold);
        }

        if (this._0x5c880a4d >= CleanRunForRefund && this._0x6d6f53e2 < MaxAttempts)
        {
            this._0x6d6f53e2++;
            this._0x5c880a4d = 0;
            if (this._hud != null)
                this._hud._0x38f29288(_0x0554d9c8._0x44d976cc(new byte[35] { 134, 131, 132, 129, 234, 152, 143, 153, 158, 133, 152, 143, 142, 234, 231, 234, 133, 132, 143, 234, 135, 133, 152, 143, 234, 158, 152, 147, 234, 143, 139, 152, 132, 143, 142 }, 202), _0x0554d9c8._0x44d976cc(new byte[54] { 0, 22, 5, 3, 100, 2, 22, 11, 9, 100, 16, 12, 1, 100, 7, 11, 22, 1, 100, 16, 12, 22, 11, 17, 3, 12, 78, 16, 12, 1, 100, 6, 1, 5, 7, 11, 10, 23, 100, 105, 100, 16, 5, 20, 23, 100, 19, 11, 22, 15, 100, 16, 11, 11 }, 68), 2f);
        }

        this._0x366e3020++;
        this._0x5d648382();
        if (this._hud != null)
        {
            this._hud._0xd0e9450a(_0x0554d9c8._0x44d976cc(new byte[6] { 223, 194, 216, 217, 200, 173 }, 141) + this._0x183a63a9 + _0x0554d9c8._0x44d976cc(new byte[8] { 164, 199, 200, 193, 197, 214, 193, 192 }, 132), _0xc3a31033.Gold);
            this._hud._0x91031a35(false);
        }

        if (this._0x366e3020 >= this._0xcf022789.Routes)
            DOVirtual.DelayedCall(1.3f, () => this._0x53535b13());
        else
            DOVirtual.DelayedCall(1.4f, () => this._0x0d899d4a());
    }

    private void _0xb7a8263d()
    {
        this._0x31779e68 = false;
        _0x5e9cfca6.Instance._0x484c05c6();
        _0xf7ac444f.Instance._0x6f710bba(true);
        DOVirtual.DelayedCall(0.45f, () => this._0x11b9ec40(_0x0554d9c8._0x44d976cc(new byte[11] { 17, 12, 22, 23, 6, 99, 6, 13, 7, 6, 7 }, 67)));
    }
}

internal static class _0x0554d9c8
{
    internal static string _0x44d976cc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}