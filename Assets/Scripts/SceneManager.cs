using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class SceneManager : MonoBehaviour {

    public AudioSource background_music;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartLevel(){
        background_music.Stop();
        Destroy (GameObject.Find("dieSound"));
        Destroy (GameObject.Find("background_music"));
        Application.LoadLevel("main world");

	}

	public void MainMenu(){
        background_music.Stop();
        Destroy(GameObject.Find("dieSound"));
        Destroy(GameObject.Find("background_music"));
        Application.LoadLevel("menu");
	}
}
