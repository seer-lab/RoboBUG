using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int minutes = (int)Time.time / 60;
		int secs = (int)Time.time%60;
		string secstring = "";
		if (secs < 10) {
			secstring = "0" + System.Convert.ToString (secs);
		}
		else{
			secstring = System.Convert.ToString (secs);
		}
		this.GetComponent<GUIText> ().text = "Current Time = " + System.Convert.ToString (minutes) + ":" + secstring;
	}
}
