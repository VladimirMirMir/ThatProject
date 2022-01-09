using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Dialogue", menuName = "ScriptableObject/Dialogue Data")]
public class DialogueData : ScriptableObject
{
    public List<DialogueFrame> frames = new List<DialogueFrame>();

    public Queue<DialogueFrame> GenerateQueue => new Queue<DialogueFrame>(frames);
}