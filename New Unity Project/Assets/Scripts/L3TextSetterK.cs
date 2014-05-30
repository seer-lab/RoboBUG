using UnityEngine;
using System.Collections;

public class L3TextSetterK : MonoBehaviour {

	string printing = "" +
		"\n" +
		"\n#include" +
		"\n#include\n " +
		"\nint[]                       int                     int" +
		"\n" +
		"\n" +
		"\n    float" +
		"\n\n	for(int" +
		"\n	  " +
		"\n\n		              minimum" + 
		"\n\n		              maximum" +
		"\n\n	 " +
		"\n\n    return" +
		"\n}  ";

	// Use this for initialization
	void Start () {
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = printing;	
		Tm.color = Color.blue;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
