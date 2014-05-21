using UnityEngine;
using System.Collections;

public class sidebardescription : MonoBehaviour {

	public GameObject level;
	public int levelnum;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		levelnum = System.Convert.ToInt16(level.GetComponent<TextMesh> ().text);
		switch (levelnum) {
		case 1:
			GetComponent<GUIText>().text = "Objective:\nFind the bug\nHit it with a Bugcatcher\nTouch it to proceed";
			break;
		case 2:
			GetComponent<GUIText>().text = "Objective:\nModify each test case till you get an error\nFind all 3 bugs to proceed\nuse the warp tool to move about the functions";
			break;
		case 3:
			GetComponent<GUIText>().text = "Objective:\nTurn on/off print statements with the printer tool\nobserve the output at the bottom\nreport the bug at the bottom of the code";
			break;
		case 4:
			GetComponent<GUIText>().text = "Objective:\nread the error report\ncomment out lines of code\nfigure out where the bug is and catch it";
			break;
		case 5:
			GetComponent<GUIText>().text = "Objective:\nuse the breakpointer tool to activate/deactivate breakpoints\ndetermine where the bug is";
			break;
		case 6:
			GetComponent<GUIText>().text = "Objective:\n1)figure out which function is faulty and throw a bugcatcher at it\n2)use the error message to determine the source of bug#1\nUse the breakpoints to find bug#2";
			break;
		case 0:
			GetComponent<GUIText>().text = "Objective:\n";
			break;

		}
	}
}
