using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableClock : MonoBehaviour
{
    [SerializeField] private GameObject clockText;

    public void DisplayClock()
    {
        clockText.SetActive(true);
    }
}
