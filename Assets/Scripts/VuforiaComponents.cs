using UnityEngine;
using System.Collections;

public class VuforiaComponents : ITracking {

	#region private variables
	private static VuforiaComponents vc;
	private static ITracking it;
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

	public void Test() {
		Debug.Log ("VuforiaComponents.Test");
	}
}
