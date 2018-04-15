﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public Paddle paddle;

	private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = paddle.transform.position + paddleToBallVector;

		if (Input.GetMouseButtonDown (0)) {
			this.rigidbody2D.velocity = new Vector2 (2f, 10f);
		}
	}
}