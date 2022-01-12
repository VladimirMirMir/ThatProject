using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(BoxCollider))]
public abstract class Node : MonoBehaviour
{
    private Dictionary<Node, bool> _establishedConnection = new Dictionary<Node, bool>();
    private BoxCollider _collider;

    [SerializeField] private SpriteRenderer _visual;

    public List<Node> connections = new List<Node>();
    public bool IsVisuallyConnectedTo(Node node)
    {
        if (node._establishedConnection.ContainsKey(node))
            if (node._establishedConnection[node])
                return true;
        if (_establishedConnection.ContainsKey(node))
            if (_establishedConnection[node])
                return true;
        return false;
    }

    private void Awake()
    {
        _collider = GetComponent<BoxCollider>();
        _collider.isTrigger = true;
        foreach (var node in connections)
            _establishedConnection.Add(node, false);
    }

    public void DisplayConnections()
    {
        foreach (var node in connections)
        {
            if (!node.IsVisuallyConnectedTo(this))
            {
                Quaternion rot = new Quaternion();
                rot.eulerAngles = new Vector3(90, 0, 0);
                var connectionPrefab = Instantiate(GameManager.Properties.connectionPrefab, transform.position, rot);
                connectionPrefab.Init(transform.position, node.transform.position);
                if (!_establishedConnection.ContainsKey(node))
                    _establishedConnection.Add(node, true);
                else
                    _establishedConnection[node] = true;
            }
        }
    }

    public void OnMouseOver()
    {
        
    }

    public void OnMouseDown()
    {
        
    }

    public abstract void OnPlayerEnter();
    public abstract void OnPlayerExit();
    public abstract void OnGetVisible();
    public abstract void OnGetInvisible();
}