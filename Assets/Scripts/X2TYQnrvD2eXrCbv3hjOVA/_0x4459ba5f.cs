using DG.Tweening;
using UnityEngine;

// The menu is not a still picture: the same orbit chart turns behind the buttons and a
// random beacon answers every couple of seconds. It is built from the same prefabs as
// the game board, so the two screens read as one world.
public sealed class _0x4459ba5f : MonoBehaviour
{
    private void Update()
    {
        if (!this._0xbf5f232f || this._board == null || this._0x7fab49fa == null)
            return;
        if (Time.time < this._0x10883792)
            return;
        this._0x10883792 = Time.time + Random.Range(1.6f, 2.8f);
        int _0x56706a11 = Random.Range(0, this._board._0xa3e3c728.Count);
        this._board._0xa3e3c728[_0x56706a11]._0xc8854792(false, 0.5f);
        this._board._0xb64c8d36();
    }

    public void _0x2c79c7cf()
    {
        if (this._board == null || this._0x7fab49fa == null)
            return;
        this._board._0xf67221dd(_0xc3a31033.Gold);
        this._board._0xcb9c4c7e(this._board._0xcbff6a52, _0xc3a31033.Gold);
        DOVirtual.DelayedCall(1.2f, () =>
        {
            if (this._board != null)
                this._board._0xf67221dd(_0xc3a31033.Cobalt);
        });
    }

    private _0x55c8835b _0x7fab49fa;
    public void _0xfae49468(bool _0x59f257e2)
    {
        this._0xbf5f232f = _0x59f257e2;
        if (this._board != null)
            this._board.gameObject.SetActive(_0x59f257e2);
    }

    public void _0x7aa3f1d4(float _0x26b77db2, float _0x0514541d)
    {
        if (this._board == null)
            return;
        float _0xdec02f1a = _0x26b77db2 * 0.215f;
        Vector2 _0x3cf16191 = new Vector2(0f, _0x0514541d * 0.2f);
        System.Random _0xdc83b510 = new System.Random(_0xf3b0ae9c._0x577c14bf * 7919 + _0xf3b0ae9c._0x0e1da376 * 31 + 17);
        _0x55c8835b _0x3c303b3c = null;
        for (int _0x36fcd8bc = 0; _0x36fcd8bc < 20; _0x36fcd8bc++)
        {
            _0x3c303b3c = this._0x49bc9255._0x981b6033(_0xdc83b510, _0x26b77db2 * 0.72f, _0x3cf16191, _0xdec02f1a);
            if (this._0x49bc9255._0x9c58827a(_0x3c303b3c, _0x26b77db2, _0x0514541d))
                break;
        }

        if (_0x3c303b3c == null)
            _0x3c303b3c = this._0x49bc9255._0x739521a1(_0x26b77db2 * 0.72f, _0x3cf16191, _0xdec02f1a);
        this._0x7fab49fa = _0x3c303b3c;
        this._board._0xde23faeb(this._0x7fab49fa, _0xdec02f1a * 1.25f);
        this._board._0xf67221dd(_0xc3a31033.Cobalt);
        this._0xfae49468(false);
    }

    [SerializeField]
    private _0x0ae7d38a _board;
    private readonly _0x57ab8e69 _0x49bc9255 = new _0x57ab8e69();
    private bool _0xbf5f232f;
    private float _0x10883792;
}