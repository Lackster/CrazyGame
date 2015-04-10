using UnityEngine;
using System.Collections;

public class turretScript : MonoBehaviour {

	bool inRange;
	GameObject PlayerGame;
	Transform selfTrans;
	public GameObject bullet;
	Vector3 selfVect;
	float LocalTimer;
	// Use this for initialization
	void Start () 
	{
		 selfVect = GetComponent<Vector3> ();
		 selfTrans = GetComponent<Transform> ();
		 PlayerGame = GameObject.FindWithTag ("Player");

	}
	
	// Update is called once per frame
	void Update () 
	{

	
	while (inRange) 
		{
		//float difference = Vector3.Angle(selfVect,targetVect);
		selfTrans.localEulerAngles.Set(selfVect.x,selfVect.y,selfVect.z);
		
			Instantiate(bullet);



		}



	}	

	void OnCollisionEnter(Collision colliderInfo)
	{
		if (colliderInfo.gameObject.tag == "Player") 
		{
			inRange = true;
		}
	}

	void OnCollisionExit(Collision colliderInfo)
	{
		if (colliderInfo.gameObject.tag == "Player") 
		{
			inRange = false;

		}


	}
	
}
