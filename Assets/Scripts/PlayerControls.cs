using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

	Rigidbody2D rb;

	public float moveSpeed = 10f;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");

		rb.velocity = new Vector2 (move * moveSpeed, rb.velocity.y);
	}
}
