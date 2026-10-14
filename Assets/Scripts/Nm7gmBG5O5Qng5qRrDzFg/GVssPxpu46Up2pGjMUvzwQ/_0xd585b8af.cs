using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xd585b8af : MonoBehaviour
{
    private void Update()
    {
        this._0x6af1a37d();
    }

    private void _0x6af1a37d()
    {
        if (this._0x764f8716.canvasRenderer.GetColor() != this._0xe4c5f4c0.canvasRenderer.GetColor())
            this._0xe4c5f4c0.canvasRenderer.SetColor(this._0x764f8716.canvasRenderer.GetColor());
    }

    private TMP_Text _0xe4c5f4c0;
    private Image _0x764f8716;
}