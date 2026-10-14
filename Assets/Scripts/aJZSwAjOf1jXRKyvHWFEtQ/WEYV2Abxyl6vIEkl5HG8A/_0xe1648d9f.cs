using UnityEngine;

public class _0xe1648d9f : MonoBehaviour
{
    public bool IsOnlyWinGameEndEnabled;
    public bool IsSkipSplashEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xe1648d9f>();
            DontDestroyOnLoad(this.gameObject);
            this._0x7855d45d();
        }
        else
        {
            this._0xf2420394();
            Destroy(this.gameObject);
        }
    }

    public bool IsBestScoreEnabled;
    public static _0xe1648d9f Instance;
    public bool IsTimerEnabled;
    public bool IsLevelSelectorEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsStoryEnabled;
    public bool IsCheckScoreEnabled;
    private void _0x7855d45d()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsTutorialEnabled;
    private void _0xf2420394()
    {
    }
}