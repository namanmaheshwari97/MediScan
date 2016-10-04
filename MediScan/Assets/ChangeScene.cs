using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
	public void Change(int Change) {
		SceneManager.LoadScene (Change);
	}
}