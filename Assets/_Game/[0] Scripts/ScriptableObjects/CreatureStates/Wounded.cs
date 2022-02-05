using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Creature States/Wounded")]
public class Wounded : CreatureState
{
    public override void ApplyStateEffect(Creature target)
    {
        target.CreatureStats.movementPoints /= 2;
    }
}