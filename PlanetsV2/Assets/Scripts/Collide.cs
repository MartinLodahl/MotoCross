using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = collision.gameObject.tag;
        Debug.Log(tag);

        if (tag == "Zombi")
        {
            
            GameObject zombie = collision.gameObject;
            zombie.GetComponent<Health>().doDamage(2);
            Destroy(this.gameObject);
        }
    }
    
}
