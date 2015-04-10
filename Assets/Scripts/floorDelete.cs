using UnityEngine;
using System.Collections;

public class floorDelete : MonoBehaviour {

	public float timeAllowed = 2;
	float timeCounted;
	void OnCollisionStay(Collision colliderInfo)
	{
		timeCounted += 1;
		if (timeCounted > timeAllowed)
		{
			GameObject.Destroy(this.gameObject);
		}
	}
}
