using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x434ea2fa : MonoBehaviour
{
    private float _0x0b9d690a = 1.5f;
    private AspectRatioFitter _0xc179ce02;
    private TMP_Text _0x180ea5dc;
    private float _0x46fa725a;
    private List<string> _0x013724dc = new();
    private float _0x135c06ea = 0.6f;
    private void Update()
    {
        int _0x122284cf = 1;
        if (this._0x013724dc.Count > 0)
        {
            string _0x65da6003 = this._0x180ea5dc.text;
            foreach (string _0xfb36256c in this._0x013724dc)
                while (_0x65da6003.Contains(_0xfb36256c))
                    _0x65da6003 = _0x65da6003.Replace(_0xfb36256c, "");
            _0x122284cf = _0x65da6003.Length;
        }
        else
        {
            _0x122284cf = this._0x180ea5dc.text.Length;
        }

        float _0x38034588 = Mathf.Clamp(this._0x46fa725a + this._0x135c06ea * _0x122284cf, this._0x0b9d690a, this._0x94137e92);
        if (!Mathf.Approximately(this._0xc179ce02.aspectRatio, _0x38034588))
            this._0xc179ce02.aspectRatio = _0x38034588;
    }

    private float _0x94137e92 = 4;
}