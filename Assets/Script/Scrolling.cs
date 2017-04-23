using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    [SerializeField]
    private float speed = 800.0f;

    private Vector3 position;
    private float screenRadius;

    private void Awake()
    {
        Application.targetFrameRate = 60;

        this.position = new Vector3();
        this.screenRadius = this.GetComponent<Camera>().orthographicSize * this.GetComponent<Camera>().aspect;
    }

    // Update is called once per frame
    void Update () {
        this.position = this.transform.position;

        this.position.x += this.speed * Time.deltaTime;

        if (this.position.x > this.screenRadius)
            this.position.x = -this.screenRadius;

        this.transform.position = this.position;
    }
}
