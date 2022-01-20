using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Game Event", menuName = "ScriptableObject/Game Event")]
public class GameEvent : ScriptableObject
{
    private List<IGameEventListener> _listeners;

    public void Raise()
    {
        foreach (var listener in _listeners)
            listener.OnEventRaised();
    }

    public void Register(IGameEventListener listener)
    {
        if (!_listeners.Contains(listener))
            _listeners.Add(listener);
    }

    public void Unregister(IGameEventListener listener)
    {
        if (_listeners.Contains(listener))
            _listeners.Remove(listener);
    }
}