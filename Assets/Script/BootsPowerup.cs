using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootsPowerup : MonoBehaviour { 
	//private Rigidbody2D bootsPowerup;
	public Boots boots; 
	GameObject player;

	// Use this for initialization
	void Start () {
	    player = GameObject.Find ("Player");
		boots = player.GetComponent<Boots> ();
	}
	
	/**
	// Update is called once per frame
	void Update () {
		
	}
	**/

	//need to add a timer or something to limit the use of the boots
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			boots.hasBoots = true;
			Destroy (gameObject); 
		}
	}
}
	