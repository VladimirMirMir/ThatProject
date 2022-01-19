using UnityEngine;

[CreateAssetMenu(fileName = "New Heal Effect", menuName = "ScriptableObject/Ability Effects/Heal")]
public class HealEffect : AbilityEffect
{
    public HealData healData;

    public override void Affect()
    {
        BattleManager.Targets = targetting.GetTargets();
        foreach (var target in BattleManager.Targets)
            if (target is IHealable)
                ((IHealable)target).Heal(healData);
    }
}