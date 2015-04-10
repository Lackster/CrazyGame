using UnityEngine;
using System.Collections;

public class playerMovementDraft : MonoBehaviour {
	AnimationState anim;
	Rigidbody rb;
	public float allowedVelocity = 5;
	public float fallingSpeed = 3;
	public float velocityChange;
	public float velocityChangeRev;


	// Use this for initialization
	void Start () 
	{
	  anim = GetComponent<AnimationState>();
		rb = GetComponent <Rigidbody> (); 
	}

	// Update is called once per frame
	void Update () 
	{

		//MovementKeys
		if (Input.GetKeyDown(KeyCode.D)) 
		{
			rb.AddForce(velocityChange,0,0,ForceMode.Acceleration);
		
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			rb.AddForce (velocityChangeRev,0,0,ForceMode.Acceleration);
			
		}
		if (Input.GetKeyDown (KeyCode.W)) 
		{
			rb.AddForce (0, velocityChange, 0, ForceMode.Impulse);
		}
		if (Input.GetKeyDown (KeyCode.S)) 
		{
			rb.AddForce(0,velocityChangeRev,0, ForceMode.Acceleration);
		}
	
		//Limiter

		if (rb.velocity.magnitude > allowedVelocity)
		{
			//rb.velocity.magnitude =allowedVelocity;
		}

		//AnimationPathing
		anim.speed = rb.velocity.x;


	}


	void OnCollisionEnter(Collision collisionInfo)
	{


	}

	void OnCollisionStay(Collision collisionInfo)
	{
		if (collisionInfo.gameObject.name == "platform") 
		{
			rb.drag = 20;
			rb.angularDrag = 18;
		}

	}

	void OnCollisionExit(Collision collisionInfo)
	{
		if (collisionInfo.gameObject.name == "platform") {
			rb.drag = 10;
			rb.angularDrag = 10;
		}
	}


}
