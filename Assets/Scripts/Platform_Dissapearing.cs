using UnityEngine;
using System.Collections;

public class Platform_Dissapearing : MonoBehaviour {

	Collider platCollider;

	// Use this for initialization
	void Start () {
		//Gets the collider.
		platCollider = GetComponent<Collider> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//Detects what collides.
	void OnCollisionEnter(Collision collisionInfo)
	{
		//Checks if the object is the Player
		if (collisionInfo.gameObject.name == "Player") 
		{
			//If player, the collider is = to false.
			platCollider.enabled = false;

		}


	}

	void OnCollisionExit(Collision collisionInfo)
	{
		if (collisionInfo.gameObject.name == "Player")
		{
			//When leaves, collider = tp true.
			platCollider.enabled = true;
		}


	}
}