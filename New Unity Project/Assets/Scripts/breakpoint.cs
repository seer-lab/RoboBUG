﻿using UnityEngine;
using System.Collections;

public class breakpoint : MonoBehaviour {

	public GameObject next;

	// Use this for initialization
	void Start () {
		//SpriteRenderer sr = GetComponent<SpriteRenderer> ();
	//	sr.color = Color.black;
		this.renderer.enabled=false;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D c){
		if (c.name == "projectileDebug(Clone)") {
			SpriteRenderer sr = GetComponent<SpriteRenderer> ();
			if (sr.color == Color.black){
				this.renderer.enabled=true;
				sr.color = Color.red;
			}
			else if (sr.color == Color.red){
				sr.color = Color.black;
				this.renderer.enabled=false;
			}
		}
	}
}
