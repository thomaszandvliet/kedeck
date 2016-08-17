using UnityEngine;
using System.Collections;

public class EnemyTwo : MonoBehaviour {

	float speed;
	float hastouchedWall = 1f;
	private Rigidbody2D rb2d;

	void Start () {
		speed = 5f;
	}

	void Awake () {
		rb2d = GetComponent<Rigidbody2D> ();
	}



	// Update is called once per frame
	void FixedUpdate () {

		goMove();
//		Vector3 temp = new Vector3 (200f,0f);
//		rb2d.transform.position -= temp;

	}

	void goMove() {
		transform.position += Vector3.down * speed * Time.deltaTime;
		Vector3 temp = new Vector3 (0.05f,0f);
		rb2d.transform.position -= temp;
	}
		

	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "Player") {
			//Destroy (gameObject); // Destroy Enemy on Collision with Player
		}

		if (col.gameObject.tag == "EnemyDestroyer") {
			Destroy (gameObject);
		}

		if (col.gameObject.tag == "WallUp") {
			speed = 5f;
			hastouchedWall = 0f;
			Debug.Log (hastouchedWall);
		}

		if (col.gameObject.tag == "WallDown") {
			speed = -5f;
			hastouchedWall = 1f;
			Debug.Log (hastouchedWall);
		}
	}
		
//	void OnCollisionExit2D(Collision2D col) {
//		if (col.gameObject.tag == "Wall" && hastouchedWall == 1f) {
//			speed = 5f;
//			hastouchedWall = 0f;
//			Debug.Log (hastouchedWall);
//		}
//
//		if (col.gameObject.tag == "Wall" && hastouchedWall == 0f) {
//			speed = -5f;
//			hastouchedWall = 1f;
//			Debug.Log (hastouchedWall);
//		}
//
//
//	}

}

