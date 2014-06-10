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
			GetComponent<GUIText>().text = "Objective:\nFind the bug\nHit it with a Bugcatcher";
			break;
		case 2:
			GetComponent<GUIText>().text = "Objective:\nModify each test case till you get an error\nFind all 3 bugs to proceed\nuse the warp tool to move about the functions\nuse the tester tool when you have entered input/output pairs";
			break;
		case 3:
			GetComponent<GUIText>().text = "Objective:\nTurn on/off print statements with the printer tool\nobserve the output by following the output warp\nlocate the bug and catch it with the Bugcatcher like in level 1";
			break;
		case 4:
			GetComponent<GUIText>().text = "Objective:\nread the error report\ncomment out lines of code\nfigure out where the bug is and catch it";
			break;
		case 5:
			GetComponent<GUIText>().text = "Objective:\nuse the breakpointer tool to activate/deactivate breakpoints\ndetermine where the bug is";
			break;
		case 6:
			GetComponent<GUIText>().text = "Objective:\n1)figure out which function is faulty and throw a bugcatcher at it\n2)use the error message to determine the source of bug#1 and fix it\n3)Use the breakpoints to find bug#2\n4)Throw a bugcatcher at the exact place the bug occurs\n5)Find and catch the final bug";
			break;
		case 0:
			GetComponent<GUIText>().text = "";
			break;
		case 100:
			GetComponent<GUIText>().text = "";
			break;
		case 200:
			GetComponent<GUIText>().text = "";
			break;
		case 300:
			GetComponent<GUIText>().text = "";
			break;
		case 400:
			GetComponent<GUIText>().text = "";
			break;
		case 500:
			GetComponent<GUIText>().text = "";
			break;

		}
	}
}
