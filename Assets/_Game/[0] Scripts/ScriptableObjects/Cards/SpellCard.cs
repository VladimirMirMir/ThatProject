using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Spell", menuName = "ScriptableObject/Card/Spell")]
public class SpellCard : Card
{
    public List<SpellEffect> spellEffects;

    public override void Play()
    {
        foreach (var effect in spellEffects)
            effect.ApplyEffect();
    }
}