using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Creatures In Square Targetting", menuName = "ScriptableObject/Targetting/Creatures In Square")]
public class CreaturesInSquare : Targetting
{
    public int squareSize = 2;

    public override List<ITargetable> GetTargets()
    {
        targetsCount = squareSize * squareSize;
        throw new System.NotImplementedException();
    }
}