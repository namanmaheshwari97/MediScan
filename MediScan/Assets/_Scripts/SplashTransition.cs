using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class SplashTransition : MonoBehaviour {

	private float remainingtime;
	void Start () {
		remainingtime = 3;
	}

	void Update(){
		remainingtime--;
		if (remainingtime == 0) {
			changeScene ();
		}
	}

	void changeScene(){
		SceneManager.LoadScene (1);
	}
}
