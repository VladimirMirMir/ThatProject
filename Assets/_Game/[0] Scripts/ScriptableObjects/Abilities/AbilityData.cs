using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Ability", menuName = "ScriptableObject/Ability")]
public class AbilityData : ScriptableObject
{
    public string ability_id;
    public int cooldown = 0;
    public List<AbilityEffect> effects = new List<AbilityEffect>();
}