using UnityEngine;
using UnityEngine.UI;

public class _0xee9fc03b : MonoBehaviour
{
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        this.Button.onClick.AddListener(() => _0xf7ac444f.Instance._0x6f710bba(this.IsPhysicsRunOnClick));
    }

    public bool IsPhysicsRunOnClick;
}