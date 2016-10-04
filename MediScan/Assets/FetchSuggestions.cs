using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FetchSuggestions : MonoBehaviour {

	public Text Sugg;
	private string sug;
	void Start () {
		
	}

	void Update () {
		string[] ab = Connection.returnSuggestions (); 
		sug = ab [0] + "\n" + ab [1];
		Sugg.text = sug;
			
	}
}
