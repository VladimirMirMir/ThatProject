using UnityEngine;

public static class Vector3Extensions
{
    public static Vector3 WithAdditionalY(this Vector3 vector, float yValue)
    {
        return (vector + new Vector3(0, yValue, 0));
    }

    public static Vector3 WithY(this Vector3 vector, float yValue)
    {
        return new Vector3(vector.x, yValue, vector.z);
    }
}