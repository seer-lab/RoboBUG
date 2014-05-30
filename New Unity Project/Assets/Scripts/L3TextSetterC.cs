using UnityEngine;
using System.Collections;

public class L3TextSetterC : MonoBehaviour {

	string printing = "//Identify system with highest priority and system with lowest priority" +
		"\n" +
		"\n" +
		"\n\n " +
		"\n" +
		"\n   //test using pre-chosen values for systems " +
			"\n	//priorities = [0,4,1,6,3,2,5], numOfSystems = 7";


	// Use this for initialization
	void Start () {
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = printing;	
		Tm.color = Color.grey;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
