using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class opensuggestionsscene : MonoBehaviour {

	public Button sugbtn;
	// Use this for initialization
	void Start () {
		sugbtn.onClick.AddListener (() => OpenSugscn ());
	}
	
	// Update is called once per frame
	void OpenSugscn(){
		SceneManager.LoadScene (5);
	}
}
