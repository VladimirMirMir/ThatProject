using UnityEngine;

[System.Serializable]
public class DialogueFrame
{
    public bool activePortraitIsLeft = true;
    public Sprite leftPortrait;
    public Sprite rightPortrait;
    [Multiline] public string speech;
}