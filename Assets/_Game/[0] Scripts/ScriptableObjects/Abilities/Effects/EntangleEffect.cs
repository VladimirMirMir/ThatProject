using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Entangle Effect", menuName = "ScriptableObject/Ability Effects/Entangle Effect")]
public class EntangleEffect : AbilityEffect
{
    public GameEvent trigger;
    public int duration;

    public override void Affect()
    {
        var go = new GameObject("EntangleEffect");
        var timedEffect = go.AddComponent<TimedEffect>();
        timedEffect.Init(
            duration,
            targetting.GetTargets(),
            trigger,
            (List<ITargetable> targets) => 
            {
                foreach (var target in targets)
                    if (target is Creature creature)
                        creature.ToggleEntangledTo(true);
            },
            (List<ITargetable> targets) => { },
            (List<ITargetable> targets) => 
            {
                foreach (var target in targets)
                    if (target is Creature creature)
                        creature.ToggleEntangledTo(false);
            });
    }
}