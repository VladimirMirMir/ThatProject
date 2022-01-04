using UnityEngine;

public abstract class Card : ScriptableObject
{
    public string cardName;
    public string cardDescription;
    public Sprite cardImage;

    public abstract void Play();
}