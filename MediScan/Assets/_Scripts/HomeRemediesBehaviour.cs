using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class HomeRemediesBehaviour : MonoBehaviour {

	private Button HRbutton;
	public Canvas AR_MainCanv;
	public Canvas AR_HRCanv;
	// Use this for initialization
	void Start () {
		AR_HRCanv.isActiveAndEnabled (false);
		HRbutton = this.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
		HRbutton.onClick.AddListener (() => getCanvas ());
	}
	
	void getCanvas(){
		AR_HRCanv.istransparent
	}
}
