using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Parent Targetting", menuName = "ScriptableObject/Targetting/Parent")]
public class ParentTargetting : Targetting
{
    public override List<ITargetable> GetTargets()
    {
        return BattleManager.Targets;
    }
}