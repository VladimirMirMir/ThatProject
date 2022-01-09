using UnityEngine;
using System.Collections.Generic;

public class DialogueManager : MonoBehaviour
{
    private static DialogueManager s_instance;

    private Queue<DialogueData> _dialogueData = new Queue<DialogueData>();

    private void Awake()
    {
        s_instance = this;
    }
}