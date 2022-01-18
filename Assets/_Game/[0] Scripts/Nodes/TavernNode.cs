using UnityEngine;

public class TavernNode : Node
{
    public override void OnPlayerEnter()
    {
        if (GameManager.Properties.showDebug)
            print("Tavern Event Raised!");
        NodesManager.CurrentNode = this;
    }

    public override void OnPlayerExit()
    {
        if (GameManager.Properties.showDebug)
            print("Player 've leaved TaverNode!");
    }
}