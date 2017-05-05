using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Snake : MonoBehaviour {
	//The snake will move to the right automatically at the speed assigned in the Start function.
	Vector2 dir = Vector2.right;
	List<Transform> tail = new List<Transform>();

	//Snake can either eat or not eat when hitting the foodPrefab element
	//The snake didn't eat anything
	bool ate = false;

	//calling the tail prefab
	public GameObject tailPrefab;



	// Use this for initialization
	void Start () {
		//Move the Snake every 200ms
		InvokeRepeating("Move", 0.2f, 0.2f);
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.RightArrow))
			dir = Vector2.right;
		else if (Input.GetKey(KeyCode.DownArrow))
			dir = -Vector2.up; //-up means down
		else if (Input.GetKey(KeyCode.LeftArrow))
			dir = -Vector2.right; //-right means left
		else if (Input.GetKey(KeyCode.UpArrow))
			dir = Vector2.up;
		
	}
	//controls the way the snake moves to
	void Move()
	{
		//Adding this vector 2 to a position for the snake
		Vector2 v = transform.position;

		//Snake will move to a new direction
		transform.Translate(dir);



		if (tail.Count > 0)
		{
			tail.Last().position = v;

			//Making sure that the last tail element is the first one in the list as well
			tail.Insert(0, tail.Last());
			tail.RemoveAt(tail.Count - 1);

		}
			
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		//Food is called from the foodPrefab after its been instatiated.
		if (coll.name.StartsWith("foodPrefab"))
		{
			ate = true;

			//Eliminate the food from display on collision
			Destroy(coll.gameObject);
		}
		else
		{
			//To 'YOU LOSE' Screen
		}

	}

}
