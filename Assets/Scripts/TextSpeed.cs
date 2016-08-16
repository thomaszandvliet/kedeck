using UnityEngine;
using System.Collections;

public class TextSpeed : MonoBehaviour {

	private Rigidbody2D rb2d;
	private int timer;
	// Use this for initialization
	void Start () {
	
	}

	void Awake() {
		rb2d = GetComponent<Rigidbody2D> ();
	}


	// Update is called once per frame
	//YES THIS CODE IS SHIT (BUT IT WORKS OKAY :'< )
	void Update () {
		if (timer >= 0 && timer <= 200) {
			Vector3 temp = new Vector3 (0.01f, 0f);
			rb2d.transform.position -= temp;
			timer = timer + 1;
		} else if (timer >= 200 && timer <= 300) {
			Vector3 temp = new Vector3 (0.0f, 0.01f);
			rb2d.transform.position -= temp;
			timer = timer + 1;
		} else if (timer >= 300 && timer <= 700) {
			Vector3 temp = new Vector3 (0.01f, 0f);
			rb2d.transform.position += temp;
			timer = timer + 1;
		} else if (timer >= 700 && timer <= 800) {
			Vector3 temp = new Vector3 (0f, 0.01f);
			rb2d.transform.position += temp;
			timer = timer + 1;
		} else if (timer >= 800 && timer <= 1000) {
			Vector3 temp = new Vector3 (0.01f, 0f);
			rb2d.transform.position -= temp;
			timer = timer + 1;
		}
		else if (timer > 1000) {
			timer = 0;
//			Debug.Log (timer);
		}
			
	}

}
