using UnityEngine;
using System.Collections;
using System.Net.Sockets;

public class Connection : MonoBehaviour {
	private string loc;
	// Use this for initialization
	float lat;
	float lon;
	void Start () {
		Debug.Log ("initConnection is called");
		initConnection ();
		lat = 0.213f;
		lon = 321.3123f;
	}
	void initConnection(){
		loc = lat.ToString() + "," + lon.ToString();
		TcpClient socket = new TcpClient();
		Debug.Log ("New TCP Client init");
		socket.Connect("10.4.59.36",8092);
		Debug.Log ("Socket connected");
		NetworkStream network = socket.GetStream();
		System.IO.StreamWriter streamWriter= new System.IO.StreamWriter(network); 
		streamWriter.WriteLine(loc);
		Debug.Log ("Chewtiya sent.");
		streamWriter.Flush();   
		Debug.Log ("Streamwriter flushed...");
	}	




	// Update is called once per frame
}
