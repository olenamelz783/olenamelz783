using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xddcc2409;

public class _0x5e9cfca6 : MonoBehaviour
{
    public void _0x484c05c6()
    {
        this.LastPopIndexes.Clear();
        this._0x7235df73();
        foreach (GameObject _0xbe6c690d in this.GameObjectsToHide)
            if (_0xbe6c690d != null)
                _0xbe6c690d.SetActive(true);
        this._0xd29a7965();
    }

    public List<_0x5ecf526f> Pops;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x5ecf526f _0x829338e3 in this.Pops)
            if (_0x829338e3 != null)
                _0x829338e3.gameObject.SetActive(true);
    }

    public List<int> LastPopIndexes = new();
    public List<GameObject> GameObjectsToHide;
    public int CurrentPopIndex;
    public static _0x5e9cfca6 Instance;
    private void _0x039704d8()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public void _0xc0bab00f()
    {
        this.LastPopIndexes.RemoveAll(_0x012e4a87 => _0x012e4a87 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x484c05c6();
        else
            this._0xbcac08a8(this.LastPopIndexes.Last());
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x5e9cfca6>();
    }

    private void _0xd29a7965()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public _0x5ecf526f _0xf34bf5ec(int _0x7a8e68b2)
    {
        return this.Pops[_0x7a8e68b2];
    }

    public float ScaleDuration = 0.4f;
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public void _0xbcac08a8(int _0xb46bd2fd)
    {
        this.CurrentPopIndex = _0xb46bd2fd;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x7235df73(true);
        this._0x039704d8();
        this.Pops[_0xb46bd2fd].Show();
        foreach (GameObject _0xaab36c72 in this.GameObjectsToHide)
            _0xaab36c72.SetActive(false);
    }

    public GameObject BlurBackground;
    private void _0x7235df73(bool _0xa79a83af = false)
    {
        for (int _0xb57a71ea = 0; _0xb57a71ea < this.Pops.Count; ++_0xb57a71ea)
            if (this.Pops[_0xb57a71ea] != null && !(_0xb57a71ea == this.CurrentPopIndex && _0xa79a83af))
                this.Pops[_0xb57a71ea]._0x5ef48581();
    }
}