using UnityEngine;
using System.Collections;

public class Platform_Tilting : MonoBehaviour
{
	float curTip = 0;
	Transform selfTrans;
	bool dependent = true;

	// Use this for initialization
	void Start ()
	{
		selfTrans = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (curTip == 0) {
			dependent = true;
		} else if (curTip == 10) {
			dependent = false;
		}

		if (dependent) {
			curTip = curTip + 1;
		} else if (dependent != true) {
			curTip = curTip - 1;
		}
		selfTrans.rotation = Quaternion.Euler (curTip, 0, 0);
	
	}
}
