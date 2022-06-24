using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl2 : MonoBehaviour {

	public GameObject lvl2;
	void Start(){
		lvl2.GameObject.SetActive(false);
	}
	
	private void OnCollisionEnter2D(Collision2D other) {
		
		if (collections.gameObject.tag == "Player"){
			pass;
		}
	}



}
