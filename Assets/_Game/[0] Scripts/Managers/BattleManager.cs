using UnityEngine;
using System.Collections.Generic;

public class BattleManager : MonoBehaviour
{
    private static BattleManager s_instance;

    public static ITargetable Caster { get; set; }
    public static List<ITargetable> Targets { get; set; }

    private void Awake()
    {
        s_instance = this;
    }

    public static void BeginBattle(BattleData data)
    {

    }
}