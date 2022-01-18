using UnityEngine;
using System.Collections.Generic;

public abstract class Targetting : ScriptableObject
{
    protected List<ITargetable> _localTargets = new List<ITargetable>();

    public int range;
    public int targetsCount;
    public List<CreatureType> specificCreatureTypes = new List<CreatureType>();


    public abstract List<ITargetable> GetTargets();
    protected abstract List<ITargetable> SelectSpecific(List<ITargetable> targets);
}