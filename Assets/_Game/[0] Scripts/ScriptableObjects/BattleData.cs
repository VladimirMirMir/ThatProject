using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Battle Data", menuName = "ScriptableObject/Battle Data")]
public class BattleData : ScriptableObject
{
    public HeroData enemyWarlord;
    public List<CreatureCard> enemyCreatures = new List<CreatureCard>();
}