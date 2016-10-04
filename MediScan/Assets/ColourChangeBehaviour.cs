using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class ColourChangeBehaviour : MonoBehaviour {
	
	public GameObject crossmark;
	public GameObject tickmark;
	private int recCheck;

	void Start () {
		crossmark.GetComponent<Renderer>().enabled = false;
		tickmark.GetComponent<Renderer>().enabled = false;

	}

	void Update () {
		recCheck = Connection.returnRecomCheck();
		if (recCheck == 0) {
			tickmark.GetComponent<Renderer>().enabled = false;
			crossmark.GetComponent<Renderer>().enabled = true;
		} else if (recCheck == 1){
//			tickmark.GetComponent<Material>().SetColor = (255,255,255,255);
			crossmark.GetComponent<Renderer>().enabled = false;

		}
	}
}
