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
    }

    void OnCollisionEnter2D(Collision2D collision)
<<<<<<< HEAD
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Destroy(bullet.gameObject);
            SceneManager.LoadScene(3);
        }
        else if (collision.gameObject.tag == "PBullet")
            ;
=======
    {
		if (collision.gameObject.tag == "Player") {
			Destroy (collision.gameObject);
			Destroy (bullet.gameObject);
		}
		else if (collision.gameObject.tag == "PBullet")
			Physics.IgnoreCollision (PBullet.collider, collider);
>>>>>>> origin/master
        else
            Destroy(bullet.gameObject);
    }

}