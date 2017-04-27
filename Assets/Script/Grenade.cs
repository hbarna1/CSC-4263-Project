using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour {


	private Rigidbody2D grenade;
	public float xSpeed; 
	public float ySpeed;
    private Animator anim;

    int DestroyTime = 1;

    // Use this for initialization
    void Start () {
		grenade = gameObject.GetComponent<Rigidbody2D> ();
		grenade.velocity = new Vector2 (xSpeed,ySpeed);
	}

	void OnBecameInvisible()		
	{
		Destroy (grenade.gameObject);
	}


	void OnCollisionEnter2D(Collision2D collision)
	{
        anim = this.gameObject.GetComponent<Animator>();
        anim.Play("GrenadeExplosion");
        anim.SetTrigger("GrenadeExplosion");
        Destroy (grenade.gameObject, DestroyTime);
	}
}
