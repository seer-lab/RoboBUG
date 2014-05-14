using UnityEngine;
using System.Collections;

public class l6codetest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = "//To Find furthest, closest, and most opposite color  " +
						"\n//Input : color " +
						"\n" +
						"\nstring furthest (int[] color);" +
						"\nstring closest (int[] color);" +
						"\nstring opposite (int[] color);" +
						"\n" +
						"\nstring furthest (){" +
						"\n	int color[] = " +
						"\n" +
				//		"\n	return sumCalc(values[]) == total;" +
						"\n" +
						"\n}" +
						"\n" +
						"\nstring closest ();{" +
						"\n	int color[] = " +
						"\n" +
				//		"\n	return medianCalc(values[]) == mid;" +
						"\n" +
						"\n}";
	}
}
