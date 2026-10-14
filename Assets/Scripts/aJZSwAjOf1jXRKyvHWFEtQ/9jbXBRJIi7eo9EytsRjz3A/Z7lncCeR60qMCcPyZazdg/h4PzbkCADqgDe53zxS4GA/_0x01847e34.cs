using UnityEngine;
using UnityEngine.UI;

public class _0x01847e34 : MonoBehaviour
{
    public bool IsTutorialEndPanel;
    public int EndTutorialPanelIndex = 1;
    public Button TutorialEndButton;
    public int NextTutorialPanelIndex;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xc5708f85.Instance._0x2f1d0f37(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0xf7ac444f.Instance._0xc8ee2e2c());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xc5708f85.Instance._0x2f1d0f37(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0xc5708f85.Instance._0x2f1d0f37(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0xf7ac444f.Instance._0xc8ee2e2c());
        }
    }

    public Button NextTutorialButton;
}