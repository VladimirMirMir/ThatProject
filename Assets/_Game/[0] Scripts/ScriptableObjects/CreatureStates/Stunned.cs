using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Creature States/Stunned")]
public class Stunned : CreatureState
{
    public override void ApplyStateEffect(Creature target)
    {
        target.CreatureStats.movementPoints = 0;
        //target.CanUseAbilities = false;
    }
}