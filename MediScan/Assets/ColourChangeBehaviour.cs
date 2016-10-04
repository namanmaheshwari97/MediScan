using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Rendering;
using System.Net.Sockets;

public class ColourChangeBehaviour : MonoBehaviour {
	
	private string recCheck;
	public TextMesh rectxt;
	static System.IO.StreamWriter streamWriter;
	static System.IO.StreamReader streamReader;
	static NetworkStream network;

	void Start () {
	}

	void Update () {
//		TcpClient socket = new TcpClient ();
//		Debug.Log ("New TCP Client init");
//		socket.Connect ("10.4.59.49", 8154);				//Change IP Address and Port to that of the Server Computer
//		network = socket.GetStream ();
//		streamWriter = new System.IO.StreamWriter (network); 
//		streamReader = new System.IO.StreamReader (network);
//		streamWriter.WriteLine("check;"+ ailment+

		if (recCheck == "1") {
			Debug.Log ("yes");
			rectxt.text = "Recommended";
		}	else if(recCheck == " 0"){
			rectxt.text = "Not recommended";
//		else if (recCheck == "1"){
//			Debug.Log ("yes");
//			rectxt.text = "Recommended";

		}
	}
}
