using UnityEngine;

public class BossNode : Node
{
    public override void OnPlayerEnter()
    {
        if (GameManager.Properties.showDebug)
            print("Boss Battle Event Raised");
        NodesManager.CurrentNode = this;
    }

    public override void OnPlayerExit()
    {
        if (GameManager.Properties.showDebug)
            print("Player 've leaved BossNode!");
    }
}