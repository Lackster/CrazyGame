using UnityEngine;
using System.Collections;

public class morphPlatform : MonoBehaviour {

	Vector3 curVect;
	Transform curTransform;
	public float xVarOn;
	public float yVarOn;
	public float xVarOff;
	public float yVarOff;

	void Start () 
	{
		curTransform = GetComponent<Transform> ();
	}

	void OnCollisionEnter(Collision collider)
	{
	
		curTransform.localScale = new Vector3 (xVarOn, yVarOn); 

	}

	void OnCollisionExit(Collision collider)
	{
		curTransform.localScale = new Vector3 (xVarOff, yVarOff);
	}

}
