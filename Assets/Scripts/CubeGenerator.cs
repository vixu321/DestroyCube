using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour {

	public Transform spawnPoint;
	public GameObject[] cube;

	public static int cubesOne, cubesTwo, cubesThree, cubesFour;

	[Header("Cube size")]
	public int horizontalSize;
	public int verticalSize;
	public int depthSize;

	private int horizontal;
	private int vertical;
	private int depth;

	Vector3 spawnPosition = new Vector3(0.0f, 0.0f, 0.0f);
	Vector3 startingSpawnPoint = new Vector3(0f, 0f, 0f);

	void Update(){
	
	}

	void start(){
		Generate();
	}

	public void Generate() {

		for(depth = 0; depth<depthSize; depth++)
		{
				startingSpawnPoint += new Vector3(0f,-depthSize,1f);
				spawnPosition = startingSpawnPoint;
			
			for(vertical = 0; vertical<verticalSize; vertical++)
			{
				startingSpawnPoint += new Vector3(0f,1f,0f);
				spawnPosition = startingSpawnPoint;

				for(horizontal = 0; horizontal<horizontalSize; horizontal++){
					int cubeNumber = Random.Range(0,3);
					switch (cubeNumber){
					case 0: cubesOne += 1; break;
					case 1: cubesTwo += 1; break;
					case 2: cubesThree += 1; break;
					}


					spawnPosition += new Vector3(1.0f, 0.0f, 0.0f);
					spawnPoint.transform.position = spawnPosition;

					Instantiate(cube[cubeNumber], spawnPoint.position, spawnPoint.rotation);
				}
			}
		}
		
		spawnPoint.transform.position = new Vector3(horizontalSize/2 ,-verticalSize/2 ,depthSize/2 );
	}
	}
	

