using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour {
	//Calling foodPrefab to identify where the food Prefab is therefore we add a public GameOject
	public GameObject foodPrefab;

	//Borders
	//Food is to be spawned within the border parameters, Border variables of type Transform are created
	//Also writing Transform now will allow us to call the variable with just the position : borderTop.position instead of: borderTop.transform.position
	public Transform borderTop;
	public Transform borderBottom;
	public Transform borderLeft;
	public Transform borderRight;

	//Spawning seperate food
	//Position x & y are set as (int) so that food is spawned at positions (1,2,3) rather than (1.2342, 2.384)

	void Spawn()
	{
		//x position between left and right borders (Variables are already set above)
		int x = (int)Random.Range(borderLeft.position.x, borderRight.position.x);

		//y position between top and bottom borders (Variables are already set above)
		int y = (int)Random.Range(borderTop.position.y, borderBottom.position.y);

		//Instantiate the food at position x & y (All borders)
		//Food prefab is set to a default rotation
		Instantiate(foodPrefab, new Vector2(x, y), Quaternion.identity);
	}


	// Use this for initialization
	//The script will call for the Spawn function after some seconds by InvokeRepeating
	void Start () {
		//Food is spawned every 3 seconds starting from 2 seconds
		InvokeRepeating("Spawn", 2, 3);
		
	}
	

}
