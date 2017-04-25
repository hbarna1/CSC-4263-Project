using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class EBullet : MonoBehaviour
{

    private Rigidbody2D bullet;
    public float speed;


    // Use this for initialization
    void Start()
    {
        bullet = gameObject.GetComponent<Rigidbody2D>();
        bullet.AddForce(new Vector2(speed, 0));
    }


    void OnBecameInvisible()
    {
        Destroy(bullet.gameObject);
        SceneManager.LoadScene(3);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
            if (collision.gameObject.tag == "Player")
            {
                Destroy(collision.gameObject);
                Destroy(bullet.gameObject);
            }
            else if (collision.gameObject.tag == "PBullet")
            {
                if (collision.gameObject.tag == "Player")
                {
                    Destroy(collision.gameObject);
                    Destroy(bullet.gameObject);
                }
                // else if (collision.gameObject.tag == "PBullet")
                //    Physics.IgnoreCollision(PBullet.collider, collider);
                else
                    Destroy(bullet.gameObject);
            }


        else
            Destroy(bullet.gameObject);

    }
}
