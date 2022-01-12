using UnityEngine;

public class NodesManager : MonoBehaviour
{
    private static NodesManager s_instance;

    private Node[] _nodes;

    [SerializeField] private Transform _nodesHolder;

    private void Awake()
    {
        s_instance = this;
    }

    private void Start()
    {
        _nodes = _nodesHolder.GetComponentsInChildren<Node>();
        foreach (var node in _nodes)
        {
            node.DisplayConnections();
        }
    }
}
