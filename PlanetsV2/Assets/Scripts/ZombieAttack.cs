using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour {

    private bool attacking = false;
    private GameObject plant;
    public float time = 0;
    public int damage = 2;

    private void Update()
    {
        if(attacking && time>1){
            time = 0;
            if(plant.GetComponent<Health>().doDamage(damage)){
            }
        } else if(attacking){
            time += Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tagOfObject = collision.gameObject.tag;
        Debug.Log(tagOfObject);

        if (tagOfObject == "Plant")
        {

            plant = collision.gameObject;
            attacking = true;

            //Destroy(this.gameObject);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        attacking = false;
        plant = null;
    }
}
