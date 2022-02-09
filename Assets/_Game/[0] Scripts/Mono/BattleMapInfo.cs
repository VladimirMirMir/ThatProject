using UnityEngine;

public class BattleMapInfo : MonoBehaviour
{
    [SerializeField] private Transform _visualHolder;
    [SerializeField] private int _sizeX = 6;
    [SerializeField] private int _sizeY = 6;

    public bool mustGenerateMap = false;

    public int SizeX => _sizeX;
    public int SizeY => _sizeY;

    public void Init()
    {

    }
}