using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

	// Use this for initialization
	public void playbutton(string scencename)
    {
        SceneManager.LoadScene(4);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
