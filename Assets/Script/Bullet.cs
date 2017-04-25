using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	private Rigidbody2D bullet;
	public float speed;
    Animator anim;

	// Use this for initialization
	void Start ()
	{
		bullet = gameObject.GetComponent<Rigidbody2D> ();
		bullet.AddForce(new Vector2( speed, 0));
	}
		

	/*void OnBecameInvisible()
	{
		Destroy (bullet.gameObject);
	}
    */
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //anim.SetTrigger(1);
            Destroy(collision.gameObject);
            Destroy(bullet.gameObject);
        }
        else if (collision.gameObject.tag == "EBullet")
                 Destroy(bullet.gameObject);
    }

} 