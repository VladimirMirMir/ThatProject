using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Self targetting", menuName = "ScriptableObject/Targetting/Self")]
public class SelfTargetting : Targetting
{
    public override List<ITargetable> GetTargets()
    {
        var result = new List<ITargetable>();
        result.Add(BattleManager.Caster);
        return result;
    }

    protected override List<ITargetable> SelectSpecific(List<ITargetable> targets)
    {
        throw new System.NotImplementedException();
    }
}