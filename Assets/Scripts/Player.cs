using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class Player : MonoBehaviour {

	public bool jump = false;
	public float jumpForce = 75f;
	public float maxSpeed = 75f;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		
	}

	void Awake() {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("up") || Input.touchCount > 0) {
			jump = true;
		}
	}

	void FixedUpdate() {
		if(jump){
			rb2d.AddForce(new Vector2(0f, jumpForce));
			jump = false;
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.name == "Wall") {
			rb2d.velocity = new Vector2(0f, 0f);
		}

		if(col.gameObject.tag == "Enemy") {
			//Destroy (gameObject); // Destroy player on collision
			//Time.timeScale = 0;
			Application.LoadLevel("game over");
		}
	}
}
