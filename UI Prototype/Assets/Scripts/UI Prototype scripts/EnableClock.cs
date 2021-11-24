using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableClock : MonoBehaviour
{
    [SerializeField] private GameObject clockText; //gets a reference to the Clock text in the inspector

    public void DisplayClock()//enables the clock text (through an event)
    {
        clockText.SetActive(true);
    }
}
