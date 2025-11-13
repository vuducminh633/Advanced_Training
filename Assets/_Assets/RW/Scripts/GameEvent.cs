using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Game Event", menuName = "Game Event", order = 52)]
public class GameEvent : ScriptableObject
{
    public List<GameEventListener> listeners = new List<GameEventListener>();

    public void Raise()  // mabe to handle when an event is raised / called
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }
    // make 2 function to redister and un register the event
    public void RegisterListerner(GameEventListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(GameEventListener listener)
    {
        listeners.Remove(listener); 
    }

}

