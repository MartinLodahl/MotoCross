using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0)){
            placeTower();
        }
       
    }

    private void placeTower(){
       GameObject gameManager = GameObject.Find("GameManager");
        GameObject PlantPrefab = gameManager.GetComponent<GameManager>().ClicketBtn.PlantPrefab;

        if(gameManager.GetComponent<GameManager>().buyPlant(20)){
            Instantiate(PlantPrefab, transform.position, Quaternion.identity);
        }

    }
}
