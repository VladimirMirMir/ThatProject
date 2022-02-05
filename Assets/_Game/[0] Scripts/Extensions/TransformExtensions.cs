using UnityEngine;

public static class TransformExtensions
{
    public static void DeleteChildren(this Transform t)
    {
        var count = t.childCount;
        for (int i = count - 1; i >= 0; i--)
            Object.Destroy(t.GetChild(i).gameObject);
    }
}