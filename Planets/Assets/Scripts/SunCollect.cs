﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunCollect : MonoBehaviour {

    public static int score = 100;

    void OnMouseDown()
    {
        // Increase Score
        score += 20;

        // Destroy Sun
        Destroy(gameObject);
    }
}
