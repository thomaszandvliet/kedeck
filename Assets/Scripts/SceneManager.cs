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
		Application.LoadLevel("main world");

	}

	public void MainMenu(){
		Application.LoadLevel("menu");
	}
}
