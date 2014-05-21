using UnityEngine;
using System.Collections;

public class l7code : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<TextMesh> ().text = "colour compare(red1,green1,blue1,red2,green2,blue2,closer){" +
			"\n\tcolour color1 = new colour (red1,green1,blue1);" +
			"\n\tcolour color2 = new colour (red2,green2,blue2);" + 
			"\n\tint dif1,dif2 = 0;" + 
			"\n\tdif1 += (red1-red2); //red component" +
			"\n\tdif1 += (blue1-blue2); //blue component" +
			"\n\tdif1 += (green1-green2); //green component" +
			"\n\tdif2 += (red1-closer.red); //red component" +
			"\n\tdif2 += (blue1-closer.blue); //blue component" +
			"\n\tdif2 += (green1-closer.green); //green component" +
			"\n\tif (color2.index %6 == 0){return \"Cyan\";}" +
			"\n\telse if (dif1 > dif2){return closer;}" +
			"\n\telse{return color2};";;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
