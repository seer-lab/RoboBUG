using UnityEngine;
using System.Collections;

public class L2Intro : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<TextMesh> ().text = "" +
			"Three bugs have infected functions" +
				"\nthat are hidden from you. " +
				"\n\nYou must attempt to" +
				"\nidentify the bugs by " +
				"\nimplementing tests to " +
				"\ncatch them using " +
				"\nthe TESTER tool.";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
