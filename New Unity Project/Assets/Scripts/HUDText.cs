using UnityEngine;
using System.Collections;

public class HUDText : MonoBehaviour {

	public GameObject level;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GUIText gi = GetComponent<GUIText> ();
		TextMesh tm = level.GetComponent<TextMesh> ();
		gi.text = "Level " + tm.text;
	}
}
