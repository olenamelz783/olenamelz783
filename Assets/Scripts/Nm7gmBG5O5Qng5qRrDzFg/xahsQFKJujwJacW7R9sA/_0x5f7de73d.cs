using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x5f7de73d : MonoBehaviour
{
    private Vector3 _0x7888fcf9 { get; set; }

    private Color _0x7dda4d47 = Color.white;
    private Vector3 _0xb34c0c59 { get; set; }

    private static _0x5f7de73d _0x7b1d33d7;
    private Vector3 _0x094681a4 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x7dda4d47;
        Matrix4x4 _0x59118134 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x4ccd0d5f.orthographic)
        {
            float _0x2018df85 = this._0x4ccd0d5f.farClipPlane - this._0x4ccd0d5f.nearClipPlane;
            float _0xd54052c7 = (this._0x4ccd0d5f.farClipPlane + this._0x4ccd0d5f.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xd54052c7), new Vector3(this._0x4ccd0d5f.orthographicSize * 2 * this._0x4ccd0d5f.aspect, this._0x4ccd0d5f.orthographicSize * 2, _0x2018df85));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x4ccd0d5f.fieldOfView, this._0x4ccd0d5f.farClipPlane, this._0x4ccd0d5f.nearClipPlane, this._0x4ccd0d5f.aspect);
        }

        Gizmos.matrix = _0x59118134;
    }

    private Vector3 _0xdb23f436 { get; set; }
    private float _0x2c9da6fb { get; set; }
    private Vector3 _0x1f60c051 { get; set; }
    private Vector3 _0x3e87ae04 { get; set; }

    private float _0x2233803b = 1;
    private Vector3 _0xe3224e83 { get; set; }

    public enum _0x1c32775f
    {
        Landscape,
        Portrait
    }

    private Vector3 _0xa7b8d95a { get; set; }

    private void _0x3ac5bf4f()
    {
        float _0xe326212d, _0x5c5604ac, _0xe7eccf3e, _0x7478d73e;
        if (this._0x5b5e5fac == _0x1c32775f.Landscape)
            this._0x4ccd0d5f.orthographicSize = 1f / this._0x4ccd0d5f.aspect * this._0x2233803b / 2f;
        else
            this._0x4ccd0d5f.orthographicSize = this._0x2233803b / 2f;
        this._0x2c9da6fb = 2f * this._0x4ccd0d5f.orthographicSize;
        this._0x933305ce = this._0x2c9da6fb * this._0x4ccd0d5f.aspect;
        float _0x6b547be7 = this._0x4ccd0d5f.transform.position.x;
        float _0xc0437f08 = this._0x4ccd0d5f.transform.position.y;
        _0xe326212d = _0x6b547be7 - this._0x933305ce / 2;
        _0x5c5604ac = _0x6b547be7 + this._0x933305ce / 2;
        _0xe7eccf3e = _0xc0437f08 + this._0x2c9da6fb / 2;
        _0x7478d73e = _0xc0437f08 - this._0x2c9da6fb / 2;
        this._0x7888fcf9 = new Vector3(_0xe326212d, _0x7478d73e, 0);
        this._0xa7b8d95a = new Vector3(_0x6b547be7, _0x7478d73e, 0);
        this._0x3e87ae04 = new Vector3(_0x5c5604ac, _0x7478d73e, 0);
        this._0x1f60c051 = new Vector3(_0xe326212d, _0xc0437f08, 0);
        this._0xdb23f436 = new Vector3(_0x6b547be7, _0xc0437f08, 0);
        this._0xe3224e83 = new Vector3(_0x5c5604ac, _0xc0437f08, 0);
        this._0x094681a4 = new Vector3(_0xe326212d, _0xe7eccf3e, 0);
        this._0x1e090974 = new Vector3(_0x6b547be7, _0xe7eccf3e, 0);
        this._0xb34c0c59 = new Vector3(_0x5c5604ac, _0xe7eccf3e, 0);
    }

    private new Camera _0x4ccd0d5f;
    //public bool executeInUpdate;
    private float _0x933305ce { get; set; }

    private void Awake()
    {
        this._0x4ccd0d5f = this.GetComponent<Camera>();
        _0x7b1d33d7 = this;
        this._0x3ac5bf4f();
    }

    private _0x1c32775f _0x5b5e5fac = _0x1c32775f.Portrait;
    private Vector3 _0x1e090974 { get; set; }
}