﻿using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour {
	private Rigidbody2D rb2d;

	void Start () { }

	void Awake() {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void Update () { }

	void FixedUpdate() {
		Vector3 temp = new Vector3 (0.1f,0f);
		rb2d.transform.position -= temp;
	}

	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "Player" || col.gameObject.tag == "EnemyDestroyer")
			Destroy (gameObject);
	}
}