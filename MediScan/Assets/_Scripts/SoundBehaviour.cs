using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundBehaviour : MonoBehaviour {

	RawImage buttonIMG;
	Button soundBtn;
	private int pref;
	public Texture soundOn;
	public Texture soundOff;

	// Use this for initialization
	void Start () {
		pref = 1;
		buttonIMG = this.GetComponent<RawImage> ();
		soundBtn = this.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
		soundBtn.onClick.AddListener (() => changeSoundPreference ());
	}

	void changeSoundPreference(){
		if (pref == 0) {
			pref = 1;
			buttonIMG.texture = soundOff;
		} else {
			pref = 0;
			buttonIMG.texture = soundOn;
		}
	}
}
