using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour {
	public float speed;
	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
	{
		float moveHoizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 Movement = new Vector3 (moveHoizontal, 0.0f, moveVertical);  



		rb.AddForce (Movement * speed);
			
	}

}