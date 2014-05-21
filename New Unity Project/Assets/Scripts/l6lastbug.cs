using UnityEngine;
using System.Collections;

public class l6lastbug : MonoBehaviour {

	public GameObject l6dblack;
	public GameObject col2num;
	public GameObject breakpoint;

	// Use this for initialization
	void Start () {
		this.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D p){
		if (p.name == "projectileBug(Clone)") {
			if (l6dblack.GetComponent<TextMesh>().text=="{ \"black\",     0,   0,   0 },"){
				if (System.Convert.ToInt32(col2num.GetComponent<GUIText>().text.Substring(12))%6==0){
					if (breakpoint.GetComponent<SpriteRenderer>().color != Color.black){
						this.renderer.enabled = true;
					}
				}
			}
		}
	}
}
