using UnityEngine;

[CreateAssetMenu(fileName = "New Properties", menuName = "ScriptableObject/Game Properties")]
public class GameProperties : ScriptableObject
{
    public Connection connectionPrefab;


    [Header("Debug")]
    public bool debug;
    public TravelMapInfo debuggedTravelMap;
    public BattleMapInfo debuggedBattleMap;
    public PlayerPawn debugPlayerPawnPrefab;

    [Header("Gameplay")]
    public float playerPawnSpeed = 5;
    public float camSpeed = 5;
    public float pawnRotationSpeed = 15f;
    public float pawnLiftHeight = 0.14f;
}