using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour {

	public GameObject level;
	public GameObject starttimer;
	public int levelnum;
	public int currentlevel;
	public int starttime;
	public int points = 0;
	public GameObject falsepositive;
	int secs;

	// Use this for initialization
	void Start () {
		currentlevel = 0;
		this.GetComponent<GUIText> ().text = "0";
	}
	
	// Update is called once per frame
	void Update () {
		if (falsepositive.GetComponent<TextMesh> ().text == "Caught") {
			points -= 50;
			falsepositive.GetComponent<TextMesh> ().text = "Pointed";
		}
		this.GetComponent<GUIText> ().text = System.Convert.ToString (points) + " points";
		levelnum = System.Convert.ToInt16(level.GetComponent<TextMesh> ().text);
		if (levelnum != currentlevel) {
			currentlevel = levelnum;
			switch(levelnum){
			case 1:
				starttime = (int)Time.time;
				starttimer.GetComponent<GUIText>().text = "Level " + System.Convert.ToString(levelnum) + " start time = " + System.Convert.ToString((int)Time.time/60) + ":";
				secs = (int)Time.time%60;
				if (secs < 10){
					starttimer.GetComponent<GUIText>().text += "0" + System.Convert.ToString(secs);
				}
				else{
					starttimer.GetComponent<GUIText>().text += System.Convert.ToString(secs);
				}
				break;
			case 2:
				points += Mathf.Max(50,(300-(int) Time.time - starttime));
				starttime = (int)Time.time;
				starttimer.GetComponent<GUIText>().text = "Level " + System.Convert.ToString(levelnum) + " start time = " + System.Convert.ToString((int)Time.time/60) + ":";
				secs = (int)Time.time%60;
				if (secs < 10){
					starttimer.GetComponent<GUIText>().text += "0" + System.Convert.ToString(secs);
				}
				else{
					starttimer.GetComponent<GUIText>().text += System.Convert.ToString(secs);
				}
				break;
			case 3:
				points += Mathf.Max(50,(300-(int) Time.time - starttime))*2;
				starttime = (int)Time.time;
				starttimer.GetComponent<GUIText>().text = "Level " + System.Convert.ToString(levelnum) + " start time = " + System.Convert.ToString((int)Time.time/60) + ":";
				secs = (int)Time.time%60;
				if (secs < 10){
					starttimer.GetComponent<GUIText>().text += "0" + System.Convert.ToString(secs);
				}
				else{
					starttimer.GetComponent<GUIText>().text += System.Convert.ToString(secs);
				}				
				break;
			case 4:
				points += Mathf.Max(50,(300-(int) Time.time - starttime))*3;
				starttime = (int)Time.time;
				starttimer.GetComponent<GUIText>().text = "Level " + System.Convert.ToString(levelnum) + " start time = " + System.Convert.ToString((int)Time.time/60) + ":";
				secs = (int)Time.time%60;
				if (secs < 10){
					starttimer.GetComponent<GUIText>().text += "0" + System.Convert.ToString(secs);
				}
				else{
					starttimer.GetComponent<GUIText>().text += System.Convert.ToString(secs);
				}				
				break;
			case 5:
				points += Mathf.Max(50,(300-(int) Time.time - starttime))*4;
				starttime = (int)Time.time;
				starttimer.GetComponent<GUIText>().text = "Level " + System.Convert.ToString(levelnum) + " start time = " + System.Convert.ToString((int)Time.time/60) + ":";
				secs = (int)Time.time%60;
				if (secs < 10){
					starttimer.GetComponent<GUIText>().text += "0" + System.Convert.ToString(secs);
				}
				else{
					starttimer.GetComponent<GUIText>().text += System.Convert.ToString(secs);
				}				
				break;
			case 6:
				points += Mathf.Max(50,(300-(int) Time.time - starttime))*5;
				starttime = (int)Time.time;
				starttimer.GetComponent<GUIText>().text = "Level " + System.Convert.ToString(levelnum) + " start time = " + System.Convert.ToString((int)Time.time/60) + ":";
				secs = (int)Time.time%60;
				if (secs < 10){
					starttimer.GetComponent<GUIText>().text += "0" + System.Convert.ToString(secs);
				}
				else{
					starttimer.GetComponent<GUIText>().text += System.Convert.ToString(secs);
				}				
				break;
			case 7:
				points += Mathf.Max(50,(300-(int) Time.time - starttime))*6;
				starttime = (int)Time.time;
				starttimer.GetComponent<GUIText>().text = "Level " + System.Convert.ToString(levelnum-1) + " end time = " + System.Convert.ToString((int)Time.time/60) + ":";
				secs = (int)Time.time%60;
				if (secs < 10){
					starttimer.GetComponent<GUIText>().text += "0" + System.Convert.ToString(secs);
				}
				else{
					starttimer.GetComponent<GUIText>().text += System.Convert.ToString(secs);
				}				
				break;
			}
		}
	}
}
