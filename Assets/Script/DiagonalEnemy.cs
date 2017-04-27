using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagonalEnemy : MonoBehaviour
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

    int DestroyTime = 2;

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            Instantiate(bullet, EnemyBulletSpawn.position, EnemyBulletSpawn.rotation);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PBullet")
        {
            anim = this.gameObject.GetComponent<Animator>();
            anim.Play("Die");
            anim.SetTrigger("Die");
            Destroy(this.gameObject, DestroyTime);
        }

        if (collision.gameObject.tag == "Grenade")
        {
            anim = this.gameObject.GetComponent<Animator>();
            anim.Play("Die");
            anim.SetTrigger("Die");
            Destroy(this.gameObject, DestroyTime);
        }
    }
}
