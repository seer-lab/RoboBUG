using UnityEngine;
using System.Collections;

public class iPrinter : MonoBehaviour {

	public bool output = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		TextMesh tm = GetComponent<TextMesh>();
		if (output) {
			tm.color = Color.cyan;
			tm.text = "cout<<priorities[i];";
		}
		else{
			tm.color = Color.grey;
			tm.text = "//Don't print i;";
		}
	}
	void OnTriggerEnter2D(Collider2D p){
		if (p.name == "projectilePrint(Clone)") {
			output = !output;
			Destroy(p.gameObject);
		}
	}
}
