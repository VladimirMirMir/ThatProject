using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Timed Resist Effect", menuName = "ScriptableObject/Ability Data/Ability Effects/Timed Resist Effect")]
public class TimedResistEffect : AbilityEffect
{
    public DamageType type;
    public GameEvent trigger;
    public int duration;

    public override void Affect()
    {
        var go = new GameObject("TimedResistEffect");
        var timedEffect = go.AddComponent<TimedEffect>();
        timedEffect.Init(
            duration, 
            targetting.GetTargets(),
            trigger, 
            (List<ITargetable> targets) => { }, 
            (List<ITargetable> targets) =>
            {
                foreach (var target in targets)
                    if (target is Creature creature)
                        creature.ToggleResistTo(type, true);
            },
            (List<ITargetable> targets) =>
            {
                foreach (var target in targets)
                    if (target is Creature creature)
                        creature.ToggleResistTo(type, false);
            });
    }
}