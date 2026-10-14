using System.Collections.Generic;
using UnityEngine;

// The beam the player draws from the core through the beacons. A LineRenderer keeps
// the beam a single object whatever its length, so there is no stretched sprite whose
// aspect could drift (F.2a).
public sealed class _0xda148a47 : MonoBehaviour
{
    public const int LinkTrailOrder = -10;
    private void _0xaf1c26ad()
    {
        if (this._0x0e934e47 == null)
            return;
        this._0x0e934e47.positionCount = this._0x8dd1b16e.Count;
        for (int _0x8361fc2d = 0; _0x8361fc2d < this._0x8dd1b16e.Count; _0x8361fc2d++)
            this._0x0e934e47.SetPosition(_0x8361fc2d, this._0x8dd1b16e[_0x8361fc2d]);
    }

    public void _0x3bda0b09(Vector2 _0x688107df)
    {
        if (this._0x8dd1b16e.Count == 0)
            return;
        if (this._0x0e934e47 == null)
            return;
        this._0x0e934e47.positionCount = this._0x8dd1b16e.Count + 1;
        for (int _0x88fccf03 = 0; _0x88fccf03 < this._0x8dd1b16e.Count; _0x88fccf03++)
            this._0x0e934e47.SetPosition(_0x88fccf03, this._0x8dd1b16e[_0x88fccf03]);
        this._0x0e934e47.SetPosition(this._0x8dd1b16e.Count, new Vector3(_0x688107df.x, _0x688107df.y, 0.1f));
    }

    public void _0xa36b3cc1(Vector2 _0x252b9fd5)
    {
        this._0x8dd1b16e.Clear();
        this._0x8dd1b16e.Add(new Vector3(_0x252b9fd5.x, _0x252b9fd5.y, 0.1f));
        this._0xaf1c26ad();
    }

    [SerializeField]
    private Material _beamMaterial;
    public void _0x41dda0e0(Vector2 _0xbe85f4d5)
    {
        this._0x8dd1b16e.Add(new Vector3(_0xbe85f4d5.x, _0xbe85f4d5.y, 0.1f));
        this._0xaf1c26ad();
    }

    public void _0xce3f3cc9(float width)
    {
        if (this._0x0e934e47 != null)
            this._0x0e934e47.widthMultiplier = Mathf.Max(0.02f, width);
    }

    private LineRenderer _0x0e934e47;
    public void _0xf09fe1b7(Color _0x0617adf2)
    {
        if (this._0x0e934e47 == null)
            return;
        this._0x0e934e47.startColor = _0xc3a31033.WithAlpha(_0x0617adf2, 0.55f);
        this._0x0e934e47.endColor = _0x0617adf2;
    }

    private void Awake()
    {
        this._0x0e934e47 = this.gameObject.AddComponent<LineRenderer>();
        this._0x0e934e47.useWorldSpace = true;
        this._0x0e934e47.alignment = LineAlignment.View;
        this._0x0e934e47.numCapVertices = 6;
        this._0x0e934e47.numCornerVertices = 6;
        this._0x0e934e47.textureMode = LineTextureMode.Stretch;
        this._0x0e934e47.sortingOrder = LinkTrailOrder;
        if (this._beamMaterial != null)
            this._0x0e934e47.material = this._beamMaterial;
        this._0x0e934e47.positionCount = 0;
        this._0xf09fe1b7(_0xc3a31033.Beacon);
    }

    public void _0x5e493031()
    {
        this._0x8dd1b16e.Clear();
        if (this._0x0e934e47 != null)
            this._0x0e934e47.positionCount = 0;
    }

    private readonly List<Vector3> _0x8dd1b16e = new List<Vector3>(_0x55c8835b.BeaconCount + 1);
}