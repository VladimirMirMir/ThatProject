using UnityEngine;

public class DialogueNode : Node
{
    [SerializeField] private DialogueData data;

    public override void OnPlayerEnter()
    {
        if (GameManager.Properties.debug)
            print("Dialogue Event Raised!");
        NodesManager.CurrentNode = this;
    }

    public override void OnPlayerExit()
    {
        if (GameManager.Properties.debug)
            print("Player 've leaved DialogueNode!");
    }
}