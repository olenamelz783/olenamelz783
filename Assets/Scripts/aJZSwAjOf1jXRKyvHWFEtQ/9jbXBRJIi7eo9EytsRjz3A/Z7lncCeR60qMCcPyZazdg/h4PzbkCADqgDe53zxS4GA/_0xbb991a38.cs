using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xbb991a38 : MonoBehaviour
{
    public bool IsScaledDownOnAwake = true;
    private void _0xd2a0c4e2()
    {
        if (this.OuterBackground != null)
        {
            Image _0xd3bd2b71 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xd3bd2b71, true);
            _0xd3bd2b71.DOFade(1f, 0f);
        }
    }

    public void _0x9f7aa131()
    {
        this._0xa16d3662();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    private bool _0x043d3c56 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public GameObject OuterBackground;
    public Ease Ease = Ease.OutSine;
    public TMP_Text HeaderText;
    public float ScaleDuration = 0.4f;
    public TMP_Text MainText;
    public GameObject Content;
    public void _0xd7510cdf()
    {
        this._0xd2a0c4e2();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0xc5708f85.Instance._0x6b4728c4(_0xc5708f85.Instance.CurrentPanelIndex);
    }

    private void _0x9f7aa3a0()
    {
        if (this.OuterBackground != null)
        {
            Image _0x36f501aa = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x36f501aa, true);
            _0x36f501aa.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private void _0xcd611572()
    {
        if (this.OuterBackground != null)
        {
            Image _0x87594602 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x87594602, true);
            _0x87594602.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public void Show()
    {
        this._0x9f7aa3a0();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0xc5708f85.Instance._0x6b4728c4(_0xc5708f85.Instance.CurrentPanelIndex);
            });
        }
    }

    private void _0xa16d3662()
    {
        if (this.OuterBackground != null)
        {
            Image _0xa3045821 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xa3045821, true);
            _0xa3045821.DOFade(0f, this.ScaleDuration);
        }
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xcd611572();
    }
}