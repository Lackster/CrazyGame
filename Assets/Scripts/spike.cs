using UnityEngine;
using System.Collections;

public class spike : MonoBehaviour {



	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.gameObject.name == "Player")
		{
			Destroy(collisionInfo.gameObject);
		}
	}

}
