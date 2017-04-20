using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudPuddle : MonoBehaviour {

	private Rigidbody2D mudPuddle;  
	public Boots boots;
	// Use this for initialization
	void Start () {
		GameObject player = GameObject.Find ("Player");
		boots = player.GetComponent<Boots> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (boots.hasBoots == false) {
			// needs to cause death for player
			Destroy (other.gameObject);
		}

	}
}
