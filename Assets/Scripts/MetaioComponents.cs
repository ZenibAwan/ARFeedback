using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using metaio;

public class MetaioComponents : ITracking {

	#region private variables
	private static MetaioComponents mc;
	private static ITracking it;
	#endregion

	/// <summary>
	/// Gets the instance.
	/// </summary>
	/// <returns>The instance.</returns>
	public static ITracking GetInstance() {
		if (it == null) {
			mc = new MetaioComponents ();
			it = (ITracking)mc;
		}
		return it;
	}

	public void Test() {
		Debug.Log ("MetaioComponents.Test");
	}

//	public int GetTrackingValue() {
//		return MetaioSDKUnity.getTrackingValues ();
//	}

	public bool TrackingNotFound() {
		return true;
	}
}
