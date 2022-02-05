using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Creatures In Line Targetting", menuName = "ScriptableObject/Targetting/Creatures In Line")]
public class CreaturesInLine : Targetting
{
    public int lineWidth = 1;
    public int lineLength = 1;

    public override List<ITargetable> GetTargets()
    {
        throw new System.NotImplementedException();
    }
}