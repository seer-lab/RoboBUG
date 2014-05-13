using UnityEngine;
using System.Collections;

public class L5ReportTextSetter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		TextMesh tm = GetComponent<TextMesh> ();
		tm.color = Color.magenta;
		tm.text = "";
		tm.text = "The bug is that the wrong colors are compared" +
				"\nThe bug is that the darker color is chosen" +
				"\nThe bug is that not all colors are compared" +
				"\nThe bug is that the more green color is chosen" +
				"\nThe bug is that the more red color is chosen" +
				"\nThe bug is that the more blue color is chosen" +
				"\nThe bug is that the blue component isn't used" +
				"\nThe bug is that the green component isn't used" +
				"\nThe bug is that the red component isn't used";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
