using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onebutton : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
    public float timeBeforeSpeedUp;

    private float time;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Fire1"))
        {
            time += Time.deltaTime;
            if (time > timeBeforeSpeedUp)
            {
                rb.velocity = -transform.right * (speed * 8);
            }
            else
            {
                rb.velocity = -transform.right * speed;
            }
        }
        else
        {
            time = 0;
        }
    }
}
