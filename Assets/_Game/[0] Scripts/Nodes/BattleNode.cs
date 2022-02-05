using UnityEngine;

public class BattleNode : Node
{
    [SerializeField] private BattleData _battleData;

    public override void OnPlayerEnter()
    {
        if (GameManager.Properties.debug)
            print("Battle Event Raised!");
        NodesManager.CurrentNode = this;
    }

    public override void OnPlayerExit()
    {
        if (GameManager.Properties.debug)
            print("Player 've leaved BattleNode!");
    }
}