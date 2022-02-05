using System.Collections.Generic;

[System.Serializable]
public class EntityStats
{
    public int healthPoints;
    public int movementPoints;
    public CreatureType creatureType;
    public List<DamageType> vulnerabilities = new List<DamageType>();
    public List<DamageType> resistances = new List<DamageType>();
    public List<DamageType> immunities = new List<DamageType>();
    public List<AbilityData> abilities = new List<AbilityData>();
}