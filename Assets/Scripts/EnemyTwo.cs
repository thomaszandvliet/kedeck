using UnityEngine;
using System.Collections;

public class EnemyTwo : MonoBehaviour {

	float speed;
	int direction;
	float hastouchedWall = 1f;
	private Rigidbody2D rb2d;

	void Start () {
		//Bepaald of de enemy als eerste direction boven of onder krijgt.
		direction = Random.Range(0,1);

		if (direction == 0) {
			speed = 5f;
		}

		if (direction == 1) {
			speed = -5f;
		}
	}


	void Awake () {
		rb2d = GetComponent<Rigidbody2D> ();
	}



	// Update is called once per frame
	void FixedUpdate () {
		goMove();
	}




	void goMove() {
		transform.position += Vector3.down * speed * Time.deltaTime;
		Vector3 temp = new Vector3 (0.1f,0f);
		rb2d.transform.position -= temp;
	}
		

	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "Player") {
			Destroy (gameObject); // Destroy Enemy on Collision with Player
		}

		if (col.gameObject.tag == "EnemyDestroyer") {
			Destroy (gameObject);
		}

		if (col.gameObject.tag == "WallUp") {
			speed = 5f;
			hastouchedWall = 0f;
		}

		if (col.gameObject.tag == "WallDown") {
			speed = -5f;
			hastouchedWall = 1f;
		}
	}
}

