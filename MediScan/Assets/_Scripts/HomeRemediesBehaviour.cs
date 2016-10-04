using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeRemediesBehaviour : MonoBehaviour {

	public Dropdown ailmentPicker;

	void Start(){
		ailmentPicker.onValueChanged.AddListener (delegate {
			getHomeRemedies (ailmentPicker);
		});
	}



	private void getHomeRemedies(Dropdown aDropDown){
		Debug.Log ("SELECTED " + aDropDown.value);
		Connection.initConnection (2, aDropDown.value.ToString());
		SceneManager.LoadScene (3);
	}


}
