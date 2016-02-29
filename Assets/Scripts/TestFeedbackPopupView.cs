using UnityEngine;
using System.Collections;

public class TestFeedbackPopupView : MonoBehaviour {


	FeedbackView panel;
	// JUST FOR TESTING THE UI 
	// SHOULD BE REMOVED GAMEOBJECT "CANVAS" AT THE END FROM
	public ITracking it;
	void Start () {
		CameraObscuredEvent coe = new CameraObscuredEvent ();
		panel = new FeedbackView (coe);
		//panel = gameObject.AddComponent<FeedbackView> ();
		StartCoroutine (panel.showAndHide (coe.getTimeToLive()));
		/*TrackingMethods tm = new TrackingMethods ();
		IVuforia iv = (IVuforia)tm;
		IMetaio im = (IMetaio)tm;
		iv.Test ();
		im.Test ();*/
		if (!TrackingInterfaceController.getSelectedMetaio())
			it = (ITracking)MetaioComponents.GetInstance ();
		else
			it = (ITracking)VuforiaComponents.GetInstance ();
		it.Test ();
	}
}
