using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private GameObject gameManager; 
    public PlantButton ClicketBtn
    {
        get;
       private set;
    }


    // Use this for initialization
    void Awake()
    {
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void pickPlant(PlantButton plantButton){
        this.ClicketBtn = plantButton;
    }
    public bool buyPlant(int n){
        if (n <= gameManager.GetComponent<Point>().points)
        {
            gameManager.GetComponent<Point>().subtactPoint(n);
            return true;
        }
        else return false;
    }
}
