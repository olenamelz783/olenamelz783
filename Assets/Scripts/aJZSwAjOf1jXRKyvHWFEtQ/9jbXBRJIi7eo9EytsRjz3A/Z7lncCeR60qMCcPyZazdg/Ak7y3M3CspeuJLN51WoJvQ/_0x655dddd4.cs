using UnityEngine;
using UnityEngine.UI;

public class _0x655dddd4 : MonoBehaviour
{
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x5e9cfca6.Instance._0xc0bab00f();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x5e9cfca6.Instance._0x484c05c6());
        else
            this.Button.onClick.AddListener(() => _0x5e9cfca6.Instance._0xbcac08a8(this.PopToShowIndex));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public int PopToShowIndex;
    public Button Button;
    public bool IsHideAllPops;
    public bool IsShowLastPop;
}