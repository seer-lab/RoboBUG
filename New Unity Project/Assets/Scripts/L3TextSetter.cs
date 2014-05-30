using UnityEngine;
using System.Collections;

public class L3TextSetter : MonoBehaviour {

	string printing = "" +
		"\n" +
		"\n                <stdio.h>  " +
		"\n                <conio.h> \n " +
		"\n           Prioritize(       priorities[],        numOfSystems) " +
		"\n{" +
		"\n" +
		"\n               min=priorities[0],max=priorities[0]; " +
		"\n\n	             i=1;i<numOfSystems;i++) " +
		"\n	{  " +
		"\n\n	   min =                        (min, priorities[i]);" + 
		"\n\n	   max =                        (max, priorities[i]);" +
		"\n\n	} " +
		"\n\n                 [min, max];" +
		"\n}  ";

	// Use this for initialization
	void Start () {
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = printing;	
		Tm.color = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
