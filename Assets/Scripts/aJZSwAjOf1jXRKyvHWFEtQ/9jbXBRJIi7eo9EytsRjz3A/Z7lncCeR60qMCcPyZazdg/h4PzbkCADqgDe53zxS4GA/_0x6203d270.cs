using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x6203d270 : MonoBehaviour
{
    public Slider AnimationSlider;
    public float DefaultAnimationTime = 0.4f;
    public GameObject Background;
    public void _0xa4a5ffb8()
    {
        this._0x1f80df39?.Kill();
        this.AnimationSlider.value = _0x84e53a84 ? this.SecondPassSliderValue : 0.05f;
    }

    public float SecondPassSliderValue = 0.5f;
    public GameObject Error;
    public void _0xc1bfadad()
    {
        this._0xa4a5ffb8();
        bool _0x6867e261 = _0x84e53a84;
        this._0x1f80df39 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x0e5765b4 => this.AnimationSlider.value = _0x0e5765b4, _0x6867e261 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x84e53a84 = !_0x84e53a84;
    }

    public static _0x6203d270 Instance;
    public void _0x576e5b21()
    {
        this._0x1f80df39?.Play();
    }

    public void _0x2b7f69e1()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x1f80df39?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x84e53a84 = false;
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xddcc2409._0x09c5101a.SCENE_0 && !_0x84e53a84)
        {
            this._0x82fc4db1();
        }
        else
        {
            this._0xc1bfadad();
        }
    }

    private void _0x82fc4db1()
    {
        this.AnimationSlider.value = 0.05f;
        _0x84e53a84 = !_0x84e53a84;
        this._0x1f80df39 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x0e5765b4 => this.AnimationSlider.value = _0x0e5765b4, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x4b3048ae._0x67672eae?._0x1e9c5836();
        });
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x6203d270>();
    }

    private static bool _0x84e53a84 = false;
    public void _0x1f075bc2()
    {
        this._0x1f80df39?.Pause();
    }

    public GameObject Content;
    private Sequence _0x1f80df39;
    public float FirstAnimationTime = 10.0f;
}