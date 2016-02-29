using UnityEngine;
using System.Collections;
using System.IO;

public class EventHandling : MonoBehaviour 
{
	Event EventCAMERA_BLOCKED;

	void OnEnable()
	{
		EventManager.CAMERABLOCKED += CAMERABLOCKED;
	}
	
	
	void OnDisable()
	{
		EventManager.CAMERABLOCKED -= CAMERABLOCKED;
	}


	void CAMERABLOCKED()
	{
		//CameraObscuredEvent coe = new CameraObscuredEvent();
		//FeedbackView FeedbackCAMERABLOCKED = new FeedbackView (coe.getMessageToUser(), coe.getImage()); 
	}
}