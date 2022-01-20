using System;
using UnityEngine;
using System.Collections.Generic;

public class TimedEffect : MonoBehaviour, IGameEventListener
{
    private int _duration;
    private List<ITargetable> _targets = new List<ITargetable>();
    private GameEvent _trigger;
    private Action<List<ITargetable>> _onEventRaised;
    private Action<List<ITargetable>> _onDurationEnded;

    public void Init(int duration, List<ITargetable> targets, GameEvent trigger, Action<List<ITargetable>> effect, Action<List<ITargetable>> postEffect)
    {
        _duration = duration;
        _targets = targets;
        _trigger = trigger;
        _onEventRaised = effect;
        _onDurationEnded = postEffect;
        _trigger.Register(this);
    }

    public void OnEventRaised()
    {
        if (_duration <= 0)
        {
            _onDurationEnded?.Invoke(_targets);
            _trigger.Unregister(this);
            Destroy(gameObject);
            return;
        }
        _onEventRaised?.Invoke(_targets);
        _duration--;
    }
}