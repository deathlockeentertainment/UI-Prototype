using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text timeText;

    // Update is called once per frame
    void Update()
    {
        ClockFunctionality();
    }

    void ClockFunctionality()
    {
        DateTime time = DateTime.Now;
        timeText.text = time.ToString("HH:mm:ss");
    }
}
