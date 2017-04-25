using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MudPuddle : MonoBehaviour {

	private Rigidbody2D mudPuddle;  
	public Boots boots;
	GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		boots = player.GetComponent<Boots> ();

	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			
			if (boots.hasBoots == false) {
				// needs to cause death for player

				Destroy (other.gameObject);
                SceneManager.LoadScene(3);
            }
		}
	}
}
