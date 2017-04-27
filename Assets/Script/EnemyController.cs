using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public float fireRate;
	public Bullet bullet;
	public Transform EnemyBulletSpawn;
	public Transform Player;
	public float maxMoveDistance;
	public float speed; 
	Vector2 origin;
	float nextFire = 0;
    private Animator anim;
	private bool dead = false;

    int DestroyTime = 1;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

	// Update is called once per frame
	void Update ()
	{
		if (!dead)
		{
			if (Time.time > nextFire) {
				nextFire = Time.time + fireRate;

				if (transform.position.x - GameObject.Find ("Player").transform.position.x < 50) {
					Instantiate (bullet, EnemyBulletSpawn.position, EnemyBulletSpawn.rotation);
				}
			}
		}
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PBullet")
        {
			dead = true;
            anim = this.gameObject.GetComponent<Animator>();
            anim.Play("Die");
            anim.SetTrigger("Die");
            Destroy(this.gameObject, DestroyTime);
        }

        if (collision.gameObject.tag == "Grenade")
        {
			dead = true;
            anim = this.gameObject.GetComponent<Animator>();
            anim.Play("Die");
            anim.SetTrigger("Die");
            Destroy(this.gameObject, DestroyTime);
        }
    }
}
