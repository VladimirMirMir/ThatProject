using UnityEngine;

public class CameraRails : MonoBehaviour
{
    [HideInInspector] public AnimationCurve posX;
    [HideInInspector] public AnimationCurve posY;
    [HideInInspector] public AnimationCurve posZ;

    [HideInInspector] public AnimationCurve rotX;
    [HideInInspector] public AnimationCurve rotY;
    [HideInInspector] public AnimationCurve rotZ;
    [HideInInspector] public AnimationCurve rotW;

    private void Awake()
    {
        GenerateCurves();
    }

    private void GenerateCurves()
    {
        Transform[] points = GetComponentsInChildren<Transform>();
        Vector3[] positionPoints = new Vector3[points.Length];
        Quaternion[] rotationPoints = new Quaternion[points.Length];
        for (int i = 0; i < points.Length; i++)
        {
            positionPoints[i] = points[i].position;
            rotationPoints[i] = points[i].rotation;
        }
        CreateCurves(positionPoints, rotationPoints);
    }

    private void CreateCurves(Vector3[] positionPoints, Quaternion[] rotationPoints)
    {
        posX = new AnimationCurve();
        posY = new AnimationCurve();
        posZ = new AnimationCurve();

        rotX = new AnimationCurve();
        rotY = new AnimationCurve();
        rotZ = new AnimationCurve();
        rotW = new AnimationCurve();

        float time = 0f;
        float length = 0f;
        for (int i = 0; i < positionPoints.Length - 1; i++)
        {
            length += Vector3.Distance(positionPoints[i], positionPoints[i + 1]);
        }
        float currentLength = 0f;
        for (int i = 0; i < positionPoints.Length; i++)
        {
            time = currentLength / length;
            if (i < positionPoints.Length - 1)
            {
                currentLength += Vector3.Distance(positionPoints[i], positionPoints[i + 1]);
            }
            posX.AddKey(time, positionPoints[i].x);
            posY.AddKey(time, positionPoints[i].y);
            posZ.AddKey(time, positionPoints[i].z);

            rotX.AddKey(time, rotationPoints[i].x);
            rotY.AddKey(time, rotationPoints[i].y);
            rotZ.AddKey(time, rotationPoints[i].z);
            rotW.AddKey(time, rotationPoints[i].w);
        }
    }

    public Vector3 EvaluatePosition(float time01)
    {
        return new Vector3(posX.Evaluate(time01), posY.Evaluate(time01), posZ.Evaluate(time01));
    }

    public Quaternion EvaluateRotation(float time01)
    {
        return new Quaternion(rotX.Evaluate(time01), rotY.Evaluate(time01), rotZ.Evaluate(time01), rotW.Evaluate(time01));
    }
}