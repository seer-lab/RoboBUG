using UnityEngine;
using System.Collections;

public class sumTest : MonoBehaviour {

	public GameObject result;
	public string resultText = "";
	public GameObject input;
	public GameObject output;
	public bool inside = false;
	public Collider2D coll;

	// Use this for initialization
	void Start () {
		TextMesh tm = GetComponent<TextMesh>();
		tm.color = Color.blue;
	}
	
	// Update is called once per frame
	void Update () {
		result.GetComponent<TextMesh> ().text = resultText;
		if (inside) {
			if (coll.attachedRigidbody) {
				if (Input.GetButtonDown("Jump")){
					string inputText = input.GetComponent<TextMesh> ().text;
					string outputText = output.GetComponent<TextMesh> ().text;
					if (inputText != "" && outputText != "" && inputText != "<INVALID INPUT>"){
						if (inputText.Contains("-")){
							result.GetComponent<TextMesh>().color = Color.black;
							resultText = "ERROR!!!";
						}
						else{
							string[] vals = inputText.Split(',');
							int sum = 0;
							foreach (string s in vals){
								sum += System.Convert.ToInt32(s);
							}
							if (sum == System.Convert.ToDouble(outputText)){
								resultText = "True.";
							}
							else{
								resultText = "False.";
							}
						}
					}
				}
			}
		}

	}
	void OnTriggerEnter2D(Collider2D c){
		string inputText = input.GetComponent<TextMesh> ().text;
		string outputText = output.GetComponent<TextMesh> ().text;
		if (inputText != "" && outputText != "" && inputText != "<INVALID INPUT>"){
			inside = true;
			coll = c;
			TextMesh tm = GetComponent<TextMesh>();
			tm.color = Color.green;
		}
	}
	void OnTriggerExit2D(Collider2D c){
		inside = false;
		TextMesh tm = GetComponent<TextMesh>();
		tm.color = Color.blue;
	}
}
