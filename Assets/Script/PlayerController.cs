using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb2d;
    public float speed;
    public Boundary boundary;
	public Bullet bullet; 
	public float bulletFireRate;
	public float grenadeFireRate;
	public Grenade grenade;
	public Transform bulletSpawn;
	public Transform grenadeSpawn;
	public float keyDelay = 0.5f; // 1 second
	private float timePassed = 0f; 
	private Boots boots;

	// Use this for initialization
	void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.velocity = (movement * speed);
        rb2d.position = new Vector2
        (
            Mathf.Clamp(rb2d.position.x, boundary.xMin, boundary.xMax),
            Mathf.Clamp(rb2d.position.y, boundary.yMin, boundary.yMax)
        );

		timePassed += Time.deltaTime;
		if(Input.GetKey(KeyCode.Space) && timePassed >= keyDelay)
		{
			Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
			timePassed = 0f;
		}

		if(Input.GetKey(KeyCode.G) && timePassed >= keyDelay)
		{
			Instantiate(grenade, grenadeSpawn.position, grenadeSpawn.rotation);
			timePassed = 0f;
		}

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(3);
    }

}
