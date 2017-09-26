using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// some are Alec Mcclure code below//
public class MONO : MonoBehaviour
{
	public GameObject mover;
	public Vector3 movementAmount;
	public Vector3 movementAmountYZ;
	public Vector3 startingPosition;
	public GameObject winSpot;
	public GameObject resetSpot;
	public GameObject[] enemies; // the enemies can be multiple 
	public 


	// Use this for initialization
	void Start()
	{
		movementAmount = new Vector3(1, 0, 0);
		movementAmountYZ = new Vector3(0, 0, 1);
		startingPosition = mover.transform.position; //the position of the character will be reset to its current location
	}

	// Update is called once per frame
	void Update()
	{
		if (mover.transform.position.z < 0 || //mover won't pass the grid of the bottom
			mover.transform.position.z > 3 ||//mover won't pass the grid top
			mover.transform.position.x < -3 ||//mover won't pass the grid left
			mover.transform.position.x > 4){//mover won't pass the grid right...
			mover.transform.position = startingPosition;
		}

		if (mover.transform.position == 
			new Vector3 (winSpot.transform.position.x,
				mover.transform.position.y,
				winSpot.transform.position.z))
		{
			mover.transform.position = startingPosition;
			new Vector3(resetSpot.transform.position.x,
				mover.transform.position.y,
				resetSpot.transform.position.z);

		}
		for (int i = 0; i < enemies.Length; i++) {

			if (mover.transform.position == enemies[i].transform.position) {// if mover touches red cubes it will reset its position.
			
				mover.transform.position = startingPosition;
			}

			if (enemies[i].transform.position.x > -2) {
				enemies[i].transform.position += new Vector3 (-0.10f, 0, 0);
			} else {
				enemies[i].transform.position = new Vector3 (3, enemies[i].transform.position.y, enemies[i].transform.position.z);
			}

		}


		if (Input.GetKeyDown(KeyCode.D))
		{
			Debug.Log("true");
			mover.transform.position += movementAmount;
		}
		else
		{
			Debug.Log("false");
		}
		//-------------------------//
		if (Input.GetKeyDown(KeyCode.A))
		{
			Debug.Log("true");
			mover.transform.position -= movementAmount;
		}
		else
		{
			Debug.Log("false");
		}
		//--------------------------//
		if (Input.GetKeyDown(KeyCode.W))
		{
			Debug.Log("true");
			mover.transform.position += movementAmountYZ;
		}
		else
		{
			Debug.Log("false");
		}
		//--------------------------//
		if (Input.GetKeyDown(KeyCode.S))
		{
			Debug.Log("true");
			mover.transform.position -= movementAmountYZ;
		}
		else
		{
			Debug.Log("false");
		}
	}
	//void NewLevel(){
		//mover.transform.position = startingPosition;
		//mover.GetComponents<MeshRenderer> ().material.color = new Color(Random.Range(0f,1f), Random.Range(1f,2f) 

			//for (int i = 0; i < enemies.Length; i++) {
				//enemies[i].transform.position = new Vector3 (Random.Range (-2,3), 
	//}
}
