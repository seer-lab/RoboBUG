using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour {

	public GameObject level;
	public GameObject starttimer;
	public int levelnum;
	public int currentlevel;
	public int starttime;
	public int points = 0;
	int secs;

	// Use this for initialization
	void Start () {
		currentlevel = 0;
		this.GetComponent<GUIText> ().text = "0";
	}
	
	// Update is called once per frame
	void Update () {
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
			case 4:
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
			case 5:
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
			case 6:
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
			}
		}
	}
}
