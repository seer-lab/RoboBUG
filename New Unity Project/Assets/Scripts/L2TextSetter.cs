using UnityEngine;
using System.Collections;

public class L2TextSetter : MonoBehaviour {

	string testing = "//To Find median, sum, and average of input numbers  " +
		"\n//Input : numbers " +
		"\n" +
		"\nint sumCalc (int values[]);" +
		"\nint medianCalc (int values[]);" +
		"\nfloat avgCalc (float values[]);" +
		"\n" +
		"\nbool sumTest (){" +
		"\n	int values[] = " +
		"\n	int total = " +
//		"\n	return sumCalc(values[]) == total;" +
		"\n" +
		"\n}" +
		"\n" +
		"\nint medianTest ();{" +
		"\n	int values[] = " +
		"\n	int mid = " +
//		"\n	return medianCalc(values[]) == mid;" +
		"\n" +
		"\n}" +
		"\nfloat avgCalc ();{" +
		"\n	float values[] = " +
		"\n	float average = " +
//		"\n	return avgCalc(values[]) == average;" +
		"\n" +
		"\n}" +
		"\n";

	// Use this for initialization
	void Start () {
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = testing;	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
