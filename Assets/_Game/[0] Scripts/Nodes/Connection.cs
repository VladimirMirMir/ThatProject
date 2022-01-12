using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Connection : MonoBehaviour
{
    private LineRenderer _lineRenderer;

    private void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.positionCount = 0;
    }

    public void Init(Vector3 startPos, Vector3 endPos)
    {
        _lineRenderer.positionCount = 2;
        _lineRenderer.SetPosition(0, startPos.WithAdditionalY(0.02f));
        _lineRenderer.SetPosition(1, endPos.WithAdditionalY(0.02f));
        _lineRenderer.alignment = LineAlignment.TransformZ;
    }
}