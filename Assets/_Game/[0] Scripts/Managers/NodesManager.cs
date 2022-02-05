using UnityEngine;

public class NodesManager : MonoBehaviour
{
    private static NodesManager s_instance;

    private Node[] _nodes;
    private Node _currentNode = null;

    [SerializeField] private Transform _connectionsParent;

    public static Transform ConnectionsParent => s_instance._connectionsParent;
    public static Node CurrentNode { get => s_instance._currentNode; set => s_instance._currentNode = value; }

    private void Awake()
    {
        s_instance = this;
    }

    public static void SpawnPlayerAtStart(PlayerPawn playerPawnPrefab)
    {
        var startNode = FindNodeTypeOf<StartNode>();
        if (startNode != null)
        {
            var pawn = Instantiate(playerPawnPrefab, startNode.transform.position, Quaternion.identity);
            s_instance._currentNode = startNode;
        }
        else if (GameManager.Properties.debug)
                Debug.LogError("There is no StartNode at the map!");
    }

    public static void ChangeNodesHolder(Transform nodesHolder)
    {
        if (s_instance._connectionsParent.childCount > 0)
            ClearConnectionsVisual();
        s_instance._nodes = nodesHolder.GetComponentsInChildren<Node>();
        foreach (var node in s_instance._nodes)
            node.DisplayConnections();
    }

    private static void ClearConnectionsVisual()
    {
        s_instance._connectionsParent.DeleteChildren();
    }

    public static void SelectNode(Node node)
    {
        if (s_instance._currentNode.connections.Contains(node))
            PlayerPawn.MoveTo(node);
        else
            if (GameManager.Properties.debug)
            Debug.Log("No reach for this Node!");
    }

    private static T FindNodeTypeOf<T>() where T : Node
    {
        foreach (var node in s_instance._nodes)
            if (node is T)
                return (T)node;
        return null;
    }
}
