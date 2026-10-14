using TMPro;
using UnityEngine;

// C.15 / C.2 housekeeping for the panels this game does not dress itself.
// Panels are reached by INDEX through the controller's public list - never by name -
// and they are only emptied of text, never switched off, because the controller
// addresses them positionally.
public static class _0x57d17e4b
{
    private static void BlankPanel(_0xc5708f85 _0x73ad67ab, int _0xedb97aa6)
    {
        if (_0xedb97aa6 < 0 || _0xedb97aa6 >= _0x73ad67ab.Panels.Count)
            return;
        _0xbb991a38 _0x1d2616cb = _0x73ad67ab.Panels[_0xedb97aa6];
        if (_0x1d2616cb == null)
            return;
        TMP_Text[] _0x7fe5deeb = _0x1d2616cb.GetComponentsInChildren<TMP_Text>(true);
        for (int _0x46261158 = 0; _0x46261158 < _0x7fe5deeb.Length; _0x46261158++)
            if (_0x7fe5deeb[_0x46261158] != null)
                _0x7fe5deeb[_0x46261158].text = string.Empty;
    }

    // The scene template carries seven tutorial slots with filler copy. This game
    // explains its gesture on the game screen instead (C.6 minimum), so every slot is
    // blanked before it could ever be raised.
    public static void BlankTutorialPanels()
    {
        _0xc5708f85 _0xef827785 = _0xc5708f85.Instance;
        if (_0xef827785 == null || _0xef827785.Panels == null)
            return;
        BlankPanel(_0xef827785, _0xddcc2409._0xe09069ce.TUTORIAL0);
        BlankPanel(_0xef827785, _0xddcc2409._0xe09069ce.TUTORIAL1);
        BlankPanel(_0xef827785, _0xddcc2409._0xe09069ce.TUTORIAL2);
        BlankPanel(_0xef827785, _0xddcc2409._0xe09069ce.TUTORIAL3);
        BlankPanel(_0xef827785, _0xddcc2409._0xe09069ce.TUTORIAL4);
        BlankPanel(_0xef827785, _0xddcc2409._0xe09069ce.TUTORIAL5);
        BlankPanel(_0xef827785, _0xddcc2409._0xe09069ce.TUTORIAL6);
    }

    public static Transform PanelBody(int _0x6cd3c5de)
    {
        _0xc5708f85 _0xfbb2fceb = _0xc5708f85.Instance;
        if (_0xfbb2fceb == null || _0xfbb2fceb.Panels == null)
            return null;
        if (_0x6cd3c5de < 0 || _0x6cd3c5de >= _0xfbb2fceb.Panels.Count)
            return null;
        _0xbb991a38 _0x18013f79 = _0xfbb2fceb.Panels[_0x6cd3c5de];
        if (_0x18013f79 == null || _0x18013f79.Content == null)
            return null;
        return _0x18013f79.Content.transform;
    }

    // Switches off everything the template put in a panel body so the game can build
    // its own HUD there. Only DIRECT children are touched; the body itself is never
    // disabled, and any branch holding a Pop is left alone.
    public static void ClearPanelBody(Transform _0xaada2ed9)
    {
        if (_0xaada2ed9 == null)
            return;
        for (int _0x249d129c = _0xaada2ed9.childCount - 1; _0x249d129c >= 0; _0x249d129c--)
        {
            Transform _0xbafcb452 = _0xaada2ed9.GetChild(_0x249d129c);
            if (_0xbafcb452 == null)
                continue;
            if (_0xbafcb452.GetComponentInChildren<_0x5ecf526f>(true) != null)
                continue;
            _0xbafcb452.gameObject.SetActive(false);
        }
    }
}