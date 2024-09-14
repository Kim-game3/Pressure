using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeScript : MonoBehaviour
{
    private float Limit_Time;
    [SerializeField] TMP_Text Text_Time;
    // Start is called before the first frame update
    void Start()
    {
        Time_Set();
    }

    // Update is called once per frame
    void Update()
    {
        
        Limit_Time -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)Limit_Time);
        Text_Time.text = span.ToString(@"ss");

    }

    void Time_Set()
    {
        if(SceneChange.S_Four)
        {
            Limit_Time = 40.0f;
        }
        else if(SceneChange.S_Three)
        {
            Limit_Time = 30.0f;
        }
        else if(SceneChange.S_Two)
        {
            Limit_Time = 20.0f;
        }
    }
}
