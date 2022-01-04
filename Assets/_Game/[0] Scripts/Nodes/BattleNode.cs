using UnityEngine;

public class BattleNode : Node
{
    [SerializeField] private BattleData _battleData;

    public override void OnGetInvisible()
    {
        //vfx
    }

    public override void OnGetVisible()
    {
        //vfx
    }

    public override void OnPlayerEnter()
    {
        GameManager.BeginBattle(_battleData);
    }

    public override void OnPlayerExit()
    {
        //vfx
    }
}