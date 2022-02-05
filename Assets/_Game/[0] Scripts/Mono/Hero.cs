using UnityEngine;

public class Hero : MonoBehaviour, IHealable, IDamageable, ITargetable
{
    private EntityStats _heroStatsMaximum;
    private EntityStats _heroStats;
    public void Init(HeroCard data)
    {
        _heroStatsMaximum = data.heroStats;
        _heroStats = _heroStatsMaximum;
    }

    public void Heal(HealData data)
    {
        throw new System.NotImplementedException();
    }

    public void TakeDamage(DamageData damageData)
    {
        throw new System.NotImplementedException();
    }
}