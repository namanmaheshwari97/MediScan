using UnityEngine;
using System.Collections;
using System.Net.Sockets;

public class Connection : MonoBehaviour {

	public static Connection conn;
	// Use this for initialization
	static System.IO.StreamWriter streamWriter;
	static System.IO.StreamReader streamReader;
	static NetworkStream network;
	public static string ailment;
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
			Debug.Log ("2 IS SELECTED ");
			Connection.connectToSocket ();
			Debug.Log ("coNNECTED");
			if (str == "1")
				ailment = "loose motions";
			else if (str == "2")
				ailment = "sinusitus";
			else if (str == "4")
				ailment = "strains";
			else if (str == "5")
				ailment = "allergy";
			else if (str == "6")
				ailment = "cold and flu";
			else if (str == "7")
				ailment = "headache";
			else if (str == "8")
				ailment = "acid reflux";
			recd = concatHomeRem (ailment);
			streamWriter.WriteLine (recd);
			streamWriter.Flush ();   
			recd = streamReader.ReadLine ();
			Debug.Log (recd);
		} else if (ch == 3) {
//			TcpClient socket = new TcpClient ();
//			Debug.Log ("New TCP Client init");
//			socket.Connect ("10.4.59.36", 8106);
//			Debug.Log ("Socket connected");
//			NetworkStream network = socket.GetStream ();
//
//			recd = streamReader.ReadLine ();
//			Debug.Log (recd);
			Debug.Log ("StreamReader read line");
		} else if (ch == 4) {
//			TcpClient socket = new TcpClient ();
			Debug.Log ("New TCP Client init");
//			socket.Connect ("10.4.59.36", 8104);
//			Debug.Log ("Socket connected");
//			NetworkStream network = socket.GetStream ();
//			network.Close ();
		}
			
	}
	//concatHomeRem concatenates the string for when ch == 2
	public static string concatHomeRem(string ail){
		string a;

		a = "home remedies;" + ail;
		return a;
	}

	public static void connectToSocket(){
		TcpClient socket = new TcpClient ();
		Debug.Log ("New TCP Client init");
		socket.Connect ("10.4.59.36", 8114);
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
