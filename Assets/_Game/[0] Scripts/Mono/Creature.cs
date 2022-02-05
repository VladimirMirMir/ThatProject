using UnityEngine;
using System.Collections.Generic;

public class Creature : MonoBehaviour, ITargetable, IHealable, IDamageable
{
    private EntityStats _creatureStatsMaximum;
    private EntityStats _creatureStats;
    private List<CreatureState> _activeStates = new List<CreatureState>();

    public string CreatureType => _creatureStatsMaximum.creatureType.creatureTypeID;
    public EntityStats CreatureStats => _creatureStats;

    public void RefreshStats()
    {
        _creatureStats = _creatureStatsMaximum;
    }

    public void AddState(CreatureState state)
    {
        _activeStates.Add(state);
    }

    public void RemoveState(CreatureState state)
    {
        if (_activeStates.Contains(state))
            _activeStates.Remove(state);
    }

    public void ClearStates()
    {
        _activeStates.Clear();
    }

    public void Init(CreatureCard card)
    {
        _creatureStatsMaximum = card.entityStats;
        _creatureStats = _creatureStatsMaximum;
    }

    public void ToggleVulnerabilityTo(DamageType type, bool toggle)
    {
        if (toggle)
        {
            if (!_creatureStatsMaximum.vulnerabilities.Contains(type))
                _creatureStatsMaximum.vulnerabilities.Add(type);
        }
        else
        {
            if (_creatureStatsMaximum.vulnerabilities.Contains(type))
                _creatureStatsMaximum.vulnerabilities.Remove(type);
        }
    }

    public void ToggleResistTo(DamageType type, bool toggle)
    {
        if (toggle)
        {
            if (!_creatureStatsMaximum.resistances.Contains(type))
                _creatureStatsMaximum.resistances.Add(type);
        }
        else
        {
            if (_creatureStatsMaximum.resistances.Contains(type))
                _creatureStatsMaximum.resistances.Remove(type);
        }
    }

    public void ToggleImmuneTo(DamageType type, bool toggle)
    {
        if (toggle)
        {
            if (!_creatureStatsMaximum.immunities.Contains(type))
                _creatureStatsMaximum.immunities.Add(type);
        }
        else
        {
            if (_creatureStatsMaximum.immunities.Contains(type))
                _creatureStatsMaximum.immunities.Remove(type);
        }
    }

    public void Heal(HealData data)
    {
        _creatureStats.healthPoints = Mathf.Clamp(_creatureStats.healthPoints += data.healAmount, 1, _creatureStatsMaximum.healthPoints);
    }

    public void TakeDamage(DamageData damageData)
    {
        var damageAmount = damageData.damageAmount;
        if (_creatureStats.immunities.Contains(damageData.damageType)) damageAmount = 0;
        if (_creatureStats.resistances.Contains(damageData.damageType)) damageAmount /= 2;
        if (_creatureStats.vulnerabilities.Contains(damageData.damageType)) damageAmount *= 2;
        _creatureStats.healthPoints -= damageAmount;
    }
}