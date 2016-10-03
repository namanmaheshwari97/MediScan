using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Swipe : MonoBehaviour {


	private float fingerStartTime  = 0.0f;
	private Vector2 fingerStartPos = Vector2.zero;
	public Canvas canvas;
	private bool isSwipe = false;
	private float minSwipeDist  = 50.0f;
	private float maxSwipeTime = 0.5f;

	private string loc;
	float lat;
	float lon;

	void Start(){
		Input.location.Start();
		if (Input.location.isEnabledByUser)
		{
			lat = Input.location.lastData.latitude;
			lon = Input.location.lastData.longitude;
			loc = lat.ToString() + "," + lon.ToString();
		}
	}
	// Update is calledonce per frame
	void Update () {

		if (Input.touchCount > 0){

			foreach (Touch touch in Input.touches)
			{
				switch (touch.phase)
				{
				case TouchPhase.Began :
					/* this is a new touch */
					isSwipe = true;
					fingerStartTime = Time.time;
					fingerStartPos = touch.position;
					break;

				case TouchPhase.Canceled :
					/* The touch is being canceled */
					isSwipe = false;
					break;

				case TouchPhase.Ended :

					float gestureTime = Time.time - fingerStartTime;
					float gestureDist = (touch.position - fingerStartPos).magnitude;

					if (isSwipe && gestureTime < maxSwipeTime && gestureDist > minSwipeDist){
						Vector2 direction = touch.position - fingerStartPos;
						Vector2 swipeType = Vector2.zero;

						if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y)){
							// the swipe is horizontal:
							swipeType = Vector2.right * Mathf.Sign(direction.x);
						}else{
							// the swipe is vertical:
							swipeType = Vector2.up * Mathf.Sign(direction.y);
						}

//						if(swipeType.x != 0.0f){
//							if(swipeType.x > 0.0f){
//								// MOVE RIGHT
//							}else{
//								// MOVE LEFT
//							}
//						}

						if(swipeType.y != 0.0f ){
							if(swipeType.y > 0.0f){
								Connection.initConnection (2, "sos;" + loc);
								// MOVE UP
								Application.OpenURL("tel://108");

							}else{
								SceneManager.LoadScene(2);
							}
						}

					}

					break;
				}
			}
		}

	}
}