using UnityEngine;
using System.Collections;
using System.IO;

public class warper : MonoBehaviour {

	public GameObject CodeScreen;
	public string filename;
	public string linenum = "";
	public GameObject selectTools;
	public int[] tools = {0,0,0,0,0,0};
	bool toolgiven = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D c){
		if (c.name == "projectileWarp(Clone)"){
			StreamWriter sw = new StreamWriter("toollog.txt",true);
			sw.WriteLine("Warped,"+filename+","+Time.time.ToString());
			sw.Close();
			Destroy(c.gameObject);
			LevelGenerator lg = CodeScreen.GetComponent<LevelGenerator>();
			if(!toolgiven){
				toolgiven = true;
				for (int i = 0;i<6;i++){
					if (tools[i]>0){
						selectTools.GetComponent<SelectedTool>().toolget = true;
					}
					selectTools.GetComponent<SelectedTool>().toolCounts[i] += tools[i];
				}
			}

			lg.BuildLevel(@"leveldata\" + filename, true, linenum);
		}
	}
}
