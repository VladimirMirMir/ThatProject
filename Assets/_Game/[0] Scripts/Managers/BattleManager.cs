using UnityEngine;
using System.Collections.Generic;

public class BattleManager : MonoBehaviour
{
    private static BattleManager s_instance;

    private static List<ITargetable> s_targets = new List<ITargetable>();

    public static ITargetable Caster { get; set; }
    public static List<ITargetable> Targets => s_targets;

    private void Awake()
    {
        s_instance = this;
    }
}