using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detect : MonoBehaviour {

    public string whattotrigger;

    private bool attacking = false;
    private int tal = 0;

    public movement movementscript;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        tal++;
        if (tal == 1){
            this.gameObject.tag = "NoneCollidable";
        }
        if (attacking)
        {

        }
        Debug.Log("NO TRIGGER" + whattotrigger);
        if(other.tag == whattotrigger)
        {
            attacking = true;
            movementscript.stopMoving(); 
            //Do stuff
            Transform temp_transform = other.gameObject.transform;
            Debug.Log("HIT!");
        }
        
        
    }
}
