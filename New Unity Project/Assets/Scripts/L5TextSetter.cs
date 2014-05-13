using UnityEngine;
using System.Collections;

public class L5TextSetter : MonoBehaviour {

	string main = "//Compare each pair of colors and show which is brighter and which is darker" +
		"\n" +
		"\n#include <stdio.h>" +
		"\n#include <colorprinter.h>" +
		"\n" +
		"\n#define TOTAL_COLORS   12" +
		"\n" +
		"\nusing namespace colorprinter" +
		"\n" +
		"\nstruct colour {" +
		"\n char name[28];" +
		"\n int red;" +
		"\n int green;" +
		"\n int blue;" +
		"\n};" +
		"\n" +
		"\n" +
		"\nstruct tabs {" +
		"\n struct colour *table;" +
		"\n int tabsize;" +
		"\n} coltab[TOTAL_COLORS];" +
		"\n" +
		"\nint main(void) {" +
		"\n  enum colours { AQUA, BLACK, BLUE, FUCHSIA, GRAY, GREEN, LIME," +
		"\n                 MAROON, NAVY, OLIVE, PURPLE, RED, SILVER," +
		"                   TEAL, WHITE, YELLOW } color1;" +
		"\n  enum colours { AQUA, BLACK, BLUE, FUCHSIA, GRAY, GREEN, LIME," +
		"\n                 MAROON, NAVY, OLIVE, PURPLE, RED, SILVER," +
		"                   TEAL, WHITE, YELLOW  color2;" +
		"\n  struct colour *brighter;" +
		"\n int i1 = 0;" +
		"\n int i2 = 0;" +
		"\n int red1 = 0, green1 = 0, blue1 = 0, red2 = 0, green2 = 0, blue3 = 0;" + //\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n
		"\n   for(color1 = AQUA; color1 < TOTAL_COLORS; color1++) {" +
		"\n     red1   = coltab[color1].table[i1].red;" +
		"\n     green1 = coltab[color1].table[i1].green;" +
		"\n     blue1  = coltab[color1].table[i1].blue;"+
		"\n     for(color2 = YELLOW; color2 > color1; color2--) {" +
		"\n       red2   = coltab[color2].table[i2].red;" +
		"\n       green2 = coltab[color2].table[i2].green;" +
		"\n       blue2  = coltab[color2].table[i2].blue;" +
		"\n       brighter = Compare(red1,green1,blue1,red2,green2,blue2);" +
		"\n    }" +
		"\n   }" +
		"\n  }" +
		"\n }" +
		"\n" +
		"\n return 0;" +
		"\n}";

	// Use this for initialization
	void Start () {
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = main;	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
