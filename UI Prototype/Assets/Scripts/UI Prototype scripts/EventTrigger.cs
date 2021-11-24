using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent enableClock;//Allows the set up of a cutom unity event through th4e inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))//checks if a game objects "tag" is the Player or not
        {
            enableClock.Invoke();// Calls the event into action
        }
    }
}
