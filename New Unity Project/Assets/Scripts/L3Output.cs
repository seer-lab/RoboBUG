using UnityEngine;
using System.Collections;

public class L3Output : MonoBehaviour {

	string output = "";
	bool initmi = false;
	bool preminmi = false;
	bool premaxmi = false;
	bool postmaxmi = false;
	bool endmi = false;
	bool initma = false;
	bool preminma = false;
	bool premaxma = false;
	bool postmaxma = false;
	bool endma = false;

	public GameObject Tinitmi;
	public GameObject Tpreminmi;
	public GameObject Tpremaxmi;
	public GameObject Tpostmaxmi;
	public GameObject Tendmi;
	public GameObject Tinitma;
	public GameObject Tpreminma;
	public GameObject Tpremaxma;
	public GameObject Tpostmaxma;
	public GameObject Tendma;

	// Use this for initialization
	void Start () {
		TextMesh t;
		t = Tinitmi.GetComponent<TextMesh>();
		t.text = "";
		t = Tpreminmi.GetComponent<TextMesh>();
		t.text = "";
		t = Tpremaxmi.GetComponent<TextMesh>();
		t.text = "";
		t = Tpostmaxmi.GetComponent<TextMesh>();
		t.text = "";
		t = Tendmi.GetComponent<TextMesh>();
		t.text = "";
		t = Tinitma.GetComponent<TextMesh>();
		t.text = "";
		t = Tpreminma.GetComponent<TextMesh>();
		t.text = "";
		t = Tpremaxma.GetComponent<TextMesh>();
		t.text = ")";
		t = Tpostmaxma.GetComponent<TextMesh>();
		t.text = "";
		t = Tendma.GetComponent<TextMesh>();
		t.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		TextMesh t;
		t = Tinitmi.GetComponent<TextMesh>();
		initmi = t.text == "Console.WriteLine(min);";
		t = Tpreminmi.GetComponent<TextMesh>();
		preminmi = t.text == "Console.WriteLine(min);";
		t = Tpremaxmi.GetComponent<TextMesh>();
		premaxmi = t.text == "Console.WriteLine(min);";
		t = Tpostmaxmi.GetComponent<TextMesh>();
		postmaxmi = t.text == "Console.WriteLine(min);";
		t = Tendmi.GetComponent<TextMesh>();
		endmi = t.text == "Console.WriteLine(min);";
		t = Tinitma.GetComponent<TextMesh>();
		initma = t.text == "Console.WriteLine(max);";
		t = Tpreminma.GetComponent<TextMesh>();
		preminma = t.text == "Console.WriteLine(max);";
		t = Tpremaxma.GetComponent<TextMesh>();
		premaxma = t.text == "Console.WriteLine(max);";
		t = Tpostmaxma.GetComponent<TextMesh>();
		postmaxma = t.text == "Console.WriteLine(max);";
		t = Tendma.GetComponent<TextMesh>();
		endma = t.text == "Console.WriteLine(max);";
		SetText ();
	}

	void SetText() {
		output = "";
		if (initmi) {
			output += "Min = 0\n";
		}
		if (initma){
			output += "Max = 0\n";
		}
		int min = 0;
		int max = 0;
		int[] values = {0,4,1,6,3,2,5};
		for (int i =0; i<7;i++){
			if (preminmi){
				output += "Min = " + System.Convert.ToString(min) + "\n";
			}
			if (preminma){
				output += "Max = " + System.Convert.ToString(max) + "\n";
			}
			if (i==4){
				min = 6;
			}
			else {
				min = System.Math.Min(min, values[i]);
			}
			if (premaxmi){
				output += "Min = " + System.Convert.ToString(min) + "\n";
			}
			if (premaxma){
				output += "Max = " + System.Convert.ToString(max) + "\n";
			}
			if (i==4){
				max = 0;
			}
			else {
				max = System.Math.Max(max, values[i]);
			}
			if (postmaxmi){
				output += "Min = " + System.Convert.ToString(min) + "\n";
			}
			if (postmaxma){
				output += "Max = " + System.Convert.ToString(max) + "\n";
			}
		}
		if (endmi) {
			output += "Min = " + System.Convert.ToString(min) + "\n";
		}
		if (endma) {
			output += "Max = " + System.Convert.ToString(max) + "\n";
		}
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = output;
	}
}
