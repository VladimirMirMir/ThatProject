using UnityEngine;
using System.Collections.Generic;

public abstract class Node : MonoBehaviour
{
    private Dictionary<Node, bool> _establishedConnection = new Dictionary<Node, bool>();

    public List<Node> connections = new List<Node>();
    public bool IsVisuallyConnectedTo(Node node)
    {
        if (node.IsVisuallyConnectedTo(this))
            return true;
        if (_establishedConnection[node])
            return true;
        return false;
    }

    private void Awake()
    {
        foreach (var node in connections)
            _establishedConnection.Add(node, false);
        DisplayConnections();
    }

    public void DisplayConnections()
    {
        foreach (var node in connections)
        {
            if (!node.IsVisuallyConnectedTo(this))
            {
                var connectionPrefab = Instantiate(GameManager.Properties.connectionPrefab, transform.position, Quaternion.identity);
                connectionPrefab.GetComponent<Connection>().Init(transform.position, node.transform.position);
                _establishedConnection.Add(node, true);
            }
        }
    }

    public abstract void OnPlayerEnter();
    public abstract void OnPlayerExit();
    public abstract void OnGetVisible();
    public abstract void OnGetInvisible();
}