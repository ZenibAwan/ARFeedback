using UnityEngine;
using System.Collections;

public class TestFeedbackPopupView : MonoBehaviour {


	FeedbackView panel;
	// JUST FOR TESTING THE UI 
	// SHOULD BE REMOVED FROM GAMEOBJECT "CANVAS" AT THE END 
	public ITracking it;
	MetaioComponents metaioComponents;
	VuforiaComponents vuforiaComponents;

	void Start () {
		CameraObscuredFeedbackEvent cofe = new CameraObscuredFeedbackEvent ();
		panel = new FeedbackView (cofe);
		//panel = gameObject.AddComponent<FeedbackView> ();
		StartCoroutine (panel.showAndHide (cofe.getTimeToLive()));

//		metaioComponents = new MetaioComponents ();
//		vuforiaComponents = new VuforiaComponents ();

//		it = metaioComponents;

		it = TrackingInterfaceController.GetTrackingInstance ();
	}
}
