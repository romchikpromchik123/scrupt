using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float seconds = 60f;
    float minutes = 60f;
    void Update()
    {
        if (seconds > 59)
        {
            minutes++;
            seconds = 0;
        }
        else
        {
            seconds += Time.deltaTime;
        }
        print("время:" + minutes + ":" + seconds);
    }
}