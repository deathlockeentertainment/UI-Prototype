using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text timeText;//gets a handle to the Text Mesh Pro text field

    // Update is called once per frame
    void Update()
    {
        ClockFunctionality();//calls the Clock method every frame
    }

    void ClockFunctionality()
    {
        DateTime time = DateTime.Now; //Gets current time of day
        timeText.text = time.ToString("HH:mm:ss");//formats it to be something we are familiar with
    }
}
