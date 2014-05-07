using UnityEngine;
using System.Collections;

public class L3TextSetter : MonoBehaviour {

	string printing = "//To Find average of the largest and smallest of the input numbers  " +
		"\n//Input : Integer numbers  " +
		"\n  \n#include<stdio.h>  " +
		"\n#include<conio.h>  " +
		"\nint minMaxAvg(int values[], int numOfValues) " +
		"\n{  " +
		"\n	//values = [0,4,1,6,3,2,5], numOfValues = 7" +
		"\n    float min=values[0],max=values[0]; " +
		"\n\n	for(i=1;i<numOfValues;i++) " +
		"\n	{  " +
		"\n\n		min = minimum(min, values[i]);" + 
		"\n\n		max = maximum(max, values[i]);" +
		"\n\n	} " +
		"\n\n    return (min+max)/2;" +
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
