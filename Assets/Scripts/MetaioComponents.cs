using UnityEngine;
using System.Collections;

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
}
