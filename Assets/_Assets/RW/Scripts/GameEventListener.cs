using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] private GameEvent gameEvent;
    [SerializeField] private UnityEvent reponse;

    private void OnEnable()
    {
        gameEvent.RegisterListerner(this);  
    }

    private void OnDisable()
    {
        gameEvent.UnregisterListener(this);
    }

    public void OnEventRaised()
    {
        reponse?.Invoke();   
    }
}
