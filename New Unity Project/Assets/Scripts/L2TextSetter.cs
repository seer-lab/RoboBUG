using UnityEngine;
using System.Collections;

public class L2TextSetter : MonoBehaviour {
	
	string testing = "       DistanceCalc(       distances[]);" +
		"\n" +
			"\n       EnergyCalc(       powers[]);" +
			"\n\n" +
			"\n          TempCalc(           temps[]);" +
			"\n\n" +
			"" +
			"\n         DistanceCalcTest (){" +
			"\n	       distances[] = " +
			"\n	       totalDistance = " +
			//		"\n	return sumCalc(values[]) == total;" +
			"\n" +
			"\n}" +
			"\n" +
			"\n       EnergyCalc ();{" +
			"\n	       powers[] = " +
			"\n	       powerlevel = " +
			//		"\n	return medianCalc(values[]) == mid;" +
			"\n" +
			"\n}" +
			"\n           TempCalcTest ();{" +
			"\n	          temps[] = " +
			"\n	          averageTemp = " +
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
