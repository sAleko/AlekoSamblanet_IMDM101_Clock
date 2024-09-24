using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    private float hoursToDegrees = -30, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField]
    private Transform hoursPivot, minutesPivot, secondsPivot;
    [SerializeField]
    private bool discrete = true;



    private void Update()
    {
        
        if (discrete)
        {
            var time = DateTime.Now;

            hoursPivot.localRotation =
                Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour);
            minutesPivot.localRotation =
                Quaternion.Euler(0f, 0f, minutesToDegrees * time.Minute);
            secondsPivot.localRotation =
                Quaternion.Euler(0f, 0f, secondsToDegrees * time.Second);
        }
        else
        {
            TimeSpan time = DateTime.Now.TimeOfDay;

            hoursPivot.localRotation =
                Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
            minutesPivot.localRotation =
                Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
            secondsPivot.localRotation =
                Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
        }

    }


}
