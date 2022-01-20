using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Timed Immune Effect", menuName = "ScriptableObject/Ability Effects/Timed Immune Effect")]
public class TimedImmuneEffect : AbilityEffect
{
    public DamageType type;
    public GameEvent trigger;
    public int duration;

    public override void Affect()
    {
        var go = new GameObject("TimedImmuneEffect");
        var timedEffect = go.AddComponent<TimedEffect>();
        timedEffect.Init(duration, targetting.GetTargets(), trigger, (List<ITargetable> targets) =>
        {
            foreach (var target in targets)
                if (target is Creature creature)
                    creature.ToggleImmuneTo(type, true);
        },
        (List<ITargetable> targets) =>
        {
            foreach (var target in targets)
                if (target is Creature creature)
                    creature.ToggleImmuneTo(type, false);
        });
    }
}