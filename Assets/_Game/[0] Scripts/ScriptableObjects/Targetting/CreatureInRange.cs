using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Creature In Range Targetting", menuName = "ScriptableObject/Targetting/Creature In Range")]
public class CreatureInRange : Targetting
{
    public bool enemy = true;
    public bool friendly = false;

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