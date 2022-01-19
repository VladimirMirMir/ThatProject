using UnityEngine;

public abstract class Card : ScriptableObject
{
    public string cardName;
    [Multiline] public string cardLongDescription;
    public string cardJokeDescription;
    public Sprite cardImage;

    public abstract void Play();
}