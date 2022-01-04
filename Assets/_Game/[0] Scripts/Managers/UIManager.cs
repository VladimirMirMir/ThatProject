using UnityEngine;
using System.Collections.Generic;

public class UIManager : MonoBehaviour
{
    private static UIManager s_instance;

    [SerializeField] private List<UIScreen> _screens;

    private void Awake()
    {
        s_instance = this;
    }

    public static T GetScreen<T>() where T : UIScreen
    {
        foreach (var screen in s_instance._screens)
            if (screen is T)
                return (T)screen;
        return null;
    }

    public static void HideAllScreens()
    {
        foreach (var screen in s_instance._screens)
            screen.gameObject.SetActive(false);
    }

    public static void LightUpScreen<T>() where T : UIScreen
    {
        var screen = GetScreen<T>();
        if (screen != null)
        {
            HideAllScreens();
            screen.gameObject.SetActive(true);
        }
    }

    public static void ShowScreenAdditively<T>() where T : UIScreen
    {
        var screen = GetScreen<T>();
        if (screen != null)
            if (!screen.gameObject.activeSelf)
            {
                screen.gameObject.SetActive(true);
                screen.transform.SetAsLastSibling();
            }
    }
}