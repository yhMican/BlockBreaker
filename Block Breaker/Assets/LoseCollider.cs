﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	public LevelManager levelManager;

	void OnTriggerEnter2D (Collider2D trriger) {
		print ("Trigger");
		levelManager.LoadLevel ("Win Screen");
	}

	void OnCollisionEnter2D (Collision2D collision) {
		print ("Collision");
	}
}
