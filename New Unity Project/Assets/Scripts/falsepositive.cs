using UnityEngine;
using System.Collections;

public class falsepositive : MonoBehaviour {

	public GameObject text;
	public GameObject fplabel;

	float showdelay = 5f;
	private float hideself = 0.0f;

	// Use this for initialization
	void Start () {
		this.renderer.enabled = false;
		text.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > hideself) {
			this.renderer.enabled = false;
			text.renderer.enabled = false;
		}
	}

	void OnTriggerEnter2D(Collider2D p){
		if (p.name == "projectileBug(Clone)") {
		//	Destroy (p.gameObject);
			this.renderer.enabled = true;
			text.renderer.enabled = true;
			fplabel.GetComponent<TextMesh>().text = "Caught";
			hideself = Time.time + showdelay;
		}
	}
}
