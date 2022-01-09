using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DialogueOption : MonoBehaviour
{
    [SerializeField] private TMP_Text _textBox;
    [SerializeField] private Button _button;

    public void Init(string text, UnityAction callback)
    {
        _textBox.text = text;
        _button.onClick.AddListener(callback);
    }
}