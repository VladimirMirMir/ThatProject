using UnityEngine;

[CreateAssetMenu(fileName = "New Creature", menuName = "ScriptableObject/Card/Creature")]
public class CreatureCard : Card
{
    public EntityStats entityStats;
    public GameObject prefab;

    public override void Play()
    {
        //Get Data.spawnData from GameManager.PointerData
        //if (spawnData != null)
            //var creature = Instantiate(prefab, spawnData.position, spawnData.TowardsEnemy)
    }
}