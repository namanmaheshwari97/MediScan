using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class populateHomeRem : MonoBehaviour {

	public Text hrtext;
	// Use this for initialization
	void Start () {
		hrtext.text = Connection.returnHomeRem ();		
	}
}
