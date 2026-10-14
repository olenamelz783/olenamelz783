using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xf5665cf8 : MonoBehaviour
{
    public bool IsLoadCurrentScene;
    public int LoadSceneId;
    public Button Button;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0xf7ac444f.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0xf7ac444f.Instance.LoadSceneByIndex(this.LoadSceneId));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}