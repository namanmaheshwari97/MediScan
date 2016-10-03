using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class TransitionToswipe : MonoBehaviour {


	void Start () {
		changeScene ();
	}
	void changeScene(){
		SceneManager.GetSceneAt (1);
	}
}
