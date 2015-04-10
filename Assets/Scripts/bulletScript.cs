using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour 
{

	Rigidbody bulletVector;

	void Start () 
	{
		bulletVector = GetComponent<Rigidbody> ();

		bulletVector.AddForce (Vector3.forward * 10, ForceMode.Impulse);
	}

	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "Player") 
		{
			//EndGame Or W/E;

		} else 
		{

		}


	}



}
