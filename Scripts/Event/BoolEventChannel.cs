using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Events/Bool Event Channel")]
public class BoolEventChannel : ScriptableObject
{
    public Action<bool> OnEventRaised;

    public void RaiseEvent(bool isBool)
    {
        OnEventRaised?.Invoke(isBool);
    }
}