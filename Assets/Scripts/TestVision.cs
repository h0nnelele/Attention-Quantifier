using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestVision : MonoBehaviour
{
	
	//private Text debugText;
	//void Start()
	//{
	//	foreach (Text text in FindObjectsOfType<Text>())
	//		if (text.gameObject.name.Contains("vision debug"))
	//			debugText = text;

	//	if (debugText == null)
	//		Debug.LogError("could not find vision debug text.");
	//}

	// Update is called once per frame
	void Update()
	{
		//if (debugText == null)
		//	return; 


		//foreach (VisionTracker vt in FindObjectsOfType<VisionTracker>())
		//{
		//string h = vt.GetHistoryScore().ToString("F2");
		//string d = vt.GetTotalLookAtScore().ToString("F2");
		//string s = vt.GetLookAtScore().ToString("F2");
		//text += "\n" + vt.gameObject.name + " history=" + h + " direct=" + d + " score=" + s;
		//}
		this.transform.GetChild(0).gameObject.GetComponent<Text>().text =  transform.parent.parent.gameObject.GetComponent<VisionTracker>().GetLookAtScore().ToString("F2");
		this.transform.GetChild(1).gameObject.GetComponent<Text>().text =  transform.parent.parent.gameObject.GetComponent<VisionTracker>().GetHistoryScore().ToString("F2");
		this.transform.GetChild(2).gameObject.GetComponent<Text>().text =  transform.parent.parent.gameObject.GetComponent<VisionTracker>().GetTotalLookAtScore().ToString("F2");
		this.transform.GetChild(3).gameObject.GetComponent<Text>().text =  transform.parent.parent.gameObject.GetComponent<VisionTracker>().GetCount().ToString("F2");
	}
}