using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class DialogueFrame
{
    public bool activePortraitIsLeft = true;
    public Sprite leftPortrait;
    public Sprite rightPortrait;
    [Multiline] public string speech;
    public List<DialogueChoice> choices = new List<DialogueChoice>();
}