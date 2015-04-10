using UnityEngine;
using System.Collections;

public class trackingScope : MonoBehaviour {
	Vector3 curVect;
	Vector3 tarVect;
	Vector3 vectorDirection;
	Ray ray;
//	float timeCounted;
	public GameObject bullet;
	// Use this for initialization
	void Start () 
	{
		ray = new Ray (curVect, tarVect);
		vectorDirection = new Vector3 (0, 0, 1);

	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3.MoveTowards (curVect, tarVect, 5);
		RaycastHit hit;
		if (Physics.Raycast(ray,out hit, Mathf.Infinity))
		    {
			if (hit.rigidbody.gameObject.tag == "Player")
			{
				Instantiate(bullet);

			}

			}
	
	}
}
