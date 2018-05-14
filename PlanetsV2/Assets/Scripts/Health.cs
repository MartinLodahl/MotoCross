using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    [SerializeField]
    int currentHealth = 5;

    public bool doDamage(int n)
    {
        // Subtract damage from current health
        currentHealth -= n;

        // Destroy if died
        if (currentHealth <= 0) { 
            Destroy(gameObject);
            return true;
        }
        return false;
    }

}
