using UnityEngine;
using System.Collections;

public class L2TextSetterC : MonoBehaviour {
	
	string testing = "" +
		"\n//Calculate the robot's weight based on the weight of its parts" +
			"\n" +
			"\n//Calculate the robot's energy level based \n//on the median power level of its parts" +
			"\n" +
			"\n//Calculate the robot's temperature based \n//on the average temperature of its parts";

	
	// Use this for initialization
	void Start () {
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = testing;	
		Tm.color = Color.grey;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
