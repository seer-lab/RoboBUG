using UnityEngine;
using System.Collections;

public class sidebarselected : MonoBehaviour {



	public GameObject level;
	int levelnum;
	public GameObject projectilecode;
	int projectilenum;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		levelnum = System.Convert.ToInt16(level.GetComponent<TextMesh> ().text);
		projectilenum = System.Convert.ToInt16(projectilecode.GetComponent<TextMesh> ().text);
		GUIText tm = GetComponent<GUIText> ();
		if (levelnum > 0 && levelnum < 6) {
						switch (projectilenum) {
						case 1:
				tm.text = "Bugcatcher";
								break;
						case 2:
				tm.text = "Tester";
								break;
						case 3:
				tm.text = "Activator";
								break;
						case 4:
				tm.text = "Breakpointer";
								break;
						case 5:
				tm.text = "Warper";
								break;
						}
				} else {
			tm.text = "";
				}
	}
}
