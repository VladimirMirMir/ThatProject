using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Periodic Damage Effect", menuName = "ScriptableObject/Ability Data/Ability Effects/Periodic Damage Effect")]
public class PeriodicDamageEffect : AbilityEffect
{
    public DamageData damage;
    public GameEvent trigger;
    public int duration;

    public override void Affect()
    {
        var go = new GameObject("PeriodicDamageEffect");
        var timedEffect = go.AddComponent<TimedEffect>();
        timedEffect.Init(
            duration, 
            targetting.GetTargets(), 
            trigger, 
            (List<ITargetable> targets) => { },
            (List<ITargetable> targets) =>
            {
                foreach (var target in targets)
                    if (target is IDamageable damageable)
                        damageable.TakeDamage(damage);
            }, 
            (List<ITargetable> targets) => { });
    }
}