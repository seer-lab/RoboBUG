using UnityEngine;
using System.Collections;

public class l4Return : MonoBehaviour {
	
	public BoxCollider2D destination;
	public bool inside = false;
	public Collider2D coll;
	public string colorTable;

	// Use this for initialization
	void Start () {
		TextMesh tm = GetComponent<TextMesh>();
		tm.color = Color.blue;
		tm.text = "coltab[" + colorTable.ToUpper () + "].table = " + colorTable + "tab;" +
						"\n\n coltab[" + colorTable.ToUpper () + "].tabsize = sizeof(" + colorTable + "tab) / sizeof(" + colorTable + "tab[0]);";
	}
	
	// Update is called once per frame
	void Update () {
		TextMesh tm = GetComponent<TextMesh>();
		if (tm.color != Color.grey) {
			if (inside){
				if (Input.GetButtonDown("Jump") && coll.attachedRigidbody){
					coll.transform.position = new Vector3 (destination.transform.position.x+1f, destination.transform.position.y, 0); 
				}
			}
		}
	}
	void OnTriggerEnter2D(Collider2D c){
		TextMesh tm = GetComponent<TextMesh> ();
			if (c.name == "projectile(Clone)") {
			if (tm.color.ToString() == "RGBA(0.502, 0.502, 0.502, 1.000)")
				{
					tm.color = Color.blue;
				}
				else{
					tm.color = Color.grey;
				}
			} 
			else {
				if (tm.color == Color.blue){
				inside = true;
				coll = c;
				tm.color = Color.green;
			}
		}
	}

	void OnTriggerExit2D(Collider2D c){
		TextMesh tm = GetComponent<TextMesh>();
		if (tm.color == Color.green && c.name != "projectile(Clone)") {
						inside = false;
						tm.color = Color.blue;
				}
	}
}
