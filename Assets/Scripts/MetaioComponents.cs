using UnityEngine;
using System.Collections;

public class MetaioComponents : ITracking {

	public static MetaioComponents mc;

	public static MetaioComponents GetInstance(){
		if (mc == null)
			mc = new MetaioComponents ();
		
		return mc; 
	}

	public void Test(){
		Debug.Log ("MetaioComponents.Test");
	}
}
