using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public Transform movetowards;
    public float speed;
    private bool moving = true;


	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, movetowards.position, step);
        }
    }

    public void stopMoving()
    {
        moving = false;
    }
}
