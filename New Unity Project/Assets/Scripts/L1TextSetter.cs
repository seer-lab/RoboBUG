using UnityEngine;
using System.Collections;

public class L1TextSetter : MonoBehaviour {

	string tracing = "//To Find average of input numbers " +
		"\n//Input : Integer numbers  " +
		"\n  " +
		"\n#include<stdio.h>  " +
		"\n#include<conio.h>  " +
		"\nint avg(int values[], int numOfValues) " +
		"\n{  " +
		"\n	//values = [0,1,2,3,4]" +
		"\n    int sum=0,i; " +
		"\n    float avg; " +
		"\n    printf(\"Average of the %d numbers entered is \", numOfValues); " +
		"\n    for(i=0;i<numOfValues;i++) " +
		"\n    { " +
		"\n		sum=sum+values[i];" +
		"\n		avg=float(sum/n);" +
		"\n    }  " +
		"\n	avg++;" +
		"\n    return avg;" +
		"\n    } " +
		"\n} " +
		"\n" +
		"\n";

	// Use this for initialization
	void Start () {
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = tracing;	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
