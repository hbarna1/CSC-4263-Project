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

    int direction = 1; //int direction where 0 is stay, 1 up, -1 down    
    int top = 3;
    int bottom = -3;

    // Update is called once per frame
    void Update()
    {

        //transform.LookAt (Player);

        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            Instantiate(bullet, EnemyBulletSpawn.position, EnemyBulletSpawn.rotation);

        }


        if (transform.position.y >= top)
            direction = -1;

        if (transform.position.y <= bottom)
            direction = 1;

        transform.Translate(0, speed * direction * Time.deltaTime, 0);

    }
}
