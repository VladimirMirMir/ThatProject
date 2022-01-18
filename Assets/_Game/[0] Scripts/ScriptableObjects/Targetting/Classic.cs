using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Classic Targetting", menuName = "ScriptableObject/Targetting/Classic")]
public class Classic : Targetting
{
    private void LightUpCellsInRange(int range)
    {
        _localTargets = new List<ITargetable>();
        //BattleManager.GetTargetsFromCasterIn(range);
    }

    public override List<ITargetable> GetTargets()
    {
        if (range <= 0)
        {
            var result = new List<ITargetable>();
            result.Add(BattleManager.Caster);
            return result;
        }
        else
        {
            LightUpCellsInRange(range);
            if (_localTargets.Count > 0)
                return SelectSpecific(_localTargets);
            else
                return null;
        }
    }

    protected override List<ITargetable> SelectSpecific(List<ITargetable> targets)
    {
        if (specificCreatureTypes.Count > 0)
        {
            var selected = new List<ITargetable>(targets);
            foreach (var target in selected)
                if (target is Creature)
                    if (!specificCreatureTypes.ContainsTypeWithID(((Creature)target).CreatureType))
                        selected.Remove(target);
            return selected;
        }
        else
        {
            return targets;
        }
    }
}