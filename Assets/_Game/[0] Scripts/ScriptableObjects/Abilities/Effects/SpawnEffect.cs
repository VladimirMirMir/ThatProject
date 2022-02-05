using UnityEngine;

[CreateAssetMenu(fileName = "New Spawn Effect", menuName = "ScriptableObject/Ability Data/Ability Effects/Spawn Effect")]
public class SpawnEffect : AbilityEffect
{
    public CreatureCard creatureToSpawn;

    public override void Affect()
    {
        throw new System.NotImplementedException();
    }
}