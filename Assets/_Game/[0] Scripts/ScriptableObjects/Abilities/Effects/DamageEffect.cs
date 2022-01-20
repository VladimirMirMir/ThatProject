using UnityEngine;

[CreateAssetMenu(fileName = "New Damage Effect", menuName = "ScriptableObject/Ability Effects/Damage Effect")]
public class DamageEffect : AbilityEffect
{
    public DamageData damage;

    public override void Affect()
    {
        BattleManager.Targets = targetting.GetTargets();
        foreach (var target in BattleManager.Targets)
            if (target is IDamageable damageable)
                damageable.TakeDamage(damage);
    }

    public DamageEffect()
    {
        damage = new DamageData();
    }
}