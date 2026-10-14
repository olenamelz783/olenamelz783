using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xddcc2409;

public class _0xc5708f85 : MonoBehaviour
{
    private void _0x672c854a(int _0x2ad4942d)
    {
        this.LastPanelIndexes.Add(_0x2ad4942d);
        this.CurrentPanelIndex = _0x2ad4942d;
        for (int _0x5d9b9813 = 0; _0x5d9b9813 < this.Panels.Count; _0x5d9b9813++)
            if (_0x5d9b9813 != _0x2ad4942d && this.Panels[_0x5d9b9813] != null)
                this.Panels[_0x5d9b9813]._0x9f7aa131();
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public bool IsShowSplashOnStart = true;
    private void _0x4d791c1f(int _0x60cf9e1e)
    {
        if (_0x60cf9e1e == _0xe09069ce.SPLASH)
            _0x6203d270.Instance._0xa4a5ffb8();
        if (_0xf7ac444f.Instance._0x71ffcadc == _0x09c5101a.SCENE_0)
        {
        }
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xc5708f85>();
    }

    public float ScaleDuration = 0.4f;
    public void _0x0943e04e()
    {
        this.LastPanelIndexes.RemoveAll(_0x012e4a87 => _0x012e4a87 == this.CurrentPanelIndex);
        int _0x4d940cc2 = this.LastPanelIndexes.Last();
        this._0x4d791c1f(_0x4d940cc2);
        this._0x1b36f8a2(_0x4d940cc2);
        this.CurrentPanelIndex = _0x4d940cc2;
        this.Panels[_0x4d940cc2].Show();
    }

    public int CurrentPanelIndex;
    public void _0x2f1d0f37(int _0xb5a1f735)
    {
        this._0x672c854a(_0xb5a1f735);
        this._0x4d791c1f(_0xb5a1f735);
        this.CurrentPanelIndex = _0xb5a1f735;
        this.Panels[_0xb5a1f735].Show();
    }

    private void Start()
    {
        this._0xfc5dc0d5();
    }

    private _0xbb991a38 _0x9f85a6ee(int _0x7cb0ea25)
    {
        return this.Panels[_0x7cb0ea25];
    }

    private void _0xbd1d190c(int _0x04d73888)
    {
        this._0x672c854a(_0x04d73888);
        this._0x4d791c1f(_0x04d73888);
        this.CurrentPanelIndex = _0x04d73888;
        this.Panels[_0x04d73888]._0xd7510cdf();
    }

    private void _0xfc5dc0d5()
    {
        this._0xbd1d190c(_0xe09069ce.SPLASH);
        if (_0xf7ac444f.Instance._0x71ffcadc == _0x09c5101a.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x6203d270.Instance.DefaultAnimationTime);
        }
    }

    public void _0x6b4728c4(int _0xeff28134)
    {
        if (_0xeff28134 == _0xe09069ce.SPLASH && _0xf7ac444f.Instance._0x71ffcadc != _0x09c5101a.SCENE_0)
            _0x6203d270.Instance._0xc1bfadad();
        if (_0xf7ac444f.Instance._0x71ffcadc != _0x09c5101a.SCENE_0)
        {
            if (_0xeff28134 == _0xe09069ce.SPLASH || _0xeff28134 == _0xe09069ce.TUTORIAL0)
                _0xf7ac444f.Instance._0x6f710bba(false);
            else if (_0xeff28134 == _0xe09069ce.DEFAULT)
                _0xf7ac444f.Instance._0x6f710bba(true);
        }
    }

    public float StaticBlurMaterialInitialValue;
    public static _0xc5708f85 Instance;
    private void _0x1b36f8a2(int _0x06fad53f)
    {
        this.LastPanelIndexes.Add(_0x06fad53f);
        this.CurrentPanelIndex = _0x06fad53f;
        for (int _0x6899b397 = 0; _0x6899b397 < this.Panels.Count; _0x6899b397++)
            if (_0x6899b397 != _0x06fad53f && this.Panels[_0x6899b397] != null)
                this.Panels[_0x6899b397]._0x9f7aa131();
    }

    private void SwitchSplash()
    {
        if (_0xe1648d9f.Instance.IsTutorialEnabled && !_0xf7ac444f._0x571c1e46._0x24d9f9fc)
            this._0x2f1d0f37(_0xe09069ce.TUTORIAL0);
        else
            this._0x2f1d0f37(_0xe09069ce.DEFAULT);
    }

    public List<_0xbb991a38> Panels;
}