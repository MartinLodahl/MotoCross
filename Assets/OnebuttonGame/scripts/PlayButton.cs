using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour
{
    public enum Page
    { // your enum type for syate gui
        Restart
    }
    private Page current;
    void Start()
    {
       
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 70, 50, 30), "Reset"))
            Application.LoadLevel(Application.loadedLevel);

    }
}
