using UnityEngine;

[CreateAssetMenu(fileName = "New Dash Effect", menuName = "ScriptableObject/Ability Data/Ability Effects/Dash Effect")]
public class DashEffect : AbilityEffect
{
    public DamageData damageToFirstCreature;

    public override void Affect()
    {
        throw new System.NotImplementedException();
    }
}