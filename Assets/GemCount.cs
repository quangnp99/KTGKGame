﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCount : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Score.playerScore += 1;
            Destroy(gameObject);
        }
    }
}
