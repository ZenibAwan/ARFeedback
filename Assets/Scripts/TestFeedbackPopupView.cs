// JUST FOR TESTING THE UI 
// SHOULD BE REMOVED FROM GAMEOBJECT "CANVAS" AT THE END 

using UnityEngine;
using System.Collections;

public class TestFeedbackPopupView : MonoBehaviour {

	FeedbackView panel;
	public ITracking it;
	MetaioComponents metaioComponents;
	VuforiaComponents vuforiaComponents;

	void Start () {

		metaioComponents = new MetaioComponents ();
		vuforiaComponents = new VuforiaComponents ();

		it = metaioComponents;

		it = TrackingInterfaceController.GetTrackingInstance ();

		int randomNumber;
		randomNumber = Random.Range (0, 2);

		Debug.Log ("randomNumber: " + randomNumber);
		if (randomNumber == 0) {
			EventManager.TriggerEvent ("CameraObscured");
		}
	}
}
