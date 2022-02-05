using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Ability Data/Ability Effects/Add State Effect")]
public class AddStateEffect : AbilityEffect
{
    public CreatureState state;

    public override void Affect()
    {
        throw new System.NotImplementedException();
    }
}