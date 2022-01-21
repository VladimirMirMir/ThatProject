using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Curse Effect", menuName = "ScriptableObject/Ability Effects/Curse Effect")]
public class CurseEffect : AbilityEffect
{
    public DamageData onCastDamage;
    public DamageData onCurseDamage;
    public GameEvent trigger;
    public int delay;

    public override void Affect()
    {
        var go = new GameObject("CurseEffect");
        var timedEffect = go.AddComponent<TimedEffect>();
        timedEffect.Init(
            delay,
            targetting.GetTargets(),
            trigger,
            (List<ITargetable> targets) => 
            {
                foreach (var target in targets)
                    if (target is IDamageable damageable)
                        damageable.TakeDamage(onCastDamage);
            },
            (List<ITargetable> targets) => { },
            (List<ITargetable> targets) => 
            {
                foreach (var target in targets)
                    if (target is IDamageable damageable)
                        damageable.TakeDamage(onCurseDamage);
            });
    }
}