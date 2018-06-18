using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    public Text pointText;
    public int points = 100;

    void Update()
    {
        pointText.text = "Count: " + points.ToString();
    }

    public void addPoint(int n)
    {
        points += n;
    }
    public void subtactPoint(int n){
        points -= n;
    }

}
