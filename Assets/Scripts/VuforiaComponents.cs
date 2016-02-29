using UnityEngine;
using System.Collections;

public class VuforiaComponents : ITracking {

	public static VuforiaComponents vc;

	public static VuforiaComponents GetInstance(){
		if (vc == null)
			vc = new VuforiaComponents ();

		return vc; 
	}

	public void Test(){
		Debug.Log ("VuforiaComponents.Test");
	}
}
