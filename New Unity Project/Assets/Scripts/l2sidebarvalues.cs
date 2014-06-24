using UnityEngine;
using System.Collections;

public class l2sidebarvalues : MonoBehaviour {

	public GameObject text;
	public GameObject level;

	// Use this for initialization
	void Start () {
		GetComponent<GUIText> ().text = "";
	}
	
	// Update is called once per frame
	void Update () {
		int levelnum = System.Convert.ToInt16(level.GetComponent<TextMesh> ().text);
		if (levelnum == 2) {
						GetComponent<GUIText> ().text = text.GetComponent<TextMesh> ().text;
				} else {
			GetComponent<GUIText> ().text = "";
				}
	}
}
