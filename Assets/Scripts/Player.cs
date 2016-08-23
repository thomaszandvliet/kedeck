using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class Player : MonoBehaviour {
	//private static Player _instance;

	public bool jump = false;
	private int touchTimer = 0;
	public AudioSource jumpSound;
	public AudioSource dieSound;
	public float jumpForce = 75f;
	public float maxSpeed = 75f;
	private Rigidbody2D rb2d;
	public int lifePoints;

	/*public static Player Instance {
		get {
			if (_instance == null) {
				_instance = GameObject.FindObjectOfType<Player> ();
			

				if (_instance == null) {
					GameObject container = new GameObject ("Player");
				}
			}

			return _instance;
		}
	}*/

	// Use this for initialization
	void Start () {
		lifePoints = 1;
	}

	void Awake() {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	public int getLifePoints() {
		Debug.Log (lifePoints);
		return this.lifePoints;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("up") || Input.touchCount > 0) {
			jump = true;
		}

		if(Input.GetKeyDown("up")){
			jumpSound.Play ();
		}

		if (Input.touchCount > 0 && touchTimer < 1) {
			touchTimer = touchTimer + 1;
			jumpSound.Play ();
		} else if (Input.touchCount == 0) {
			touchTimer = 0;
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

		if (col.gameObject.name == "extraLife") {
			if (lifePoints == 0) {
				lifePoints++;
			}
		}

		if(col.gameObject.tag == "Enemy") {
			dieSound.Play ();
			if (lifePoints == 0) {
				Application.LoadLevel ("game over");
			} else {
				lifePoints--;
			}
		}
	}
}
