using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenHRBehaviour : MonoBehaviour {

	private Button HRbtn;

	void Start () {
		HRbtn = this.GetComponent<Button> ();
		HRbtn.onClick.AddListener (() => openHRscenefunc ());
	}

	public void openHRscenefunc(){
		SceneManager.LoadScene (4);
	}
}
