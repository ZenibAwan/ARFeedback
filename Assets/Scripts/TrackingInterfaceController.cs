using UnityEngine;
using System.Collections;
using UnityEditor;

public class TrackingInterfaceController : MonoBehaviour {

	#region public variables
	public enum USEDSDK {NONE, METAIO, VUFORIA};
	[SerializeField] USEDSDK usedSDK;
	#endregion

	#region private variables
	private static ITracking it;
	#endregion

	/// <summary>
	/// Awake this instance.
	/// </summary>
	void Start() {
		LoadSDKFromEnum (usedSDK);
	}

	/// <summary>
	/// Gets the enum value.
	/// </summary>
	/// <returns>The enum value.</returns>
	public USEDSDK GetEnumValue() {
		return usedSDK;
	}

	/// <summary>
	/// Gets the tracking instance.
	/// </summary>
	/// <returns>The tracking instance.</returns>
	public static ITracking GetTrackingInstance() {
		return it;
	}
		
	/// <summary>
	/// Loads the enum SDK.
	/// </summary>
	/// <param name="us">Us.</param>
	void LoadSDKFromEnum(USEDSDK us) {
		switch (us) {
			case USEDSDK.NONE:
				Debug.LogError ("Select your Tracking SDK in the Unity Editor (TrackingInterfaceController.cs)!");
				break;
		case USEDSDK.METAIO:
			Debug.Log ("Metaio is selected");
			it = (ITracking)MetaioComponents.GetInstance ();
	//			it = metaioComponents;
				break;
			case USEDSDK.VUFORIA:
				Debug.Log ("Vuforia is selected");
				it = (ITracking)VuforiaComponents.GetInstance ();
	//			it = vuforiaComponents;
				break;
		}
	}
}