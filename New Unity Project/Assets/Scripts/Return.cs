using UnityEngine;
using System.Collections;

public class Return : MonoBehaviour {
	
	public BoxCollider2D destination;
	public bool inside = false;
	public Collider2D coll;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (inside){
		if (Input.GetButtonDown("Jump") && coll.attachedRigidbody){
			coll.transform.position = new Vector3 (destination.transform.position.x+1f, destination.transform.position.y, 0); 
		}
	}
	}
	void OnTriggerEnter2D(Collider2D c){
		inside = true;
		coll = c;
		TextMesh tm = GetComponent<TextMesh>();
		tm.color = Color.green;
	}

	void OnTriggerExit2D(Collider2D c){
		inside = false;
		TextMesh tm = GetComponent<TextMesh>();
		tm.color = Color.blue;
	}
}
