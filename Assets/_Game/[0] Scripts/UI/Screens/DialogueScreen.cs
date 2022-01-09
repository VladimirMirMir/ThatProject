using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueScreen : UIScreen
{
    [SerializeField] private Image _leftPortrait;
    [SerializeField] private Image _rightPortrait;
    [SerializeField] private TMP_Text _textBox;
    [SerializeField] private DialogueOption _dialogOption1;
    [SerializeField] private DialogueOption _dialogOption2;
    [SerializeField] private DialogueOption _dialogOption3;
    [SerializeField] private DialogueOption _dialogOption4;
}