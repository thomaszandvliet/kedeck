using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartLevel(){
        Destroy (GameObject.Find("dieSound"));
        Destroy (GameObject.Find("backgroundmusic"));
        Application.LoadLevel("main world");

	}

	public void MainMenu(){
        Destroy(GameObject.Find("dieSound"));
        Destroy(GameObject.Find("backgroundmusic"));
        Application.LoadLevel("menu");
	}
}
