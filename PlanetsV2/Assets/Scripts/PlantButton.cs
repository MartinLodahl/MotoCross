﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantButton : MonoBehaviour {
    [SerializeField]
    private GameObject plantPrefab;

    public GameObject PlantPrefab
    {
        get
        {
            return plantPrefab;
        }
    }
}