using UnityEngine;
using System.Collections;

public class L3TextSetterD : MonoBehaviour {

	string printing = "//Identify system with highest priority and system with lowest priority" +
		"\n" +
		"\n  #include<stdio.h>  " +
		"\n#include<conio.h> \n " +
		"\nint[] Prioritize(int priorities[], int numOfSystems) " +
		"\n{ //test using pre-chosen values for systems " +
		"\n	//priorities = [0,4,1,6,3,2,5], numOfSystems = 7" +
		"\n    float min=priorities[0],max=priorities[0]; " +
		"\n\n	for(int i=1;i<numOfSystems;i++) " +
		"\n	{  " +
		"\n\n		min = minimum(min, priorities[i]);" + 
		"\n\n		max = maximum(max, priorities[i]);" +
		"\n\n	} " +
		"\n\n    return [min, max];" +
		"\n}  ";

	// Use this for initialization
	void Start () {
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = printing;	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
