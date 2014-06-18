using UnityEngine;
using System.Collections;

public class sidebarbugcatcher : MonoBehaviour {

	public GameObject level;
	int levelnum;

	// Use this for initialization
	void Start () {
		GUIText tm = GetComponent<GUIText> ();
		tm.text = "";
		this.GetComponent<GUIText> ().color = Color.green;
	}
	
	// Update is called once per frame
	void Update () {
		levelnum = System.Convert.ToInt16(level.GetComponent<TextMesh> ().text);
		GUIText tm = GetComponent<GUIText> ();
		if (levelnum > 0 && levelnum != 2 && levelnum < 100) {
						tm.text = "1. Bugcatcher";
				} else {
						tm.text = "";
				}

			if (Input.GetKeyDown("0")) {this.GetComponent<GUIText>().color = Color.black;
			}
			if (Input.GetKeyDown("1")) {this.GetComponent<GUIText>().color = Color.green;
			}
			if (Input.GetKeyDown("2")) {this.GetComponent<GUIText>().color = Color.black;
			}
			if (Input.GetKeyDown("3")) {this.GetComponent<GUIText>().color = Color.black;
			}
			if (Input.GetKeyDown("4")) {this.GetComponent<GUIText>().color = Color.black;
			}
			if (Input.GetKeyDown("5")) {this.GetComponent<GUIText>().color = Color.black;
			}
			if (Input.GetKeyDown("6")) {this.GetComponent<GUIText>().color = Color.black;
			}
		}
}
