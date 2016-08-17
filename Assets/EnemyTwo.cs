using UnityEngine;
using System.Collections;

public class EnemyTwo : MonoBehaviour {

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {

	}

	void Awake() {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		//Instantiate (gameObject, spawnPosition.x, spawnPosition.y);
	}

	void FixedUpdate() {
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

		if (col.gameObject.tag == "Wall") {
			Debug.Log ("HOER");
			Vector3 temp = new Vector3 (0f, -0.4f);
			rb2d.transform.position -= temp;
		} else {
			Debug.Log ("HOERtje");
			Vector3 temp = new Vector3 (0f, 0.4f);
			rb2d.transform.position -= temp;
			
		}


	}
}

