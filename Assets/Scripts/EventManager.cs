using UnityEngine;
using System.Collections;
using System.IO;

public class EventManager : MonoBehaviour 
{
	#region public variables
	public delegate void ClickAction();
	public static event ClickAction Event1;
	public static event ClickAction Event2;
	public static event ClickAction Event3;
	public static event ClickAction CAMERABLOCKED;
	public byte[] bytes;
	public int totalPixels;
	FeedbackView fbw;
	Event evt;
	#endregion


	#region Unity methods


	void Update(){
		/*int randomNumber;
		randomNumber = Random.Range (0, 4);
		Debug.Log ("randomNumber: " + randomNumber);
		if (randomNumber == 0)
		if (Event4 !=null)
			Event4 ();*/

		if (evt != null) {
			if (Input.deviceOrientation == DeviceOrientation.FaceUp) {
				if (CAMERABLOCKED != null)
					CAMERABLOCKED ();
			}
		}


	




		/***********************************************************************************
		  								LIGHT CONDITIONS
		************************************************************************************/

		//************************ CHECK IF ENVIRONMENT IS TOO DARK ************************
		/*StartCoroutine(TakeScreen ());
		if (IsDark (bytes, 40, 0.9)) 
		{
			if (Event4 != null)
				Event4 ();
		}*/


		/*
		//************************ CHECK IF ENVIRONMENT IS TOO BRIGHT ************************
		StartCoroutine(TakeScreen ());
		if (IsBright (bytes, 40, 0.9)) 
		{
			if (Event4 != null)
				Event4 ();
		}*/

	}
	
	/*void Update(){
		StartCoroutine(TakeScreen ());
		bool dark = IsDark(bytes, 40, 0.9); 
		Debug.Log("dark: " + dark);
	}*/
	#endregion



	#region other methods
	/*public IEnumerator TakeScreen()
	{
		yield return new WaitForEndOfFrame();
		string pathToScreenie = Path.Combine(Application.persistentDataPath, "screenie.png");
        Texture2D texture = new Texture2D(Screen.width, Screen.height);
		totalPixels = Screen.width * Screen.height;
        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        texture.Apply();
        bytes = texture.EncodeToPNG();
        File.WriteAllBytes(pathToScreenie, bytes);      
        DestroyObject(texture);
    }

	//tbd
	public bool IsDark (byte [] picture, byte tolerance, double darkProcent)
	{
		if (totalPixels != 0) 
		{
			int count = 0;
			for (int i = 0; i < bytes.Length - 2; i += 4) 
			{
				byte r = bytes [i + 2], g = bytes [i + 1], b = bytes [i];
				byte darkness = (byte)System.Math.Round ((0.299 * r + 0.5876 * g + 0.114 * b));
				if (darkness <= tolerance)
					count++;
			}
			return (1d * count / totalPixels) <= darkProcent;
		} else
			return false;
	}

	//tbd
	public bool IsBright (byte [] picture, byte tolerance, double darkProcent)
	{
		if (totalPixels != 0) 
		{
			int count = 0;
			for (int i = 0; i < bytes.Length - 2; i += 4) 
			{
				byte r = bytes [i + 2], g = bytes [i + 1], b = bytes [i];
				byte brightness = (byte)System.Math.Round ((0.299 * r + 0.5876 * g + 0.114 * b));
				if (brightness <= tolerance)
					count++;
			}
			return (1d * count / totalPixels) <= darkProcent;
		} else 
			return false;
	}*/

	/*public bool DeviceOrientationDown ()
	{
		float x, y;
		x = Input.gyro.attitude.x;
		y = Input.gyro.attitude.y;
	}*/

	public static Quaternion ConvertRotation(Quaternion q)
	{
		return new Quaternion(q.x, q.y, -q.z, -q.w);

	}

	/*void SaveScreenie ()
	{
		string pathToScreenie = Path.Combine(Application.persistentDataPath, "screenie.png");
		Debug.Log ("pathToScreenie" + pathToScreenie);
		Application.CaptureScreenshot (pathToScreenie);
		Debug.Log ("Screenie saved");

	}*/
	#endregion	
}