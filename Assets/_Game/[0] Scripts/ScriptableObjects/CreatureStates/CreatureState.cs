using UnityEngine;

public abstract class CreatureState : ScriptableObject
{
    public GameEvent trigger;

    public abstract void ApplyStateEffect(Creature target);
}