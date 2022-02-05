using UnityEngine;

public class TravelMapInfo : MonoBehaviour
{
    [SerializeField] private Transform _visualHolder;
    [SerializeField] private Transform _nodesHolder;

    public Transform NodesHolder => _nodesHolder;
}