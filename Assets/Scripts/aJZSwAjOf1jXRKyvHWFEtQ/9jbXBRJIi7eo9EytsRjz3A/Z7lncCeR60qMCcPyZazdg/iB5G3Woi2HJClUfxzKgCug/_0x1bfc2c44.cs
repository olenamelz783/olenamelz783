using TMPro;
using UnityEngine;
using static _0xddcc2409;

public class _0x1bfc2c44 : MonoBehaviour
{
    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x371a40b8;
            if (this.gameObject.TryGetComponent(out _0x371a40b8))
                this.MoneyCountText = _0x371a40b8;
        }

        this._0x93863166();
    }

    public void _0x93863166()
    {
        this.MoneyCountText.text = _0x899f8e60._0xa9265fb2.ToString();
    }
}