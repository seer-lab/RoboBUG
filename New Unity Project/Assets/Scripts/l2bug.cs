using UnityEngine;
using System.Collections;

public class l2bug : MonoBehaviour {

	public GameObject text;
	bool played = false;

	// Use this for initialization
	void Start () {
		this.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (text.GetComponent<TextMesh>().text == "ERROR!!!"){
			this.renderer.enabled = true;
			GetComponent<Animator>().SetBool("Dying", true);
			if (!played){
				GetComponent<AudioSource>().Play();
				played = true;
			}
		}
	}
	
}
