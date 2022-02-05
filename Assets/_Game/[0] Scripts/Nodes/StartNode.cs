using UnityEngine;

public class StartNode : Node
{
    public override void OnPlayerEnter()
    {
        NodesManager.CurrentNode = this;
    }

    public override void OnPlayerExit()
    {
        if (GameManager.Properties.debug)
            print("Player 've leaved StartNode!");
    }
}