using UnityEngine;
using System.Collections.Generic;

public class PlayerDeckManager : MonoBehaviour
{
    private static PlayerDeckManager s_instance;

    private HeroCard _hero;
    private List<Card> _cards = new List<Card>();

    private void Awake()
    {
        s_instance = this;
    }

    public static PlayerPawn GetPlayerPawn
    {
        get
        {
            if (GameManager.Properties.debug)
                return GameManager.Properties.debugPlayerPawnPrefab;
            return s_instance._hero.pawn;
        }
    }
}