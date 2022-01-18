using UnityEngine;

public class BattleNode : Node
{
    [SerializeField] private BattleData _battleData;

    public override void OnPlayerEnter()
    {
        if (GameManager.Properties.showDebug)
            print("Battle Event Raised!");
        NodesManager.CurrentNode = this;
    }

    public override void OnPlayerExit()
    {
        if (GameManager.Properties.showDebug)
            print("Player 've leaved BattleNode!");
    }
}