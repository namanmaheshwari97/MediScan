using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColourChangeBehaviour : MonoBehaviour {
	private int recCheck;
	public Material recmat;
	public Material nonrecmat;
	void Start () {
		
	}

	void Update () {
		recCheck = Connection.returnRecomCheck();
		if (recCheck == 0) {
			this.GetComponent<Renderer>().material = nonrecmat;
		} else if (recCheck == 1){
			this.GetComponent<Renderer>().material = recmat;
		}
	}
}
