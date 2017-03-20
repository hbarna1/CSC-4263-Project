using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	private Rigidbody2D bullet;
	public float speed;  

	// Use this for initialization
	void Start ()
	{
		bullet = gameObject.GetComponent<Rigidbody2D> ();
		bullet.AddForce(new Vector2( speed, 0));
	}




	void onBecomeInvisible()
	{
		Destroy (bullet);
	}

} 