using UnityEngine;

public class BossNode : Node
{
    public override void OnPlayerEnter()
    {
        if (GameManager.Properties.debug)
            print("Boss Battle Event Raised");
        NodesManager.CurrentNode = this;
    }

    public override void OnPlayerExit()
    {
        if (GameManager.Properties.debug)
            print("Player 've leaved BossNode!");
    }
}