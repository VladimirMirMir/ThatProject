using UnityEngine;

public class EnemyAIManager : MonoBehaviour
{
    private static EnemyAIManager s_instance;

    private void Awake()
    {
        s_instance = this;
    }
}