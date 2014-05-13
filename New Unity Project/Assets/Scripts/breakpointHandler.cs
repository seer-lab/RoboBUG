using UnityEngine;
using System.Collections;

public class breakpointHandler : MonoBehaviour {

	public GameObject[] breakpoints;
	public GameObject[] debugtexts;
	public int[] breakstate;
	public int col1num = 0;
	public int col2num = 15;
	public int stepnum = 0;
	public bool stop = false;

	public string teststr;

	public string namedcolors = "\"aqua\",\"0\",\"255\",\"255\"},{\"black\",\"0\",\"0\",\"0\"},{\"blue\",\"0\",\"0\",\"255\"},{\"fuchsia\",\"255\",\"0\",\"255\"},{\"gray\",\"128\",\"128\",\"128\"},{\"green\",\"0\",\"128\",\"0\"},{\"lime\",\"0\",\"255\",\"0\"},{\"maroon\",\"128\",\"0\",\"0\"},{\"navy\",\"0\",\"0\",\"128\"},{\"olive\",\"128\",\"128\",\"0\"},{\"purple\",\"128\",\"0\",\"128\"},{\"red\",\"255\",\"0\",\"0\"},{\"silver\",\"192\",\"192\",\"192\"},{\"teal\",\"0\",\"128\",\"128\"},{\"white\",\"255\",\"255\",\"255\"},{\"yellow\",\"255\",\"255\",\"0\"";
	public string[] colors;
	public string[] col1;
	public string[] col2;



	// Use this for initialization
	void Start () {
		colors = namedcolors.Replace ("},{", "@").Split('@');
		//colors = namedcolors.Split('@');
		breakstate = new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
		stepnum -= 1;
	}
	
	// Update is called once per frame
	void Update () {
		for (int i =0;i<9;i++){
			SpriteRenderer sr = breakpoints[i].GetComponent<SpriteRenderer>();
			if (sr.color == Color.black){
				breakstate[i] = 0;
			}
			else if (sr.color == Color.red){
				breakstate[i]=1;
			}
			else{
				breakstate[i]=2;
			}
		}
		SpriteRenderer slf = GetComponent<SpriteRenderer> ();
		if (slf.color == Color.magenta) {
			slf.color = Color.black;
			while(col1num < 15 && !stop){
				while(col2num > col1num && !stop){
					if (stepnum>=0){step();
						SpriteRenderer current = breakpoints[stepnum].GetComponent<SpriteRenderer>();
						if (breakstate[stepnum]==2){
							current.color = Color.red;
						}
					}
					stepnum++;
					if (stepnum == 9){
						stepnum = 4;
						col2num--;
						if (col2num == col1num){
							stepnum = 0;
							col2num = 15;
							col1num++;
						}
					}
					SpriteRenderer sr = breakpoints[stepnum].GetComponent<SpriteRenderer>();
					if (breakstate[stepnum]==1){
						sr.color = Color.magenta;
						stop = true;
					}
				}
			}
			if (col1num == 15){
				for (int i =0;i<9;i++){
					SpriteRenderer sr = breakpoints[i].GetComponent<SpriteRenderer>();
					if (sr.color == Color.magenta){
						sr.color = Color.red;
					}
				}
				col1num = 0;
				col2num = 15;
				stepnum = 0;
			}
			stop = false;
		}
	}
	void step(){
		switch (stepnum) {
		case 0:
			col1 = colors[col1num].Split(',');
			debugtexts[7].GetComponent<GUIText>().text = "Color 1 = " + col1[0];
			break;
		case 1:
			debugtexts[0].GetComponent<GUIText>().text = "red 1 = " + col1[1];
			break;
		case 2:
			debugtexts[1].GetComponent<GUIText>().text = "green 1 = " + col1[2];
			break;
		case 3:
			debugtexts[2].GetComponent<GUIText>().text = "blue 1 = " + col1[3];
			break;
		case 4:
			col2 = colors[col2num].Split(',');
			debugtexts[8].GetComponent<GUIText>().text = "Color 2 = " + col2[0];
			break;
		case 5:
			debugtexts[3].GetComponent<GUIText>().text = "red 2 = " + col2[1];
			break;
		case 6:
			debugtexts[4].GetComponent<GUIText>().text = "green 2 = " + col2[2];
			break;
		case 7:
			debugtexts[5].GetComponent<GUIText>().text = "blue 2 = " + col2[3];
			break;
		case 8:
			debugtexts[6].GetComponent<GUIText>().text = "brighter = " + brighter(col1,col2);
			break;
		}
	}

	string brighter(string[] col1, string[] col2){

		int sum1 = (int) System.Convert.ToInt32(col1[2].Replace("\"", "")) + System.Convert.ToInt32(col1[3].Replace("\"", ""));
		int sum2 = (int) System.Convert.ToInt32(col2[2].Replace("\"", "")) + System.Convert.ToInt32(col2[3].Replace("\"", ""));
		if (sum1 > sum2) {
			return col1[0];
		}
		else{
			return col2[0];
		}
	}

	void OnTriggerEnter2D(Collider2D c){
		if (c.name == "projectile(Clone)") {
				SpriteRenderer nxt = GetComponent<SpriteRenderer>();
				nxt.color = Color.magenta;

		}
	}
}
