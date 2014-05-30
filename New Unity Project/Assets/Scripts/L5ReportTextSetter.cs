using UnityEngine;
using System.Collections;

public class L5ReportTextSetter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		TextMesh tm = GetComponent<TextMesh> ();
		tm.color = Color.black;
		tm.text = "             *compare(object1, object2){" +
			"\n\t" +
				"\n\t" + 
				"\n\t       xval, yval, zval = 0,0,0;" + 
				"\n\txval += ((red1-red2);" +
				"\n\tyval += (blue1-blue2);" +
				"\n\tzval += (green1-green2);t" +
				"\n\t     (xval+yval+zval > 0){              object1;}" +
				"\n\t         {               object2};";
		/*tm.text = "The bug is that the wrong objects are compared" +
				"\nThe bug is that the darker object is chosen" +
				"\nThe bug is that not all objects are compared" +
				"\nThe bug is that the more green object is chosen" +
				"\nThe bug is that the more red object is chosen" +
				"\nThe bug is that the more blue object is chosen" +
				"\nThe bug is that the blue component isn't used" +
				"\nThe bug is that the green component isn't used" +
				"\nThe bug is that the red component isn't used";*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
