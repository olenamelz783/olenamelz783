using UnityEngine;
using UnityEngine.UI;

public class _0x34a18244 : MonoBehaviour
{
    private Button _0x6b71dbcc;
    private int _0xb46c346d;
    private void Awake()
    {
        if (this._0x6b71dbcc == null)
            if (!this.TryGetComponent(out this._0x6b71dbcc))
                this._0x6b71dbcc = this.GetComponentInChildren<Button>();
    }

    private bool _0x2dbaf83d;
    private void Start()
    {
        if (this._0x2dbaf83d)
            this._0x6b71dbcc.onClick.AddListener(() => _0xc5708f85.Instance._0x0943e04e());
        else
            this._0x6b71dbcc.onClick.AddListener(() => _0xc5708f85.Instance._0x2f1d0f37(this._0xb46c346d));
    }
}