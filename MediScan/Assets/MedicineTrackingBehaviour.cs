using UnityEngine;
using System.Collections;
using Vuforia;


public class MedicineTrackingBehaviour : MonoBehaviour, ITrackableEventHandler{

	private TrackableBehaviour mTrackableBehaviour;

	void Start()
	{
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			Debug.Log(mTrackableBehaviour.TrackableName);
		}
		else
		{
			Debug.Log("LOST");
		}
	}
}