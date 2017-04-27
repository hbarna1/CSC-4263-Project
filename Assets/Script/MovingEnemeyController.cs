using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemeyController : MonoBehaviour
{

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

    int direction = 1; //int direction where 0 is stay, 1 up, -1 down    
    int top = 8;
    int bottom = -8;
    int DestroyTime = 2;

    // Update is called once per frame
    void Update()
    {

        //transform.LookAt (Player);
		if (!dead)
		{
			if (Time.time > nextFire)
			{
				nextFire = Time.time + fireRate;

				if (transform.position.x - GameObject.Find ("Player").transform.position.x < 50) {
					Instantiate (bullet, EnemyBulletSpawn.position, EnemyBulletSpawn.rotation);
				}
			}

			if (transform.position.y >= top)
				direction = -1;

			if (transform.position.y <= bottom)
				direction = 1;

			transform.Translate (0, speed * direction * Time.deltaTime, 0);
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
