using UnityEngine;
using System.Collections;

public class l3bug : MonoBehaviour {

	public GameObject l3output;
	bool firstguess = true;

	// Use this for initialization
	void Start () {
		this.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D p){
		if (p.name == "projectileBug(Clone)") {
			if (firstguess){
				TextMesh tm = l3output.GetComponent<TextMesh>();
				tm.text = "The bug is that the min is wrong" +
					"\nThe bug is that the max is wrong" +
					"\nThe bug is because of the number 4" +
					"\nThe bug is that the min and max get swapped" +
					"\nThe bug is that the array size is wrong" +
					"\nThe bug is that the array has invalid numbers" +
					"\nThe bug is that the loop doesn't finish" +
					"\nThe bug is that it thinks 5>6 and 2<0";
				this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y + 1.2f, 0);
				firstguess = false;
			}
			else{
				TextMesh tm = l3output.GetComponent<TextMesh>();
				tm.text = "Correct!";
			}
		}
	}
}
