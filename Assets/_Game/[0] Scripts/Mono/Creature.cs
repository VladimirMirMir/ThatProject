using UnityEngine;

public class Creature : MonoBehaviour, ITargetable
{
    private CreatureStats _creatureStats;

    public string CreatureType => _creatureStats.creatureType.creatureTypeID;

    public void Init(CreatureCard card)
    {
        _creatureStats = card.creatureStats;
    }

    public void ToggleVulnerabilityTo(DamageType type, bool toggle)
    {
        if (toggle)
        {
            if (!_creatureStats.vulnerabilities.Contains(type))
                _creatureStats.vulnerabilities.Add(type);
        }
        else
        {
            if (_creatureStats.vulnerabilities.Contains(type))
                _creatureStats.vulnerabilities.Remove(type);
        }
    }

    public void ToggleResistTo(DamageType type, bool toggle)
    {
        if (toggle)
        {
            if (!_creatureStats.resistances.Contains(type))
                _creatureStats.resistances.Add(type);
        }
        else
        {
            if (_creatureStats.resistances.Contains(type))
                _creatureStats.resistances.Remove(type);
        }
    }

    public void ToggleImmuneTo(DamageType type, bool toggle)
    {
        if (toggle)
        {
            if (!_creatureStats.immunities.Contains(type))
                _creatureStats.immunities.Add(type);
        }
        else
        {
            if (_creatureStats.immunities.Contains(type))
                _creatureStats.immunities.Remove(type);
        }
    }
}