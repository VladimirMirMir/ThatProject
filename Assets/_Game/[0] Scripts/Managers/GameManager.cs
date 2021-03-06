using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager s_instance;

    [SerializeField] private GameProperties _gameProperties;

    public static GameProperties Properties => s_instance._gameProperties;

    private void Awake()
    {
        s_instance = this;
    }
}