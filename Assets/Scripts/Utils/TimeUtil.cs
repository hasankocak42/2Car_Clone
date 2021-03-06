

using UnityEngine;
using System.Collections;
using System;

public class TimeUtil : MonoBehaviour {

    public static string SecondsToHMS(float seconds)
    {
        TimeSpan time = TimeSpan.FromSeconds(seconds);

        //here backslash is must to tell that colon is
        //not the part of format, it just a character that we want in output
        string str = string.Format("{0:D2}:{1:D2}:{2:D2}", time.Hours, time.Minutes, time.Seconds);

        return str;
    }
}
