using UnityEngine;

public abstract class Card : ScriptableObject
{
    public string cardName;
    [Multiline] public string cardLongDescription;
    public string cardJokeDescription;
    public Sprite cardImage;

    public void OnValidate()
    {
        cardName = this.name;
    }

    public abstract void Play();
}