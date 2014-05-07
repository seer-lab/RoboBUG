using UnityEngine;
using System.Collections;

public class ValueGetter : MonoBehaviour {
	
	public GameObject value;
	public string valueText = "";
	public Collider2D coll;
	public bool minusOkay = true;
	public bool decOkay = true;
	public bool inside = false;
	
	// Use this for initialization
	void Start () {
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = "Value = \n\n;";
	}
	
	// Update is called once per frame
	void Update () {
		value.GetComponent<TextMesh> ().text = valueText;
		if (inside) {
				if (Input.GetKeyDown ("1")) {
				valueText += "1";minusOkay = false;
				} else if (Input.GetKeyDown ("2")) {
				valueText += "2";minusOkay = false;
				} else if (Input.GetKeyDown ("3")) {
				valueText += "3";minusOkay = false;
				} else if (Input.GetKeyDown ("4")) {
				valueText += "4";minusOkay = false;
				} else if (Input.GetKeyDown ("5")) {
				valueText += "5";minusOkay = false;
				} else if (Input.GetKeyDown ("6")) {
				minusOkay = false;
					valueText += "6";
				} else if (Input.GetKeyDown ("7")) {
				minusOkay = false;
					valueText += "7";
				} else if (Input.GetKeyDown ("8")) {
				minusOkay = false;
					valueText += "8";
				} else if (Input.GetKeyDown ("9")) {
				minusOkay = false;
					valueText += "9";
				} else if (Input.GetKeyDown ("0")) {
				minusOkay = false;
					valueText += "0";
				} 
			 if (Input.GetKeyDown("-") && minusOkay){
				minusOkay = false;
				valueText += "-";
			}
			if (Input.GetKeyDown(".") && decOkay){
				minusOkay = false;
				decOkay = false;
				valueText += ".";
			}
			 if (Input.GetKeyDown ("backspace")) {
				valueText = "";
				minusOkay = true;
				decOkay = true;
			}	
		}
	}
	void OnTriggerEnter2D(Collider2D c){
		inside = true;
		coll = c;
	}
	void OnTriggerExit2D(Collider2D c){
		inside = false;
	}
}
