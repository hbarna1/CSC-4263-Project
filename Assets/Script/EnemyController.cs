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

	// Update is called once per frame
	void Update ()
	{
            //transform.LookAt (Player);

            if (Time.time > nextFire)
        {
			nextFire = Time.time + fireRate;

			Instantiate (bullet, EnemyBulletSpawn.position, EnemyBulletSpawn.rotation);
		}


	}

}
