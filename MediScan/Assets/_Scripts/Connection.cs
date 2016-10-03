using UnityEngine;
using System.Collections;
using System.Net.Sockets;

public class Connection : MonoBehaviour {

	public static Connection conn;
	// Use this for initialization
	static System.IO.StreamWriter streamWriter;
	static System.IO.StreamReader streamReader;
	static NetworkStream network;

	void Start () {
		Debug.Log ("initConnection is called");
	}

	public static void initConnection(int ch, string str){
		string recd;
		if (ch == 1) {
			Connection.connectToSocket ();
			streamWriter.WriteLine (str);
			streamWriter.Flush ();
		} else if (ch == 2) {
			Connection.connectToSocket ();
			streamWriter.WriteLine (str);
			streamWriter.Flush ();   
		} else if (ch == 3) {
			TcpClient socket = new TcpClient ();
			Debug.Log ("New TCP Client init");
			socket.Connect ("10.4.59.36", 8105);
			Debug.Log ("Socket connected");
			NetworkStream network = socket.GetStream ();

			recd = streamReader.ReadLine ();
			Debug.Log (recd);
			Debug.Log ("StreamReader read line");
		} else if (ch == 4) {
			TcpClient socket = new TcpClient ();
			Debug.Log ("New TCP Client init");
			socket.Connect ("10.4.59.36", 8104);
			Debug.Log ("Socket connected");
			NetworkStream network = socket.GetStream ();
			network.Close ();
		}
			
	}	

	public static void connectToSocket(){
		TcpClient socket = new TcpClient ();
		Debug.Log ("New TCP Client init");
		socket.Connect ("10.4.59.36", 8109);
		network = socket.GetStream ();
 		streamWriter = new System.IO.StreamWriter (network); 
		streamReader = new System.IO.StreamReader (network);

	}

	/*
	 * 1. SOS
	 * 2. home remedies
	 * 3. check
	 * 4. our suggestions
	 * 5. exit
	 */


	// Update is called once per frame
}
