using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class man : MonoBehaviour {

	public float speed;
	public int positionSTEP;

	public Transform point;


	public bool moveingRight;


	public Transform Player;


	public float stoppingDistance;

	bool Chill = false;
	bool Angry = false;
	bool Goback = false;



	void Start () 
	{
		//Player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	
	void Update () 
	{
		if (Vector2.Distance(transform.position, point.position)< positionSTEP && Angry == false)
		{
			Chill = true;

		}

		if(Vector2.Distance(transform.position, Player.position) < stoppingDistance)
		{
			//angry();
			Angry = true;
			Chill = false;
			Goback = false;
		}

		if(Vector2.Distance(transform.position, Player.position) > stoppingDistance)
		{
			Goback = true;
			Angry = false;
		}

		if (Chill == true)
		{
			chill();
		}
		else if (Angry == true)
		{
			angry();
		}
		else if (Goback == true)
		{
			goback();
		}
	}


	void chill()
	{
		if (transform.position.x > point.position.x + positionSTEP){
			moveingRight = false;
		}
		else if (transform.position.x < point.position.x - positionSTEP){
			moveingRight = true;

		}

		if (moveingRight)
		{
			transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
		}
		else
		{
			transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
		}
	}


	void angry()
	{
		transform.position = Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);

	}


	void goback()
	{
		transform.position = Vector2.MoveTowards(transform.position, point.position, speed * Time.deltaTime);

	}
}
