using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour {

    public List<Transform> spawnPositions;
    public List<GameObject> zombies;
    private float time;
	
	// Update is called once per frame
	void Update () {
        if(time>2.5){
            time = 0;
            int spawnPos = Random.Range(0, spawnPositions.Count);
            int zombieNum = Random.Range(0, zombies.Count);
            Instantiate(zombies[zombieNum],spawnPositions[spawnPos]);
        }else{
            time += Time.deltaTime;
        }
	}
}
