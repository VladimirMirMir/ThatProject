using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Classic Targetting", menuName = "ScriptableObject/Targetting/Classic")]
public class Classic : Targetting
{
    private void LightUpCellsInRange(int range)
    {
        _localTargets = new List<ITargetable>();
        //BattleManager.GetTargetsFromCasterIn(range);
        //if (onlyEnemies) { ... }
    }

    public override List<ITargetable> GetTargets()
    {
        LightUpCellsInRange(range);
        if (_localTargets.Count > 0)
            return SelectSpecific(_localTargets);
        else
            return null;
    }
}