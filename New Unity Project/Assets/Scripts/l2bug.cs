using UnityEngine;
using System.Collections;

public class l2bug : MonoBehaviour {

	public GameObject text;

	// Use this for initialization
	void Start () {
		this.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D p){
		if (text.GetComponent<TextMesh>().text == "ERROR!!!"){
			this.renderer.enabled = true;
		}
	}
}
