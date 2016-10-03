using UnityEngine;
using System.Collections;
using System.Net.Sockets;

public class Connection : MonoBehaviour {

	public static Connection conn;
	// Use this for initialization

	void Start () {
		Debug.Log ("initConnection is called");
//		initConnection ();
	}
		
	public static void initConnection(int ch, string str){
		string recd;
		if (ch == 1) {
					
			TcpClient socket = new TcpClient ();
			Debug.Log ("New TCP Client init");
			socket.Connect ("10.4.59.36", 8096);
			Debug.Log ("Socket connected");
		} else if (ch == 2) {
			TcpClient socket = new TcpClient ();
			Debug.Log ("New TCP Client init");
			socket.Connect ("10.4.59.36", 8101);
			Debug.Log ("Socket connected");
			NetworkStream network = socket.GetStream ();
			System.IO.StreamWriter streamWriter = new System.IO.StreamWriter (network); 
			streamWriter.WriteLine (str);
			Debug.Log ("Chewtiya sent.");
			streamWriter.Flush ();   
			Debug.Log ("Streamwriter flushed...");
		} else if (ch == 3) {
			TcpClient socket = new TcpClient ();
			Debug.Log ("New TCP Client init");
			socket.Connect ("10.4.59.36", 8095);
			Debug.Log ("Socket connected");
			NetworkStream network = socket.GetStream ();
			System.IO.StreamReader streamReader = new System.IO.StreamReader (network);
			recd = streamReader.ReadLine ();
			Debug.Log (recd);
			Debug.Log ("StreamReader read line");
		} else if (ch == 4) {
			TcpClient socket = new TcpClient ();
			Debug.Log ("New TCP Client init");
			socket.Connect ("10.4.59.36", 8095);
			Debug.Log ("Socket connected");
			NetworkStream network = socket.GetStream ();
			network.Close ();
		}
			
	}	

	/*
	 * 1. Initialize Connection
	 * 2. WriteLine
	 * 3. ReceiveLine
	 * 4. Exit
	 */


	// Update is called once per frame
}
