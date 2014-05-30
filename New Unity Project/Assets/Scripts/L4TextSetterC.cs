using UnityEngine;
using System.Collections;

public class L4TextSetterC : MonoBehaviour {

	string main = "//Robot Vision Compatability Function" +
		"\n//Load database of colors and sub-categories of colors" +
		"\n//match color RGB values with English names";

	// Use this for initialization
	void Start () {
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = main;	
		Tm.color = Color.grey;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
