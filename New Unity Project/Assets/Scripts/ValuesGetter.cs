using UnityEngine;
using System.Collections;

public class ValuesGetter : MonoBehaviour {

	public GameObject values;
	bool commaOkay = false;
	bool minusOkay = true;
	bool decOkay = true;
	public string valueText = "";
	public bool validInput = true;
	public Collider2D coll;

	public bool inside = false;

	// Use this for initialization
	void Start () {
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = "Values = [\n\n];";
	}
	
	// Update is called once per frame
	void Update () {
				values.GetComponent<TextMesh> ().text = valueText;
				if (inside) {
					if (validInput && coll.attachedRigidbody){
						if (Input.GetKeyDown ("1")) {
								commaOkay = true;
								minusOkay = false;
								valueText += "1";
						} else if (Input.GetKeyDown ("2")) {
								commaOkay = true;
								minusOkay = false;
								valueText += "2";
						} else if (Input.GetKeyDown ("3")) {
								commaOkay = true;
								minusOkay = false;
								valueText += "3";
						} else if (Input.GetKeyDown ("4")) {
								commaOkay = true;
								minusOkay = false; 
								valueText += "4";
						} else if (Input.GetKeyDown ("5")) {
								commaOkay = true;
								minusOkay = false;
								valueText += "5";
						} else if (Input.GetKeyDown ("6")) {
								commaOkay = true;
								minusOkay = false;
								valueText += "6";
						} else if (Input.GetKeyDown ("7")) {
								commaOkay = true;
								minusOkay = false;
								valueText += "7";
						} else if (Input.GetKeyDown ("8")) {
								commaOkay = true;
								minusOkay = false;
								valueText += "8";
						} else if (Input.GetKeyDown ("9")) {
								commaOkay = true;
								minusOkay = false;
								valueText += "9";
						} else if (Input.GetKeyDown ("0")) {
								commaOkay = true;
								minusOkay = false;
								valueText += "0";
						} else if (Input.GetKeyDown ("-")) {
								if (!minusOkay) {
									validInput = false;
									valueText = "<INVALID INPUT>";
								}
								else{
								minusOkay = false;
								commaOkay = false;
								valueText += "-";
								}
						} else if (Input.GetKeyDown (".")) {
							if (!decOkay) {
								validInput = false;
								valueText = "<INVALID INPUT>";
							}
							else{
								minusOkay = false;
								commaOkay = false;
								decOkay = false;
								valueText += ".";
							}
						}else if (Input.GetKeyDown (",")) {
							if (!commaOkay) {
									validInput = false;
									valueText = "<INVALID INPUT>";
							}
							else{
							commaOkay = false;
							minusOkay = true;
							decOkay = true;
							valueText += ",";
							}
						}
					} 
					if (Input.GetKeyDown ("backspace")) {
						commaOkay = false;
						minusOkay = true;
						validInput = true;
						valueText = "";
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
