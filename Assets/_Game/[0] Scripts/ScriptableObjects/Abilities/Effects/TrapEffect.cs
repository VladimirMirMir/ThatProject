using UnityEngine;

[CreateAssetMenu(fileName = "New Trap Effect", menuName = "ScriptableObject/Ability Data/Ability Effects/Trap Effect")]
public class TrapEffect : AbilityEffect
{
    public AbilityEffect[] effects;

    public override void Affect()
    {
        throw new System.NotImplementedException();
    }
}