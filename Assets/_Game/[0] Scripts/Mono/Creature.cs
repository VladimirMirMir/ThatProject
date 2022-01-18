using UnityEngine;

public class Creature : MonoBehaviour, ITargetable
{
    private string _creatureType;

    public string CreatureType => _creatureType;

    public void Init(CreatureCard card)
    {
        _creatureType = card.creatureStats.creatureType.creatureTypeID;
    }
}