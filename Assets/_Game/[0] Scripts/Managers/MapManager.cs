using UnityEngine;

public class MapManager : MonoBehaviour
{
    private static MapManager s_instance;

    [SerializeField] private Transform _travelMapHolder;
    [SerializeField] private Transform _battleMapHolder;

    private void Awake()
    {
        s_instance = this;
    }

    private void Start()
    {
        if (GameManager.Properties.debug && (GameManager.Properties.debuggedTravelMap != null))
            ChangeTravelMapTo(GameManager.Properties.debuggedTravelMap);
    }

    public static void ChangeTravelMapTo(TravelMapInfo travelMap)
    {
        if (s_instance._travelMapHolder.childCount != 0)
            s_instance._travelMapHolder.DeleteChildren();
        SpawnTravelMap(travelMap);
    }

    private static void SpawnTravelMap(TravelMapInfo travelMap)
    {
        var map = Instantiate(travelMap, s_instance._travelMapHolder.position, Quaternion.identity, s_instance._travelMapHolder);
        NodesManager.ChangeNodesHolder(map.NodesHolder);
        NodesManager.SpawnPlayerAtStart(PlayerDeckManager.GetPlayerPawn);
    }

    private static void SpawnBattleMap(BattleMapInfo battleMap)
    {
        var map = Instantiate(battleMap, s_instance._battleMapHolder.position, Quaternion.identity, s_instance._battleMapHolder);
    }

    public static void ChangeBattleMapTo(BattleMapInfo battleMap)
    {
        if (s_instance._battleMapHolder.childCount != 0)
            s_instance._battleMapHolder.DeleteChildren();
        SpawnBattleMap(battleMap);
    }
}