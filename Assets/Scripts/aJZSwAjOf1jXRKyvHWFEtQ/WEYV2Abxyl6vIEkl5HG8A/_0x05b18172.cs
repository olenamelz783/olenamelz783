using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x05b18172 : MonoBehaviour
{
    public void _0xfc029db1()
    {
        _0xf7ac444f.Instance._0x6f710bba(true);
        _0xf7ac444f.Instance.LoadSceneByIndex(_0xddcc2409._0x09c5101a.SCENE_0);
    }

    public int CustomTimeInitial = 30;
    private void _0x71b0ff28()
    {
        this.IsGameEnd = true;
        _0xf7ac444f.IsAfterLevelComplete = true;
    }

    public List<Button> HomeButtons = new();
    private void _0xa7a72bb1()
    {
        this.TimerText.ForEach(_0x2135fce8 => _0x2135fce8.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x960b25ac._0xd26b963c(new byte[6] { 254, 254, 207, 169, 224, 224 }, 147)));
    }

    [HideInInspector]
    public int CurrentGameIndex;
    public void _0xf3b6549d()
    {
        if (!this.IsGameEnd)
        {
            this._0x71b0ff28();
            _0xf7ac444f.IsAfterLevelComplete = true;
            _0xf7ac444f.IsAfterLevelFailed = false;
            _0x5ecf526f _0xa20e80ec = _0x5e9cfca6.Instance._0xf34bf5ec(_0xddcc2409._0x9dbe1dc7.WIN).GetComponent<_0x5ecf526f>();
            if (_0xe1648d9f.Instance.IsCheckScoreEnabled)
                _0xa20e80ec.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xb64f22fd}";
            else
                _0xa20e80ec.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xe1648d9f.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xddcc2409._0x899f8e60._0xa9265fb2)
                    _0xddcc2409._0x899f8e60._0xa9265fb2 = this.ScoreCurrent;
                _0xa20e80ec.ContentAdditionalText.text = $"{_0xddcc2409._0x899f8e60._0xa9265fb2}";
            }
            else
            {
                _0xa20e80ec.ContentAdditionalText.text = $"{this._0xecc81467}";
                _0xddcc2409._0x899f8e60._0xa9265fb2 += this._0xecc81467;
            }

            if (_0xe1648d9f.Instance.IsLevelIncrementOnWin)
                ++_0xf7ac444f._0x571c1e46._0x6b7258e4;
            _0x5e9cfca6.Instance._0xbcac08a8(_0xddcc2409._0x9dbe1dc7.WIN);
        }
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x545d3818;
        this.CurrentGameIndex = _0xf7ac444f.Instance._0x71ffcadc;
        foreach (Button _0xc6aa4c74 in this.HomeButtons)
            _0xc6aa4c74.onClick.AddListener(() =>
            {
                this._0xfc029db1();
            });
        foreach (Button _0x7f86b1a3 in this.PauseButtons)
            _0x7f86b1a3.onClick.AddListener(() =>
            {
                _0xf7ac444f.Instance._0x6f710bba(false);
                _0x5e9cfca6.Instance._0xbcac08a8(_0xddcc2409._0x9dbe1dc7.PAUSE);
            });
        this._0xf7e97229();
        this.LevelNumberText.ForEach(_0x2135fce8 => _0x2135fce8.text = $"LVL {_0xf7ac444f._0x571c1e46._0x6b7258e4 + 1}");
        if (_0xe1648d9f.Instance.IsTimerEnabled)
        {
            this._0xa7a72bb1();
            this.StartCoroutine(this._0xa0177d71());
        }
    }

    private void Awake()
    {
        _0xbad38f57 = this.gameObject.GetComponent<_0x05b18172>();
    }

    [HideInInspector]
    public int TimeLeft;
    public List<TMP_Text> TimerText = new();
    private int _0xecc81467 => this.ScoreCurrent;

    [HideInInspector]
    public int ScoreCurrent;
    [HideInInspector]
    public bool IsGameEnd;
    public List<TMP_Text> SubtitleText = new();
    public void _0x51918bc9(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xf7e97229();
            this._0x116d0cb0();
        }
    }

    public List<TMP_Text> LevelNumberText = new();
    private IEnumerator _0xa0177d71()
    {
        this._0xa7a72bb1();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0xf7ac444f.Instance._0x71ffcadc == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0xf7ac444f.Instance._0x9909bd1b)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xa7a72bb1();
            }
        }

        if (!this.IsGameEnd)
            this._0x4bd0b76d();
    }

    private int _0x545d3818 => this.CustomTimeInitial + _0xf7ac444f._0x571c1e46._0x6b7258e4 * 10;
    private int _0xb64f22fd => this.CustomTargetScore + _0xf7ac444f._0x571c1e46._0x6b7258e4 * 10;

    public void _0x4bd0b76d()
    {
        if (_0xe1648d9f.Instance.IsOnlyWinGameEndEnabled)
            this._0xf3b6549d();
        if (!this.IsGameEnd)
        {
            this._0x71b0ff28();
            _0xf7ac444f.IsAfterLevelComplete = false;
            _0xf7ac444f.IsAfterLevelFailed = true;
            _0x5ecf526f _0xa4106d22 = _0x5e9cfca6.Instance._0xf34bf5ec(_0xddcc2409._0x9dbe1dc7.LOSE).GetComponent<_0x5ecf526f>();
            if (_0xe1648d9f.Instance.IsCheckScoreEnabled)
                _0xa4106d22.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xb64f22fd}";
            else
                _0xa4106d22.ContentMainText.text = $"{this.ScoreCurrent}";
            _0xa4106d22.ContentAdditionalText.text = $"{0}";
            _0xddcc2409._0x899f8e60._0xa9265fb2 += 0;
            _0x5e9cfca6.Instance._0xbcac08a8(_0xddcc2409._0x9dbe1dc7.LOSE);
        }
    }

    private void _0x116d0cb0()
    {
        if (this.ScoreCurrent > _0xf7ac444f._0x571c1e46._0x9083f820)
            _0xf7ac444f._0x571c1e46._0x9083f820 = this.ScoreCurrent;
        if (_0xe1648d9f.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xb64f22fd)
                this._0xf3b6549d();
    }

    public int CustomTargetScore = 10;
    private void _0xf7e97229()
    {
        if (_0xe1648d9f.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x2135fce8 => _0x2135fce8.text = $"{this.ScoreCurrent}/{this._0xb64f22fd}");
        else
            this.ScoreText.ForEach(_0x2135fce8 => _0x2135fce8.text = $"{this.ScoreCurrent}");
    }

    private void _0x873f84d1()
    {
        if (this.ScoreCurrent >= this._0xb64f22fd)
            this._0xf3b6549d();
        else
            this._0x4bd0b76d();
    }

    public List<Button> PauseButtons = new();
    private static _0x05b18172 _0xbad38f57;
    public List<TMP_Text> ScoreText = new();
}

internal static class _0x960b25ac
{
    internal static string _0xd26b963c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}