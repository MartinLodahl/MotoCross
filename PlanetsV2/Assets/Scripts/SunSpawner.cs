using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunSpawner : MonoBehaviour {

    public GameObject prefab;
    [SerializeField]
    int whenSpawn = 10;
    [SerializeField]
    int oftenSpawn = 10;

	// Use this for initialization
	void Start () {
        // Spawn first Sun in 10 seconds, repeat every 10 seconds
        InvokeRepeating("Spawn", whenSpawn, oftenSpawn);
		
	}
    void Spawn()
    {
        // Load prefab into the Scene
        // -> transform.position means current position
        // -> Quaternion.identity means default rotation
        Instantiate(prefab,
                    transform.position,
                    Quaternion.identity);
    }
}