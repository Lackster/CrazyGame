using UnityEngine;
using System.Collections;

public class sceneController : MonoBehaviour 
{
	
	void Update () 
	{

		if (Input.GetKeyDown(KeyCode.Asterisk)) 
		{
			if (Time.timeScale == 1)
			{
				Time.timeScale = 0;
			}else if (Time.timeScale == 0)
			{
				Time.timeScale = 1;
			}
		}


	}
}
