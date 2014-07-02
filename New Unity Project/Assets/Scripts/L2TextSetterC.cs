using UnityEngine;
using System.Collections;

public class L2TextSetterC : MonoBehaviour {
	
	string testing = "" +
		//"\n//Calculate the robot's weight based on the weight of its parts" +
		"\n//Calculate total sum of distances from cannon to all threats" +
			"\n\n\n\n\n\n\n" +
			"\n//Calculate the cannon's energy level based \n//on the median power rating of its internal systems" +
			"\n\n\n\n\n\n" +
			"\n\n//Calculate the cannon's temperature based \n//on the average temperature of all its parts";

	
	// Use this for initialization
	void Start () {
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = testing;	
		Tm.color = new Color (.25f, .25f, .25f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
