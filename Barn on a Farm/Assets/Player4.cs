﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player4 : MonoBehaviour
{

    int Switch = 0;
    int Winner = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        //Player 1
        if (Input.GetButtonDown("M") && Switch == 0)
        {
            var pos = transform.position;
            pos.x -= 45;
            transform.position = pos;
            pos.y += 20;
            transform.position = pos;
            Switch = 1;
            Winner++;
        }

        else if (Input.GetButtonDown("M") && Switch == 1)
        {
            var pos = transform.position;
            pos.x += 45;
            transform.position = pos;
            pos.y -= 20;
            transform.position = pos;
            Switch = 0;
            Winner++;
        }

        if (Winner >= 50)
        {
            Time.timeScale = 0;
        }

    }
}
