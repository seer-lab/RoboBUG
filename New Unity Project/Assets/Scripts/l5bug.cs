using UnityEngine;
using System.Collections;

public class l5bug : MonoBehaviour {

	public GameObject l5output;

	// Use this for initialization
	void Start () {
		this.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D p){
		if (p.name == "projectile(Clone)") {
				TextMesh tm = l5output.GetComponent<TextMesh>();
				tm.text = "Correct!";
		}
	}
}
