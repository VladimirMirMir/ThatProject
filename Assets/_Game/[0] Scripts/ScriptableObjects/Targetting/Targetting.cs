using UnityEngine;
using System.Collections.Generic;

public abstract class Targetting : ScriptableObject
{
    protected List<ITargetable> _localTargets = new List<ITargetable>();

    public int range = 1;
    public int targetsCount = 1;
    public bool onlyEnemies = true;
    public List<CreatureType> specificCreatureTypes = new List<CreatureType>();


    public abstract List<ITargetable> GetTargets();
    protected virtual List<ITargetable> SelectSpecific(List<ITargetable> targets)
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