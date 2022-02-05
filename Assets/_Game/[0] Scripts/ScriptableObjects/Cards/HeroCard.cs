using UnityEngine;

[CreateAssetMenu(fileName = "New Hero", menuName = "ScriptableObject/Hero")]
public class HeroCard : Card
{
    public EntityStats heroStats;
    public Hero prefab;
    public PlayerPawn pawn;

    public override void Play()
    {
        throw new System.NotImplementedException();
    }
}