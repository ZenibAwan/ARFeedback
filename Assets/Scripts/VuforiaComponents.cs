using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Vuforia;

public class VuforiaComponents : MonoBehaviour, ITracking {

	#region private variables
	private static VuforiaComponents vc;
	private static ITracking it;
	private TrackableBehaviour mTrackableBehaviour;
	#endregion

	/// <summary>
	/// Gets the instance.
	/// </summary>
	/// <returns>The instance.</returns>
	public static ITracking GetInstance() {
		if (it == null) {
			vc = new VuforiaComponents ();
			it = (ITracking)vc;
		}
		return it; 
	}

//	void Start() {
//		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
//		if (mTrackableBehaviour) {
//			mTrackableBehaviour.RegisterTrackableEventHandler(this);
//		}
//	}

	public void Test() {
		Debug.Log ("VuforiaComponents.Test");
	}

	public bool TrackingNotFound(){
//		StateManager sm = TrackerManager.Instance.GetStateManager (); 
//		IEnumerable<TrackableBehaviour> trackables = sm.GetTrackableBehaviours ();
//
//		return trackables;

		TrackableBehaviour.Status currentStatus = TrackableBehaviour.Status.DETECTED;
		if (currentStatus == TrackableBehaviour.Status.NOT_FOUND ||
		    currentStatus == TrackableBehaviour.Status.UNKNOWN ||
		    currentStatus == TrackableBehaviour.Status.UNDEFINED) {
			return true;
			Debug.Log ("TrackingBehavior.Status.if");
		}
		else {
			return false;
			Debug.Log ("TrackingBehavior.Status.else");
		}
	}	
}
