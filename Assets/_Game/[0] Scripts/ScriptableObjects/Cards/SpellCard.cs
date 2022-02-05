using UnityEngine;

[CreateAssetMenu(fileName = "New Spell", menuName = "ScriptableObject/Card/Spell")]
public class SpellCard : Card
{
    public AbilityData spellEffect;

    public override void Play()
    {
        throw new System.NotImplementedException();
    }
}