using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Text;
using System.Xml;
using System.Text.RegularExpressions;

public class LevelGenerator : MonoBehaviour
{

		public GameObject leveltext;
		public GameObject destext;
		public GameObject bugobject;
		public GameObject lineobject;
		public GameObject printobject;
		public GameObject prizeobject;
		public GameObject warpobject;
		public GameObject commentobject;
		public GameObject breakpointobject;
		public GameObject hero;
		public GameObject sidebaroutput;
		public GameObject selectedtool;
		public GameObject sidebarpanel;
		public GameObject outputpanel;
		public GameObject cinematic;
		public GameObject menu;
		public GameObject[] toolIcons = new GameObject[6];
		string codetext;
		public GameObject sidebartimer;
		public int linecount = 0;
		float initialLineY = 3f;
		float initialLineX = -4.5f;
		float linespacing = 0.825f;
		float levelLineRatio = 0.55f;
		float bugXshift = -9.5f;
		float fontwidth = 0.15f;
		float bugsize = 1f;
		float bugscale = 1.5f;
		float textscale = 1.75f;
		GameObject levelbug;
		float leveldelay = 2f;
		float startNextLevel = 0f;
		int numOfTools = 6;
		float startTime = 0f;
		public float endTime = 0f;
		public float remainingtime = 0f;
		public int num_of_bugs = 0;
		public string nextlevel = "";
		public string currentlevel = "level0";
		List<GameObject> lines;
		List<GameObject> outputs;
		List<GameObject> warps;
		List<GameObject> bugs;
		List<GameObject> comments;
		List<GameObject> breakpoints;
		List<GameObject> prizes;
		public int gamestate;

	/*gamestates:
	 * <0-SubMenus
		0-Menu
		1-Game
		2-LevelStart
		3-LevelFinish
		4-LevelLose
		5-Unused
		6-Unused
		7-Unused
		8-Unused
		9-Unused
		10-InitialComic
		11-StageComic
		12-GameEnd
	*/

		// Use this for initialization
		void Start ()
		{
				lines = new List<GameObject> ();
				outputs = new List<GameObject> ();
				warps = new List<GameObject> ();
				bugs = new List<GameObject> ();
				comments = new List<GameObject> ();
				breakpoints = new List<GameObject> ();
				prizes = new List<GameObject> ();
				gamestate = 10;
				GUISwitch (false);
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (gamestate == 1) {
						sidebartimer.GetComponent<GUIText> ().text = "Time remaining: " + ((int)(endTime - Time.time)).ToString () + " seconds";
						if (num_of_bugs <= 0 && bugs.Count > 0) {						
								if (startNextLevel == 0f) {
										startNextLevel = Time.time + leveldelay;
								} else if (Time.time > startNextLevel) {
										startNextLevel = 0f;
										if (nextlevel != @"leveldata\") {
												foreach (GameObject bug in bugs) {
														Destroy (bug);
												}
												GUISwitch (false);
												menu.GetComponent<Menu> ().saveGame (currentlevel);
												gamestate = 3;
										} else {
												Victory ();
										}
								}
						
						}
						if (endTime < Time.time && num_of_bugs > 0) {
								GameOver ();
						}
						if (Input.GetKeyDown (KeyCode.Escape)) {
								gamestate = 0;
								GUISwitch (false);
						}
				} else {
				}
		}

		public void GUISwitch (bool gui_on)
		{
				if (gui_on) {
						sidebarpanel.GetComponent<GUITexture> ().enabled = true;
						outputpanel.GetComponent<GUITexture> ().enabled = true;
						endTime = remainingtime + Time.time;
				} else {
						sidebarpanel.GetComponent<GUITexture> ().enabled = false;
						outputpanel.GetComponent<GUITexture> ().enabled = false;
						sidebartimer.GetComponent<GUIText> ().text = "";
						remainingtime = endTime - Time.time;
				}
		}

		public void BuildLevel (string filename, bool warp, string linenum="")
		{
				ResetLevel (warp);
				XmlDocument doc = new XmlDocument ();
				doc.Load (filename);
				XmlNode levelnode = doc.FirstChild;
				WriteCode (levelnode);
				PlaceObjects (levelnode);
				if (!warp) {
						SetTools (levelnode);
						currentlevel = filename.Substring (filename.IndexOf ("\\") + 1);
						startTime = Time.time;
						foreach (XmlNode node in levelnode.ChildNodes) {
								if (node.Name == "time") {
										endTime = (float)int.Parse (node.InnerText) + startTime;
										remainingtime = (float)int.Parse (node.InnerText);
								} else if (node.Name == "nextlevel") {
										nextlevel = @"leveldata\" + node.InnerText;
								} else if (node.Name == "introtext") {
										cinematic.GetComponent<Cinematic> ().introtext = node.InnerText;
								} else if (node.Name == "endtext") {
										cinematic.GetComponent<Cinematic> ().endtext = node.InnerText;
								}
						}
						selectedtool.GetComponent<SelectedTool> ().NextTool ();

				} else if (linenum != "") {
						hero.transform.position = new Vector3 (-7, initialLineY - (int.Parse (linenum) - 1) * linespacing, 1);
				}
				this.transform.position -= new Vector3 (0, (linecount / 2) * linespacing, 0);
				this.transform.localScale += new Vector3 (0, levelLineRatio * linecount, 0);
				if (warp) {
						GetComponent<AudioSource> ().Play ();
				}
		}

		void WriteCode (XmlNode levelnode)
		{
				destext.GetComponent<TextMesh> ().text = "";
				foreach (XmlNode codenode in levelnode.ChildNodes) {
						if (codenode.Name == "code") {
								foreach (XmlNode printnode in codenode.ChildNodes) {
										if (printnode.Name == "print") {
												printnode.InnerText = "<color=#ffff00ff>" + printnode.InnerText + "</color>";
										}
										if (printnode.Name == "warp") {
												printnode.InnerText = "<color=#ff00ffff>" + printnode.InnerText + "</color>";
										}
										if (printnode.Name == "comment") {
												printnode.InnerXml = "&lt;color=#00ff00ff&gt;/**/&lt;/color&gt;" + printnode.InnerXml + "&lt;color=#00ff00ff&gt;/**/&lt;/color&gt;\n\n";
										}
								}
								codetext = codenode.InnerText;
								foreach (char c in codetext) {
										if (c == '\n')
												linecount++;
								}
								Regex rgx = new Regex ("(//)(.*)");
								codetext = rgx.Replace (codetext, "<color=#00ff00ff>//$2</color>");
								rgx = new Regex ("(\\W|^)(else if|include|bool|auto|double|int|struct|break|else|long|switch|case|enum|register|typedef|char|extern|return|union|continue|for|signed|void|do|if|static|while|default|goto|sizeof|volatile|const|float|short|unsigned)(\\W|$)");
								codetext = rgx.Replace (codetext, "$1<color=#00ffffff>$2</color>$3");
								rgx = new Regex ("(//)(.*)(<color=#00ffffff>)(.*)(</color>)(.*)(</color>)");
								codetext = rgx.Replace (codetext, "$1$2$4$6$7");
						} else if (codenode.Name == "description") {
								destext.GetComponent<TextMesh> ().text = codenode.InnerText;
						}
				}
				for (int i = 0; i<linecount; i++) {
						GameObject newline = (GameObject)Instantiate (lineobject, new Vector3 (initialLineX, initialLineY - i * linespacing, 1), transform.rotation);
						lines.Add (newline);
				}
				leveltext.GetComponent<TextMesh> ().text = codetext;
		}

		void PlaceObjects (XmlNode levelnode)
		{
				foreach (XmlNode codenode in levelnode.ChildNodes) {
						if (codenode.Name == "code") {
								// Create the XmlNamespaceManager.
								XmlNamespaceManager nsmgr = new XmlNamespaceManager (new NameTable ());
				
								// Create the XmlParserContext.
								XmlParserContext context = new XmlParserContext (null, nsmgr, null, XmlSpace.None);
				
								// Create the reader.
								XmlValidatingReader reader = new XmlValidatingReader (codenode.InnerXml, XmlNodeType.Element, context);
				
								IXmlLineInfo lineInfo = ((IXmlLineInfo)reader);
								while (reader.Read()) {

										if (reader.NodeType == XmlNodeType.Element && reader.Name == "print") {
												GameObject newoutput = (GameObject)Instantiate (printobject, new Vector3 (-7, initialLineY - (lineInfo.LineNumber - 1) * linespacing, 1), transform.rotation);
												outputs.Add (newoutput);
												printer printcode = newoutput.GetComponent<printer> ();
												printcode.displaytext = reader.GetAttribute ("text");
												printcode.sidebar = sidebaroutput;
												printcode.selectTools = selectedtool;
												if (reader.GetAttribute ("tool") != null) {
														string toolatt = reader.GetAttribute ("tool");
														string[] toolcounts = toolatt.Split (',');
														for (int i = 0; i<6; i++) {
																printcode.tools [i] = int.Parse (toolcounts [i]);
														}
												}
										} else if (reader.NodeType == XmlNodeType.Element && reader.Name == "warp") {
												GameObject newwarp = (GameObject)Instantiate (warpobject, new Vector3 (-7, initialLineY - (lineInfo.LineNumber - 1) * linespacing, 1), transform.rotation);
												warps.Add (newwarp);
												warper warpcode = newwarp.GetComponent<warper> ();
												warpcode.CodeScreen = this.gameObject;
												warpcode.filename = reader.GetAttribute ("file");
												warpcode.selectTools = selectedtool;
												if (reader.GetAttribute ("tool") != null) {
														string toolatt = reader.GetAttribute ("tool");
														string[] toolcounts = toolatt.Split (',');
														for (int i = 0; i<6; i++) {
																warpcode.tools [i] = int.Parse (toolcounts [i]);
														}
												}
												if (reader.GetAttribute ("line") != null) {
														warpcode.linenum = reader.GetAttribute ("line");
												}
										} else if (reader.NodeType == XmlNodeType.Element && reader.Name == "bug") {
												bugsize = int.Parse (reader.GetAttribute ("size"));
												int row = 0;
												if (reader.GetAttribute ("row") != null) {
														row = int.Parse (reader.GetAttribute ("row"));
												}
												int col = 0;
												if (reader.GetAttribute ("col") != null) {
														col = int.Parse (reader.GetAttribute ("col"));
												}
												levelbug = (GameObject)Instantiate (bugobject, new Vector3 (bugXshift + col * fontwidth + (bugsize - 1) * levelLineRatio, initialLineY - (lineInfo.LineNumber + row - 1 + 0.5f * (bugsize - 1)) * linespacing + 0.4f, 0f), transform.rotation);
												levelbug.transform.localScale += new Vector3 (bugscale * (bugsize - 1), bugscale * (bugsize - 1), 0);
												levelbug.GetComponent<GenericBug> ().codescreen = this.gameObject;
												bugs.Add (levelbug);
												num_of_bugs++;

										} else if (reader.NodeType == XmlNodeType.Element && reader.Name == "comment") {
												int commentsize = int.Parse (reader.GetAttribute ("size"));
												GameObject newcomment = (GameObject)Instantiate (commentobject, new Vector3 (-7, initialLineY - (lineInfo.LineNumber - 1 + 0.9f * (commentsize - 1)) * linespacing, 0f), transform.rotation);
												comments.Add (newcomment);
												commentBlock commentcode = newcomment.GetComponent<commentBlock> ();
												commentcode.code = leveltext;
												commentcode.errmsg = reader.GetAttribute ("text");
												commentcode.sideoutput = sidebaroutput;
												commentcode.oldtext = codetext;
												newcomment.transform.localScale += new Vector3 (0, textscale * (commentsize - 1), 0);
												commentcode.selectTools = selectedtool;
												if (reader.GetAttribute ("tool") != null) {
														string toolatt = reader.GetAttribute ("tool");
														string[] toolcounts = toolatt.Split (',');
														for (int i = 0; i<6; i++) {
																commentcode.tools [i] = int.Parse (toolcounts [i]);
														}
												}
										} else if (reader.NodeType == XmlNodeType.Element && reader.Name == "breakpoint") {
												GameObject newbreakpoint = (GameObject)Instantiate (breakpointobject, new Vector3 (-10, initialLineY - (lineInfo.LineNumber - 1) * linespacing + 0.4f, 1), transform.rotation);
												breakpoints.Add (newbreakpoint);
												Breakpoint breakcode = newbreakpoint.GetComponent<Breakpoint> ();
												breakcode.sidebaroutput = sidebaroutput;
												breakcode.values = reader.GetAttribute ("text");
												breakcode.selectTools = selectedtool;
												if (reader.GetAttribute ("tool") != null) {
														string toolatt = reader.GetAttribute ("tool");
														string[] toolcounts = toolatt.Split (',');
														for (int i = 0; i<6; i++) {
																breakcode.tools [i] = int.Parse (toolcounts [i]);
														}
												}
										} else if (reader.NodeType == XmlNodeType.Element && reader.Name == "prize") {
												bugsize = int.Parse (reader.GetAttribute ("size"));
												GameObject prizebug = (GameObject)Instantiate (prizeobject, new Vector3 (-9f + (bugsize - 1) * levelLineRatio, initialLineY - (lineInfo.LineNumber - 1 + 0.5f * (bugsize - 1)) * linespacing + 0.4f, 0f), transform.rotation);
												prizebug.transform.localScale += new Vector3 (bugscale * (bugsize - 1), bugscale * (bugsize - 1), 0);
												prizebug.GetComponent<PrizeBug> ().tools = selectedtool;
												string[] bonuses = reader.GetAttribute ("bonuses").Split (',');
												for (int i = 0; i<6; i++) {
														prizebug.GetComponent<PrizeBug> ().bonus [i] += int.Parse (bonuses [i]);
												}
												prizes.Add (prizebug);
						
										}
								}
								reader.Close ();
								int j = 0;
								for (int i=0; i<codenode.ChildNodes.Count; i++) {
										if (codenode.ChildNodes [i].Name == "comment") {
												comments [j].GetComponent<commentBlock> ().blocktext = codenode.ChildNodes [i].InnerText.Trim ();
												j++;
										}
								}
						}
				}
		}

		public void SetTools (XmlNode levelnode)
		{
				for (int i = 0; i<numOfTools; i++) {
						toolIcons [i].GetComponent<GUITexture> ().enabled = false;
				}
				foreach (XmlNode codenode in levelnode.ChildNodes) {
						if (codenode.Name == "tools") {
								foreach (XmlNode toolnode in codenode.ChildNodes) {
										int toolnum = int.Parse (toolnode.InnerText);
										toolIcons [toolnum].GetComponent<GUITexture> ().enabled = true;
										selectedtool.GetComponent<SelectedTool> ().toolCounts [toolnum] = int.Parse (toolnode.Attributes ["count"].Value);
								}
						}
				}
		}

		public void ResetLevel (bool warp)
		{
				foreach (GameObject ln in lines) {
						Destroy (ln);
				}
				foreach (GameObject op in outputs) {
						Destroy (op);
				}
				foreach (GameObject wp in warps) {
						Destroy (wp);
				}
				foreach (GameObject cm in comments) {
						Destroy (cm);
				}
				foreach (GameObject bp in breakpoints) {
						Destroy (bp);
				}
				foreach (GameObject pb in prizes) {
						Destroy (pb);
				}
				if (levelbug) {
						Destroy (levelbug);
				}
				sidebaroutput.GetComponent<GUIText> ().text = "";
				lines = new List<GameObject> ();
				outputs = new List<GameObject> ();
				warps = new List<GameObject> ();
				bugs = new List<GameObject> ();
				comments = new List<GameObject> ();
				breakpoints = new List<GameObject> ();
				prizes = new List<GameObject> ();
				if (!warp) {
						for (int i = 0; i<numOfTools; i++) {
								toolIcons [i].GetComponent<GUITexture> ().enabled = false;
								toolIcons [i].GetComponent<GUITexture> ().color = new Color (0.3f, 0.3f, 0.3f);
								selectedtool.GetComponent<SelectedTool> ().toolCounts [i] = 0;
								selectedtool.GetComponent<SelectedTool> ().projectilecode = 0;
						}
				}
				
				num_of_bugs = 0;
				this.transform.position += new Vector3 (0, (linecount / 2) * linespacing, 0);
				this.transform.localScale -= new Vector3 (0, levelLineRatio * linecount, 0);
				linecount = 0;
				hero.transform.position = leveltext.transform.position;
		}

		public void GameOver ()
		{
				GUISwitch (false);

				menu.GetComponent<Menu> ().gameon = false;
				gamestate = 4;
		}

		public void Victory ()
		{
				GUISwitch (false);
		
				menu.GetComponent<Menu> ().gameon = false;
				currentlevel = "level5";
				gamestate = 12;
		}
}
