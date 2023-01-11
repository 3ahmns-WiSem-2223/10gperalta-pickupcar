using System.Collections;
using TMPro;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;


public class TimeScore : MonoBehaviour

{
    public TextMeshProUGUI timeText;
    public float time;
    public float timeLoss;
    public GameObject looseText;




    private bool won = false, play;
    private int count;
    private GameObject player1;

   


    private void Start()
    {
        count = 0;
        won = false;
 
    }

    void Update()
    {
        if (time >= 0.0f && !won)
        {
            time -= Time.deltaTime;
        }

        else if (time <= 0.0f && !won)
        {
            looseText.SetActive(true); 
        }

        var ts = TimeSpan.FromSeconds(time);
        timeText.text =  string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);

    }



   
}
