using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Stun Effect", menuName = "ScriptableObject/Ability Effects/Stun Effect")]
public class StunEffect : AbilityEffect
{
    public GameEvent trigger;
    public int duration;

    public override void Affect()
    {
        var go = new GameObject("StunnedEffect");
        var timedEffect = go.AddComponent<TimedEffect>();
        timedEffect.Init(
            duration,
            targetting.GetTargets(),
            trigger,
            (List<ITargetable> targets) => 
            {
                foreach (var target in targets)
                    if (target is Creature creature)
                        creature.ToggleStunedTo(true);
            },
            (List<ITargetable> targets) => { },
            (List<ITargetable> targets) => 
            {
                foreach (var target in targets)
                    if (target is Creature creature)
                        creature.ToggleStunedTo(false);
            });
    }
}