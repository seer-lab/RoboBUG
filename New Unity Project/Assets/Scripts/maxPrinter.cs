using UnityEngine;
using System.Collections;

public class maxPrinter : MonoBehaviour {

	public bool output = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		TextMesh tm = GetComponent<TextMesh>();
		if (output) {
			tm.color = Color.cyan;
			tm.text = "Console.WriteLine(max);";
		}
		else{
			tm.color = Color.grey;
			tm.text = "//Don't print max;";
		}
	}
	void OnTriggerEnter2D(Collider2D p){
		if (p.name == "projectile(Clone)") {
			output = !output;
		}
	}
}
