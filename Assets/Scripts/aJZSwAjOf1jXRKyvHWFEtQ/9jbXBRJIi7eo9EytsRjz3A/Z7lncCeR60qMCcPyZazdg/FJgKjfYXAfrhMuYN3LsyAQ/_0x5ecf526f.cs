using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x5ecf526f : MonoBehaviour
{
    public TMP_Text ContentMainText;
    private void _0xc89e6981()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public void _0x5ef48581()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    private void Start()
    {
    // Content.SetActive(false);
    }

    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public Ease ease = Ease.OutSine;
    private bool _0xd3e02e28 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xc89e6981();
    }

    public bool IsScaledDownOnAwake = true;
    public GameObject Content;
    public bool IsOnlyYScale;
    public static void HideAllPops()
    {
        _0x5e9cfca6.Instance._0x484c05c6();
    }

    public TMP_Text ContentHeaderText;
    public Image ContentImage;
    public float scaleDuration = 0.4f;
    public TMP_Text ContentAdditionalText;
}