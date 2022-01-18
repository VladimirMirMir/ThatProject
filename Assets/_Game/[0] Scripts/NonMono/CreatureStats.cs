using System.Collections.Generic;

[System.Serializable]
public class CreatureStats
{
    public int healthPointsMaximum;
    public int movementPoints;
    public CreatureType creatureType;
    public List<DamageType> vulnerabilities = new List<DamageType>();
    public List<DamageType> resistances = new List<DamageType>();
    public List<DamageType> immunities = new List<DamageType>();
}