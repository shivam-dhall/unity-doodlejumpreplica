using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class player : MonoBehaviour {

	public float mspeed = 10f;
	Rigidbody2D rb;
	float movement = 10f;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
		movement = Input.GetAxis("Horizontal") * mspeed;
	}

	void FixedUpdate()
	{
		Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;
	}
}
