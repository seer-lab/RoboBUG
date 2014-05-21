using UnityEngine;
using System.Collections;

public class L5ReportTextSetter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		TextMesh tm = GetComponent<TextMesh> ();
		tm.color = Color.magenta;
		tm.text = "colour compare(red1,green1,blue1,red2,green2,blue2){" +
				"\n\tcolour color1 = new colour (red1,green1,blue1);" +
				"\n\tcolour color2 = new colour (red2,green2,blue2);" + 
				"\n\tint redness, blueness, greenness = 0,0,0; //use of all 3 colors" + 
				"\n\tredness += (red1-red2); //red component" +
				"\n\tblueness += (blue1-blue2); //blue component" +
				"\n\tgreenness += (green1-green2); //green component" +
				"\n\tif (redness+blueness+greenness > 0){return color1;}" +
				"\n\telse{return color2};";
		/*tm.text = "The bug is that the wrong colors are compared" +
				"\nThe bug is that the darker color is chosen" +
				"\nThe bug is that not all colors are compared" +
				"\nThe bug is that the more green color is chosen" +
				"\nThe bug is that the more red color is chosen" +
				"\nThe bug is that the more blue color is chosen" +
				"\nThe bug is that the blue component isn't used" +
				"\nThe bug is that the green component isn't used" +
				"\nThe bug is that the red component isn't used";*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
