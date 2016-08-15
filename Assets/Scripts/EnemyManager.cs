using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

	public GameObject enemyOne;

	public float spawnTime = 0.5f;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", 1f, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn () {
		float spawnY = Random.Range(((-Camera.main.ScreenToWorldPoint (new Vector2 (0, Screen.height)).y) + 0.6f), (Camera.main.ScreenToWorldPoint (new Vector2 (0, Screen.height)).y - 0.6f));
		Vector2 spawnPosition = new Vector2 (Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width, 0)).x + 7, spawnY);

		Instantiate (enemyOne, spawnPosition, Quaternion.Euler(0,0,270));
	}
}
