using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour {


	private Rigidbody2D grenade;
	public float xSpeed; 
	public float ySpeed;
    private Animator anim;
	GameObject enemyGameObject;
	MovingEnemeyController  enemy;
	float deathRadius = 10f;


    int DestroyTime = 1;

    // Use this for initialization
    void Start () {
		grenade = gameObject.GetComponent<Rigidbody2D> ();
		grenade.velocity = new Vector2 (xSpeed,ySpeed);
		//enemy = gameObject.GetComponent<MovingEnemeyController>;
		//enemyGameObject = GameObject.FindWithTag ("Enemy");
	}

	void OnBecameInvisible()		
	{
		Destroy (grenade.gameObject);
	}


	void OnCollisionEnter2D(Collision2D collision)
	{
		/**
		if (gameObject.tag == "Enemy") {
			if (this.transform.position.x + deathRadius >= enemyGameObject.transform.position.x || this.transform.position.y + deathRadius >= enemyGameObject.transform.position.y  ) {
				enemy.Dead ();
			}
		}
		**/
        anim = this.gameObject.GetComponent<Animator>();
        anim.Play("GrenadeExplosion");
        anim.SetTrigger("GrenadeExplosion");
        Destroy (grenade.gameObject, DestroyTime);


	}
}
