using UnityEngine;

public abstract class AbilityEffect : ScriptableObject
{
    public Targetting targetting;
    public abstract void Affect();
}