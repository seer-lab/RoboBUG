using UnityEngine;
using System.Collections;

public class L1TextSetter : MonoBehaviour {

	string tracing = "" +
			"\n " +
			"\n" +
			"\n	" +
			"\n " +
			"\n " +
			"\n       avgForce(        forces[],       numOfForces) " +
			"\n{  " +
			"\n             sum=0,i; " +
			"\n              avgf; " +
			"\n    " +
			"\n          (i=0;i<numOfForces;i++) " +
			"\n    { " +
			"\n		sum=sum+forces[i];" +
			"\n		avgf=             (sum/n);" +
			"\n    }  " +
			"\n		avgf++;" +
			"\n                   avgf;" +
			"\n    } " +
			"\n} " +
			"\n" +
			"\n";

	// Use this for initialization
	void Start () {
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = tracing;	
		Tm.color = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
