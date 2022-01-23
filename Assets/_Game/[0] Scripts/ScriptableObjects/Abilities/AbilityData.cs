using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Ability", menuName = "ScriptableObject/Ability")]
public class AbilityData : ScriptableObject
{
    public string abilityName;
    public int cooldown = 0;
    public Targetting targetting;
    public List<AbilityEffect> effects = new List<AbilityEffect>();
}