using UnityEngine;
using System.Collections;

public class midTest : MonoBehaviour
{

		public GameObject result;
		public string resultText = "";
		public GameObject input;
		public GameObject output;
		public bool inside = false;
		public Collider2D coll;
		float textdelay = 5f;
		private float removetext = 0.0f;

		// Use this for initialization
		void Start ()
		{
				TextMesh tm = GetComponent<TextMesh> ();
				tm.color = Color.blue;
		}
	
		// Update is called once per frame
		void Update ()
		{
				result.GetComponent<TextMesh> ().text = resultText;
				if (Time.time > removetext) {
					result.renderer.enabled = false;
				}
			

		}

		void OnTriggerEnter2D (Collider2D c)
		{
				if (c.name == "hero") {
						TextMesh tm = GetComponent<TextMesh> ();
						tm.color = Color.green;
				} else if (c.name == "projectileTest(Clone)") {
						string inputText = input.GetComponent<TextMesh> ().text;
						string outputText = output.GetComponent<TextMesh> ().text;
						if (inputText != "<INVALID INPUT>") {
								if (inputText == "") {
										result.GetComponent<TextMesh> ().color = Color.black;
										resultText = "ERROR!!!";
										result.renderer.enabled = true;
										removetext = Time.time + textdelay;
								} else if (inputText != "" && outputText != "") {
										string[] vals = inputText.Split (',');
										double mid;
										if (vals.Length % 2 == 0) {
												mid = (double)System.Convert.ToDouble (vals [vals.Length / 2 - 2]) + System.Convert.ToDouble (vals [vals.Length / 2 - 1]) / 2.0;
										} else {
												mid = System.Convert.ToDouble (vals [vals.Length / 2]);
										}
				
										if (mid == System.Convert.ToDouble (outputText)) {
												resultText = "True.";
												removetext = Time.time + textdelay;
												result.renderer.enabled = true;
										} else {
												resultText = "False.";
												removetext = Time.time + textdelay;
												result.renderer.enabled = true;	
										}
								}
						}
				}
		}

		void OnTriggerExit2D (Collider2D c)
		{
				//coll = c;
				if (c.name == "hero") {		
						TextMesh tm = GetComponent<TextMesh> ();
						tm.color = Color.blue;
				}
		}
}
