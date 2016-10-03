using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Net.Sockets;

public class HomeRemediesBehaviour : MonoBehaviour {

	private string str;
	public Button hrButton;

	public Dropdown ailmentPicker;

	void Start(){
	}

	void getHomeRemedies(){
		str = ailmentPicker.GetComponent<Dropdown> ().GetComponentInChildren<Text> ().text;
		Connection.initConnection (2, str);
	}

	public void OnPointerClick(EventSystems.PointerEventData eventData);


}
