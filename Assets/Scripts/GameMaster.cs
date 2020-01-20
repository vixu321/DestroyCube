using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {


	public static int points = 0;

	[Header("Points")]
	public int penaltyForExplosives;
	public int yellowCube;
	public int redCube;

	

	private GameObject mouseMovement;
	
	
	// Update is called once per frame
	void Start(){
	
		mouseMovement = GameObject.Find("SpawnPoint");

	}
	void Update () {

		

		if(Input.GetMouseButtonDown(0)){
			
			mouseMovement.GetComponent<mouseRotation>().enabled = false;	

			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if(Physics.Raycast(ray, out hit)){
				BoxCollider bc = hit.collider as BoxCollider;
				
				if (bc!=null){
					if(bc.tag=="Yellow"){
						points+=yellowCube;
					}else if(bc.tag=="Red"){
						points+=redCube;
					}else if (bc.tag =="Explosives"){
						points+=penaltyForExplosives;
						bc.tag = "explodedCube";
					}

					Destroy(bc.gameObject);				
				}
			}
		}

		mouseMovement.GetComponent<mouseRotation>().enabled = true;

	}
}
