using UnityEngine;
using System.Collections;

public class GPSsocketsender : MonoBehaviour {


	private string loc;

	// Use this for initialization
	float lat;
	float lon;

	void Start () {
		Input.location.Start();
		if (Input.location.isEnabledByUser)
		{
			lat = Input.location.lastData.latitude;
			lon = Input.location.lastData.longitude;
			loc = lat.ToString() + "," + lon.ToString();
			Connection.initConnection (2, "sos;" + loc);
		}
	}
}
