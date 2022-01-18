using UnityEngine;

[CreateAssetMenu(fileName = "New Properties", menuName = "ScriptableObject/Game Properties")]
public class GameProperties : ScriptableObject
{
    public bool showDebug;
    public Connection connectionPrefab;

    public GameObject playerPawnPrefab;

    [Header("Gameplay")]
    public float playerPawnSpeed = 5;
    public float camSpeed = 5;
}