﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour {

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player")
            SceneManager.LoadScene(2);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
