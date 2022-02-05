using UnityEngine;

[CreateAssetMenu(fileName = "New Revive Effect", menuName = "ScriptableObject/Ability Data/Ability Effects/Revive Effect")]
public class ReviveEffect : AbilityEffect
{
    public int afterDeathHP = 1;
    public CreatureType afterDeathCreatureType;

    public override void Affect()
    {
        throw new System.NotImplementedException();
    }
}