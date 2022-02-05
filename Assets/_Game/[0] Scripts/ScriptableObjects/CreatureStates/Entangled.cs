using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Creature States/Entangled")]
public class Entangled : CreatureState
{
    public override void ApplyStateEffect(Creature target)
    {
        target.CreatureStats.movementPoints = 0;
    }
}