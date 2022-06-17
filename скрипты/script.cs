using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script : MonoBehaviour {

	public float speed = 20f;
	public Rigidbody2D rb;

	void Start () {
		rb = GetComponent <Rigidbody2D> ();
	}
	
	
	void Update ()
	 {
		float moveX = Input.GetAxis ("Horizontal");
		rb.MovePosition (rb.position + Vector2.right * moveX * speed * Time.deltaTime);

		if (Input.GetKeyDown(KeyCode.Space))
			rb.AddForce(Vector2.up * 5000);
	}

	
	
	void OnTriggerEnter2D(Collider2D other) {
		respawn();

	}

	void respawn (){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		
	}
}
