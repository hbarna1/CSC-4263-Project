using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	private Rigidbody2D bullet;
	public float speed;
    private Animator anim;

    // Use this for initialization
    void Start ()
	{
        bullet = gameObject.GetComponent<Rigidbody2D> ();
		bullet.AddForce(new Vector2( speed, 0));
	}
		

	void OnBecameInvisible()
	{
	   Destroy (this.gameObject);
	}
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //  anim = this.gameObject.GetComponent<Animator>();
            //  anim.Play("Die");
            //  anim.SetTrigger("Die");
            // Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "EBullet" || collision.gameObject.tag == "Barricade")
        {
           Destroy(this.gameObject);
        }
    }

} 