using UnityEngine;

public abstract class Node : MonoBehaviour
{
    public abstract void OnPlayerEnter();
    public abstract void OnPlayerExit();
    public abstract void OnGetVisible();
    public abstract void OnGetInvisible();
}