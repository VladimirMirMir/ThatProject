using UnityEngine;

public class TavernNode : Node
{
    public override void OnPlayerEnter()
    {
        if (GameManager.Properties.debug)
            print("Tavern Event Raised!");
        NodesManager.CurrentNode = this;
    }

    public override void OnPlayerExit()
    {
        if (GameManager.Properties.debug)
            print("Player 've leaved TaverNode!");
    }
}