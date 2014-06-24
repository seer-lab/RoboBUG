using UnityEngine;
using System.Collections;

public class L2TextSetterK : MonoBehaviour {
	
	string testing = "\nint                             int" +
		"\n" +
			"\n\n\nint                          int" +
			"\n" +
			"\n\n\nfloat                       float" +
			"\n" +
			"\nint\n\nint\n" +
			"\nbool " +
			"\n        int" +
			"\n        int" +
			//		"\n	return sumCalc(values[]) == total;" +
			"\n" +
			"\n" +
			"" +
			"\nbool " +
			"\n        int " +
			"\n        int " +
			//		"\n	return medianCalc(values[]) == mid;" +
			"\n" +
			"\n" +
			"\nbool " +
			"\n        float" +
			"\n        float" +
			//		"\n	return avgCalc(values[]) == average;" +
			"\n" +
			"\n" +
			"\n";
	
	// Use this for initialization
	void Start () {
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = testing;	
		Tm.color = Color.blue;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
