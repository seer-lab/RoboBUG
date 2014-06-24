using UnityEngine;
using System.Collections;

public class L2TextSetter : MonoBehaviour {
	
	string testing = "\n       DistanceCalc(       distances[]);" +
		"\n" +
			"\n\n\n       EnergyCalc(       powers[]);" +
			"\n" +
			"\n\n\n          TempCalc(           temps[]);" +
			"\n" +
			"\n      testValues [] = {\n};" +
			"\n      expectedResult = \n" +
			"\n         DistanceCalcTest (){" +
			"\n	               distances[] = testValues;" +
			"\n	               totalDistance = expectedResult;" +
			//		"\n	return sumCalc(values[]) == total;" +
			"\n" +
			"\n}" +
			"" +
			"\n         EnergyCalcTest ();{" +
			"\n	               powers[] = testValues;" +
			"\n	               powerlevel = expectedResult;" +
			//		"\n	return medianCalc(values[]) == mid;" +
			"\n" +
			"\n}" +
			"\n          TempCalcTest ();{" +
			"\n	                  temps[] = testValues;" +
			"\n	                  averageTemp = expectedResult;" +
			//		"\n	return avgCalc(values[]) == average;" +
			"\n" +
			"\n}" +
			"\n";
	
	// Use this for initialization
	void Start () {
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = testing;	
		Tm.color = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
