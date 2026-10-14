using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xddcc2409;

public class _0xf7ac444f : MonoBehaviour
{
    public Transform EnvironmentWithTweensToToggle;
    public void _0xc8ee2e2c()
    {
        _0x571c1e46._0x24d9f9fc = true;
    }

    public Transform Environment;
    public void LoadSceneByIndex(int _0x84f2c1f3)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xedcd7599(_0x84f2c1f3));
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xf7ac444f>();
        this.RootGameObject = GameObject.FindWithTag(_0x9cac9f71._0x0dce8835(new byte[4] { 162, 159, 159, 132 }, 240));
        if (this._0x71ffcadc == _0x09c5101a.SCENE_0)
            this._0x6f710bba(true);
        else
            this._0x6f710bba(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x1bfc2c44>(true).ToList();
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    private static _0x459e7976 GAME_INDEX_SETTINGS(int _0xafd35e55)
    {
        return _0x459e7976.ALL_SCENES_SETTING_SINGLETONS[_0xafd35e55];
    }

    public bool _0x9909bd1b { get; private set; }

    private void _0x0f73eaee(Transform _0xd3e9a271)
    {
        Transform[] _0xe701b0fd = _0xd3e9a271.GetComponentsInChildren<Transform>();
        foreach (Transform _0x6a1a830e in _0xe701b0fd)
            if (_0x6a1a830e != null && DOTween.IsTweening(_0x6a1a830e))
            {
                if (this._0x9909bd1b)
                    DOTween.Play(_0x6a1a830e);
                else
                    DOTween.Pause(_0x6a1a830e);
            }
    }

    public void _0x6f710bba(bool _0x436b98fa)
    {
        this._0x9909bd1b = _0x436b98fa;
        this._0x3c6e0885(!this._0x9909bd1b);
        Physics2D.simulationMode = this._0x9909bd1b ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x0f73eaee(this.EnvironmentWithTweensToToggle);
    }

    private IEnumerator _0xedcd7599(int _0xd5291ddc)
    {
        _0xc5708f85.Instance._0x2f1d0f37(_0xe09069ce.SPLASH);
        AsyncOperation _0x2de57177 = SceneManager.LoadSceneAsync(_0xd5291ddc);
        while (!_0x2de57177.isDone)
            yield return null;
    }

    public int _0x71ffcadc => SceneManager.GetActiveScene().buildIndex;

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public void _0x843628c2()
    {
        foreach (_0x1bfc2c44 _0x143a4039 in this.MoneyCountContainers)
            _0x143a4039._0x93863166();
    }

    public Button DeleteProgressDataButton;
    private IEnumerator _0xd6c6a5ca(string _0xd1485c0b)
    {
        _0xc5708f85.Instance._0x2f1d0f37(_0xe09069ce.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0xd1d72f72 = SceneManager.LoadSceneAsync(_0xd1485c0b);
        while (!_0xd1d72f72.isDone)
            yield return null;
    }

    public static _0x459e7976 _0x571c1e46 => _0x459e7976.ALL_SCENES_SETTING_SINGLETONS[Instance._0x71ffcadc];

    public static _0xf7ac444f Instance;
    public static bool IsAfterLevelComplete;
    private void _0x9efd98c8()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0x09c5101a.SCENE_0);
    }

    public static bool IsAfterLevelFailed = false;
    private void _0x3c6e0885(bool _0xc3e78cac)
    {
        Rigidbody2D[] _0x5f7c278a = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xa37e3cf5 in _0x5f7c278a)
            if (_0xc3e78cac)
                _0xa37e3cf5.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xa37e3cf5.constraints = RigidbodyConstraints2D.None;
    }

    private static void MakeGrid(List<RectTransform> _0xebfecc55, AspectRatioFitter _0x0ff405a0, float _0x23b74243, int _0xc4ee87e2, int _0x4fb82866)
    {
        _0x0ff405a0.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x0ff405a0.aspectRatio = _0x23b74243;
        foreach (RectTransform _0x970c32c6 in _0xebfecc55)
        {
            int _0x3c1ad5f4 = _0x970c32c6.transform.GetSiblingIndex();
            _0x970c32c6.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x3c1ad5f4 % _0xc4ee87e2) * (1f / _0xc4ee87e2), (_0x4fb82866 - (Mathf.FloorToInt((float)_0x3c1ad5f4 / _0xc4ee87e2) % _0x4fb82866 + 1f)) * (1f / _0x4fb82866));
            _0x970c32c6.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x3c1ad5f4 % _0xc4ee87e2 + 1f) * (1f / _0xc4ee87e2), (_0x4fb82866 - Mathf.FloorToInt((float)_0x3c1ad5f4 / _0xc4ee87e2) % _0x4fb82866) * (1f / _0x4fb82866));
            _0x970c32c6.offsetMin = Vector2.zero;
            _0x970c32c6.offsetMax = Vector2.zero;
        }
    }

    public Canvas MainCanvas;
    private static _0x459e7976 _0x7124fab4 => _0x459e7976.ALL_SCENES_SETTING_SINGLETONS[0];

    public void _0xea0754bf()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    public Button ShowResetTutorialButton;
    private void Start()
    {
        if (this._0x71ffcadc != _0x09c5101a.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0x09c5101a.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x571c1e46._0x24d9f9fc = false;
            _0x5e9cfca6.Instance._0x484c05c6();
            _0xc5708f85.Instance._0x2f1d0f37(_0xe09069ce.TUTORIAL0);
        });
    }

    [HideInInspector]
    public List<_0x1bfc2c44> MoneyCountContainers = new();
}

internal static class _0x9cac9f71
{
    internal static string _0x0dce8835(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}