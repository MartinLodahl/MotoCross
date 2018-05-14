using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunCollect : MonoBehaviour {

    //public static int score;
    public GameObject gameManager;

    private void Awake()
    {
        gameManager = GameObject.FindWithTag("GameManager");
        Debug.Log(gameManager.name);
    }


    void OnMouseDown()
    {
        // Increase Score
        gameManager.GetComponent<Point>().addPoint(20);

        // Destroy Sun
        Destroy(gameObject);
    }
}
