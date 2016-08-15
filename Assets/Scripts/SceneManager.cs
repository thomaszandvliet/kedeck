using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class SceneManager : MonoBehaviour {

    public AudioSource dieSound;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartLevel(){
        dieSound.Stop();
		Application.LoadLevel("main world");

	}

	public void MainMenu(){
        dieSound.Stop();
        Application.LoadLevel("menu");
	}
}
