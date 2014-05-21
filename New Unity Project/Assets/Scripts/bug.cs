using UnityEngine;
using System.Collections;

public class bug : MonoBehaviour {

	public GameObject nextCode;

	// Use this for initialization
	void Start () {
		this.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D p){
		if (p.name == "projectileBug(Clone)") {
			this.renderer.enabled = true;
			Destroy (p.gameObject);
				}
		if (this.renderer.enabled && p.name == "hero"){
			p.transform.position = new Vector3 (nextCode.transform.position.x, nextCode.transform.position.y, 0);
		}
		}
}
