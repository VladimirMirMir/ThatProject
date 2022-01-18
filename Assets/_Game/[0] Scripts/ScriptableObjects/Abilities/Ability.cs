using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Ability", menuName = "ScriptableObject/Ability")]
public class Ability : ScriptableObject
{
    public int cooldown = 0;
    public int range = 1;
    public List<AbilityEffect> effects = new List<AbilityEffect>();
}