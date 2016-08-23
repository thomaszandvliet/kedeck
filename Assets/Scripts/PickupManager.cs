using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PickupManager : MonoBehaviour {
	private int lifePoints;
	public GameObject healthPickup;
	public int spawnRate;
	private int i;

	void Start () {	
		spawnRate = 0;
		i = 0;
	}
	
	void Update () {
		GameObject Life = GameObject.Find("Player");
		Player LifeTotal = Life.GetComponent<Player>();
		lifePoints = LifeTotal.lifePoints;

		if (lifePoints == 0) {
			if (spawnRate == 0)
				spawnRate = Random.Range (1750, 3000);

			if (i == spawnRate) {
				spawnRate = 0;
				i = 0;

				float spawnY = Random.Range (((-Camera.main.ScreenToWorldPoint (new Vector2 (0, Screen.height)).y) + 0.6f), (Camera.main.ScreenToWorldPoint (new Vector2 (0, Screen.height)).y - 0.6f));
				Vector2 spawnPosition = new Vector2 (Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width, 0)).x + 7, spawnY);
				Instantiate (healthPickup, spawnPosition, Quaternion.Euler (0, 0, 270));
			}

			i++;
		}
	}
}
