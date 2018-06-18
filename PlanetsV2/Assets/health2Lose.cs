using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health2Lose : MonoBehaviour {
    public int levelToLoad;

    [SerializeField]
    int currentHealth = 5;

    public bool doDamage(int n)
    {
        // Subtract damage from current health
        currentHealth -= n;
        // Destroy if died
        if (currentHealth <= 0)
        {
            StartCoroutine(ChangeLevelAfter5());
        }
        return false;
    }
    IEnumerator ChangeLevelAfter5()
    {
        yield return new WaitForSeconds(0);
        Application.LoadLevel(levelToLoad);
    }
}
