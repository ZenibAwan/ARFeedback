using UnityEngine;
using System.Collections;

public class TrackingMethods : IMetaio, IVuforia {

	void IVuforia.Test(){
		Debug.Log ("TrackingMethods.IVuforia.Test");
	}

	void IMetaio.Test(){
		Debug.Log ("TrackingMethods.IMetaio.Test");
	}
}
