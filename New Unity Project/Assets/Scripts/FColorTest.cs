using UnityEngine;
using System.Collections;

public class FColorTest : MonoBehaviour
{
	
	public GameObject result;
	public string resultText = "";
	public GameObject input;
	public bool inside = false;
	public Collider2D coll;
	
	public string namedcolors = "\"aqua\",\"0\",\"255\",\"255\"},{\"black\",\"0\",\"0\",\"0\"},{\"blue\",\"0\",\"0\",\"255\"},{\"fuchsia\",\"255\",\"0\",\"255\"},{\"gray\",\"128\",\"128\",\"128\"},{\"green\",\"0\",\"128\",\"0\"},{\"lime\",\"0\",\"255\",\"0\"},{\"maroon\",\"128\",\"0\",\"0\"},{\"navy\",\"0\",\"0\",\"128\"},{\"olive\",\"128\",\"128\",\"0\"},{\"purple\",\"128\",\"0\",\"128\"},{\"red\",\"255\",\"0\",\"0\"},{\"silver\",\"192\",\"192\",\"192\"},{\"teal\",\"0\",\"128\",\"128\"},{\"white\",\"255\",\"255\",\"255\"},{\"yellow\",\"255\",\"255\",\"0\"";
	public string[] colors;
	
	// Use this for initialization
	void Start ()
	{
		TextMesh tm = GetComponent<TextMesh> ();
		tm.color = Color.blue;
		colors = namedcolors.Replace ("},{", "@").Replace ("\"", "").Split ('@');
	}
	
	// Update is called once per frame
	void Update ()
	{
		result.GetComponent<TextMesh> ().text = resultText;
		if (inside) {
			if (coll.attachedRigidbody) {
				if (Input.GetButtonDown ("Jump")) {
					string inputText = input.GetComponent<TextMesh> ().text;
					string[] color = inputText.Split (',');
					if (color.Length == 3) {
						if (color [2] != "") {
								string[] col;
								int farness = 0;
								string farcol = "white";
								foreach (string s in colors) {
									col = s.Split (',');
									int newc = (int)Mathf.Abs (System.Convert.ToInt32 (color [0]) - System.Convert.ToInt32 (col [1]));
									newc += (int)Mathf.Abs (System.Convert.ToInt32 (color [1]) - System.Convert.ToInt32 (col [2]));
									newc += (int)Mathf.Abs (System.Convert.ToInt32 (color [2]) - System.Convert.ToInt32 (col [3]));
									if (newc > farness) {
										farness = newc;
										farcol = col [0];
									} 
								}
								resultText = farcol;
						}
					}
				}
			}
		}
		
	}
	void OnTriggerEnter2D (Collider2D c)
	{
		string inputText = input.GetComponent<TextMesh> ().text;
		if (inputText != "" && inputText != "<INVALID INPUT>") {
			inside = true;
			coll = c;
			TextMesh tm = GetComponent<TextMesh> ();
			tm.color = Color.green;
		}
	}
	void OnTriggerExit2D (Collider2D c)
	{
		inside = false;
		TextMesh tm = GetComponent<TextMesh> ();
		tm.color = Color.blue;
	}
}
