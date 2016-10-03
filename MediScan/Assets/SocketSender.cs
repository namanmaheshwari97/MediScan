using UnityEngine;
using System.Collections;
using System.Net.Sockets;

public class SocketSender : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Connection.initConnection (2,"tol");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
