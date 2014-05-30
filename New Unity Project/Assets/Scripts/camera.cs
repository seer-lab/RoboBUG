using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	public GameObject target;

	//levels/screens
	public GameObject l10;
	public GameObject l1;

	public GameObject l20;
	public GameObject l2;
	public GameObject l2a;
	public GameObject l2b;
	public GameObject l2c;
	public GameObject l2d;
	public GameObject l2e;
	public GameObject l2f;

	public GameObject l30;
	public GameObject l3;
	public GameObject l3min;

	public GameObject l40;
	public GameObject l4;
	public GameObject l4bla; //1
	public GameObject l4blu; //2
	public GameObject l4br; //3
	public GameObject l4c; //4
	public GameObject l4gree; //5
	public GameObject l4grey; //6
	public GameObject l4m; //7
	public GameObject l4n; //8
	public GameObject l4r; //9
	public GameObject l4o; //10
	public GameObject l4w; //11
	public GameObject l4y; //12

	public GameObject l5;
	public GameObject l50;

	public GameObject l6;
	public GameObject l60;
	public GameObject l6a;
	public GameObject l6b;
	public GameObject l6c;
	public GameObject l6d;

	public GameObject l7;

	public GameObject end;

	public GameObject levelText;

	public GameObject l2Objective1;
	public GameObject l2Objective2;
	public GameObject l2Objective3;
	public GameObject l3Report;

	public GameObject l5report;

	public GameObject l6report;

	public GameObject lastbug;
	public GameObject verylastbug;

	public bool xvalue = true;
	public int level = -1;
	public int stars = 0;

	Vector3 startScreen = new Vector3 (27, 4, -5f);
	Vector3 instructScreen = new Vector3 (28, -6, -5f);
	Vector3 level1Start = new Vector3(-3f,15.12f,0);
	Vector3 level3Start = new Vector3(-99f,-21.8f,0);
	Vector3 level4Start = new Vector3(-138f,-28.8f,0);
	Vector3 level5Start = new Vector3(-248f,104.2f,0);
	Vector3 level6Start = new Vector3(-286f,73.2f,0);
	Vector3 level6cStart = new Vector3(-343f,109.2f,0);
	Vector3 lastlevelstart = new Vector3 (-424,80,0);

	int level6testVBoundary = -295;
	int level6testHBoundary = 50;

	int level6debugVBoundary = -358;

	int level2LeftBoundary = -37;
	int level21TopBoundary = -8;
	int level23TopBoundary = 11;
	int level22LeftBoundary = -55;

	int level4topVBoundary = 86;
	int level4midVBoundary = 36;
	int level4botVBoundary = -16;
	int level4lefHBoundary = -175;
	int level4midHBoundary = -135;
	int level4rigHBoundary = -95;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		TextMesh tm = levelText.GetComponent<TextMesh> ();
		//level determinants
		//level 1
		if (target.transform.position.x < -15 && level==1) {
			level = 20;
			tm.text = "2";
		}

		//level 2
		if (level == 2) {
			if (target.transform.position.x < level22LeftBoundary){
				if (target.transform.position.y > level23TopBoundary){
					level = 25;
				}
				else if (target.transform.position.y > level21TopBoundary){
					level = 23;
				}
				else{
					level = 21;				
				}
			}
			else if (target.transform.position.x < level2LeftBoundary){
				if (target.transform.position.y > level23TopBoundary){
					level = 26;
				}
				else if (target.transform.position.y > level21TopBoundary){
					level = 24;
				}
				else{
					level = 22;				
				}
			}
		}
		if (21<=level && level <=26 && target.transform.position.x > level2LeftBoundary){
			level = 2;
		}

		//level 3
		if (level == 2 && l2Objective1.GetComponent<TextMesh>().text == "ERROR!!!" && l2Objective2.GetComponent<TextMesh>().text == "ERROR!!!" && l2Objective3.GetComponent<TextMesh>().text == "ERROR!!!"){
			level = 30;
			tm.text = "3";
		}

		//level 4
		if (level == 3 && l3Report.GetComponent<TextMesh>().text == "Correct!"){
			level = 40;
			tm.text = "4";
		}
		if (level == 4) {
			if (target.transform.position.y < level4botVBoundary){
				if (target.transform.position.x < level4lefHBoundary){level=412;}
			}
			else if (target.transform.position.y < level4midVBoundary){
				if (target.transform.position.x < level4lefHBoundary){level=49;}
				else if (target.transform.position.x < level4midHBoundary) {level=410;}
				else{level=411;}
			}
			else if (target.transform.position.y < level4topVBoundary){
				if (target.transform.position.x < level4lefHBoundary){level=45;}
				else if (target.transform.position.x < level4midHBoundary) {level=46;}
				else if (target.transform.position.x < level4rigHBoundary) {level=47;}
				else{level=48;}
			}
			else {
				if (target.transform.position.x < level4lefHBoundary){level=41;				}
				else if (target.transform.position.x < level4midHBoundary) {level=42;}
				else if (target.transform.position.x < level4rigHBoundary) {level=43;}
				else{level=44;}
			}
		}
		if ((41 <= level && level <= 49) || (410 <= level && level <= 412)) {
			if (target.transform.position.x > 0){tm.text = "5";level = 50;}
			else if (target.transform.position.y < level4botVBoundary){
				if (target.transform.position.x > level4lefHBoundary){level=4;}
			}
		
		}

		if (level == 5){
			if (l5report.GetComponent<TextMesh>().text == "Correct!"){level = 60; tm.text = "6";}
		}

		if (level == 6) {
			if (target.transform.position.x < level6testVBoundary){
				if (target.transform.position.y > level6testHBoundary){
					level = 62;
				}
				else{
					level = 61;
				}
			}
		}
		if (level == 61 || level == 62) {
			if (target.transform.position.x > level6testVBoundary){
				level = 6;
			}
		}

		if (level == 6 && l6report.renderer.enabled == true){
			level = 63;
			target.transform.position = level6cStart;
		}

		if (level == 63 && target.transform.position.x < level6debugVBoundary){
			level = 64;
		}
		if (level == 64 && target.transform.position.x > level6debugVBoundary){
			level = 63;
		}

		if (level == 63 && lastbug.renderer.enabled == true) {
			level = 7;
			target.transform.position = lastlevelstart;
		}

		if (level == 7 && verylastbug.renderer.enabled == true) {
			level = 100;
			tm.text = "7";
			}



		//camera positions
		switch (level){ 
		case -1:
			tm.text = "0";
			camera.transform.position = startScreen;
			camera.orthographicSize = 4;
			if (Input.GetButtonDown("Jump")){
				level = 0;
			}
			if (Input.GetKeyDown("3")){
				level = 30;
				tm.text = "3";
			}
			if (Input.GetKeyDown("4")){
				level = 40;
				tm.text = "4";
			}
			if (Input.GetKeyDown("5")){
				level = 50;
				tm.text = "5";
			}
			if (Input.GetKeyDown("6")){
				level = 60;
				tm.text = "6";
			}
			break;
		case 0:
			camera.transform.position = instructScreen;
			camera.orthographicSize = 6;
			if (Input.GetButtonDown("Jump")){
				level = 10;
				tm.text = "1";
			}
			break;
		case 10:
			camera.transform.position = new Vector3 (l10.transform.position.x, l10.transform.position.y, -5f);
			camera.orthographicSize = 6;
			if (Input.GetButtonDown("Jump")){
				level = 1;
				target.transform.position = level1Start;
			}
			break;
		case 1:
			camera.transform.position = new Vector3 (l1.transform.position.x+2, target.transform.position.y, -5f);
			camera.orthographicSize = 4;
			break;


		case 20:
			camera.transform.position = new Vector3 (l20.transform.position.x, l20.transform.position.y, -5f);
			camera.orthographicSize = 6;
			if (Input.GetButtonDown("Jump")){
				level = 2;
			}
			break;
		case 2:
			camera.transform.position = new Vector3 (l2.transform.position.x+2, target.transform.position.y, -5f);
			camera.orthographicSize = 4;
			break;
		case 21:
			camera.transform.position = new Vector3 (l2a.transform.position.x, l2a.transform.position.y, -5f);
			camera.orthographicSize = 6;
			break;
		case 22:
			camera.transform.position = new Vector3 (l2b.transform.position.x, l2b.transform.position.y, -5f);
			camera.orthographicSize = 6;
			break;
		case 23:
			camera.transform.position = new Vector3 (l2c.transform.position.x, l2c.transform.position.y, -5f);
			camera.orthographicSize = 6;
			break;
		case 24:
			camera.transform.position = new Vector3 (l2d.transform.position.x, l2d.transform.position.y, -5f);;
			camera.orthographicSize = 6;
			break;
		case 25:
			camera.transform.position = new Vector3 (l2e.transform.position.x, l2e.transform.position.y, -5f);;
			camera.orthographicSize = 6;
			break;
		case 26:
			camera.transform.position = new Vector3 (l2f.transform.position.x, l2f.transform.position.y, -5f);;
			camera.orthographicSize = 6;
			break;


		case 30:
			camera.transform.position = new Vector3 (l30.transform.position.x, l30.transform.position.y, -5f);
			camera.orthographicSize = 6;
			if (Input.GetButtonDown("Jump")){
				level = 3;
				target.transform.position = level3Start;
			}
			break;
		case 3:
			camera.transform.position = new Vector3 (l3.transform.position.x+2, target.transform.position.y, -5f);;
			camera.orthographicSize = 4;
			break;


		case 40:
			camera.transform.position = new Vector3 (l40.transform.position.x, l40.transform.position.y, -5f);
			camera.orthographicSize = 6;
			if (Input.GetButtonDown("Jump")){
				level = 4;
				target.transform.position = level4Start;
			}
			break;
		case 4:
			camera.transform.position = new Vector3 (l4.transform.position.x+2, target.transform.position.y, -5f);;
			camera.orthographicSize = 4;
			break;
		case 41:
			camera.transform.position = new Vector3 (l4bla.transform.position.x+2, target.transform.position.y, -5f);;
			camera.orthographicSize = 4;
			break;
		case 42:
			camera.transform.position = new Vector3 (l4blu.transform.position.x+2, target.transform.position.y, -5f);;
			camera.orthographicSize = 4;
			break;
		case 43:
			camera.transform.position = new Vector3 (l4br.transform.position.x+2, target.transform.position.y, -5f);;
			camera.orthographicSize = 4;
			break;
		case 44:
			camera.transform.position = new Vector3 (l4c.transform.position.x+2, target.transform.position.y, -5f);;
			camera.orthographicSize = 4;
			break;
		case 45:
			camera.transform.position = new Vector3 (l4gree.transform.position.x+2, target.transform.position.y, -5f);;
			camera.orthographicSize = 4;
			break;
		case 46:
			camera.transform.position = new Vector3 (l4grey.transform.position.x+2, target.transform.position.y, -5f);;
			camera.orthographicSize = 4;
			break;
		case 47:
			camera.transform.position = new Vector3 (l4m.transform.position.x+2, target.transform.position.y, -5f);;
			camera.orthographicSize = 4;
			break;
		case 48:
			camera.transform.position = new Vector3 (l4n.transform.position.x+2, target.transform.position.y, -5f);;
			camera.orthographicSize = 4;
			break;
		case 49:
			camera.transform.position = new Vector3 (l4o.transform.position.x+2, target.transform.position.y, -5f);;
			camera.orthographicSize = 4;
			break;
		case 410:
			camera.transform.position = new Vector3 (l4r.transform.position.x+2, target.transform.position.y, -5f);;
			camera.orthographicSize = 4;
			break;
		case 411:
			camera.transform.position = new Vector3 (l4w.transform.position.x+2, target.transform.position.y, -5f);;
			camera.orthographicSize = 4;
			break;
		case 412:
			camera.transform.position = new Vector3 (l4y.transform.position.x+2, target.transform.position.y, -5f);;
			camera.orthographicSize = 4;
			break;


		case 5:
			camera.transform.position = new Vector3 (l5.transform.position.x+2, target.transform.position.y, -5f);;
			camera.orthographicSize = 5;
			break;
		case 50:
			camera.transform.position = new Vector3 (l50.transform.position.x, l50.transform.position.y, -5f);
			camera.orthographicSize = 6;
			if (Input.GetButtonDown("Jump")){
				level = 5;
				target.transform.position = level5Start;
			}
			break;

		case 6:
			camera.transform.position = new Vector3 (l6.transform.position.x+2, target.transform.position.y, -5f);;
			camera.orthographicSize = 5;
			break;
		case 60:
			camera.transform.position = new Vector3 (l60.transform.position.x, l60.transform.position.y, -5f);
			camera.orthographicSize = 6;
			if (Input.GetButtonDown("Jump")){
				level = 6;
				target.transform.position = level6Start;
			}
			break;
		case 61:
			camera.transform.position = new Vector3 (l6a.transform.position.x, l6a.transform.position.y, -5f);
			camera.orthographicSize = 6;
			break;
		case 62:
			camera.transform.position = new Vector3 (l6b.transform.position.x, l6b.transform.position.y, -5f);
			camera.orthographicSize = 6;
			break;
		case 63:
			camera.transform.position = new Vector3 (l6c.transform.position.x+2, target.transform.position.y, -5f);;
			camera.orthographicSize = 5;
			break;
		case 64:
			camera.transform.position = new Vector3 (l6d.transform.position.x, target.transform.position.y, -5f);
			camera.orthographicSize = 5;
			break;

		case 7:
			camera.transform.position = new Vector3 (l7.transform.position.x+2, target.transform.position.y, -5f);
			camera.orthographicSize = 5;
			break;


		case 100:
			camera.transform.position = new Vector3 (end.transform.position.x, end.transform.position.y, -5f);;
			camera.orthographicSize = 3;
			break;
		}
	}
}
