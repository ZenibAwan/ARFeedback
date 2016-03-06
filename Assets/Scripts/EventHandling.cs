using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class EventHandling : MonoBehaviour {

	private UnityAction someListener;
	private FeedbackView panel;

	void Awake () {
		someListener = new UnityAction (SomeFunction);
	}

	void OnEnable () {
		EventManager.StartListening ("test", someListener);
		EventManager.StartListening ("CameraObscured", CameraObscured);
	}

	void OnDisable () {
		EventManager.StopListening ("test", someListener);
		EventManager.StopListening ("CameraObscured", CameraObscured);
	}

	void SomeFunction () {
		Debug.Log ("Some Function was called!");
	}

	void CameraObscured () {
		CameraObscuredFeedbackEvent cofe = new CameraObscuredFeedbackEvent ();
		panel = new FeedbackView (cofe);
		//panel = gameObject.AddComponent<FeedbackView> ();
		StartCoroutine (panel.showAndHide (cofe.getTimeToLive()));

		Debug.Log ("Some Other Function was called!");
	}

	void SomeThirdFunction () {
		Debug.Log ("Some Third Function was called!");
	}
}
