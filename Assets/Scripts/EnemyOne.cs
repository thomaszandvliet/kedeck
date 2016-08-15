using UnityEngine;
using System.Collections;

public class EnemyOne : MonoBehaviour {

	private Rigidbody2D rb2d;

	//public float spawnTime = 3f;

	//private float spawnY = Random(0, Camera.main.ScreenToWorldPoint (new Vector2 (0, Screen.height)).y);
	//private Vector2 spawnPosition = new Vector2(Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x, spawnY);

	//public Transform[] spawnPoints;

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
		Vector3 temp = new Vector3 (0.1f,0f);
		rb2d.transform.position -= temp;
	}

	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "Player") {
			//Destroy (gameObject); // Destroy Enemy on Collision with Player
		}
		if (col.gameObject.tag == "EnemyDestroyer") {
			Destroy (gameObject);
		}
	}
}
