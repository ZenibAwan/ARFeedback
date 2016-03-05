using UnityEngine;
using System.Collections;

public abstract class FeedbackEvent {
	
	public string messageToUser;
	public string image;
	public int timeToLive;
		
	public string getMessageToUser(){
		return messageToUser;
	}

	public string getImage(){
		return image;
	}

	public int getTimeToLive(){
		return timeToLive;
	}

	public void setMessageToUser(string pMessageToUser){
		this.messageToUser = pMessageToUser;
	}

	public void setImage(string pImage){
		this.image = pImage;
	}

	public void setTimeToLive(int pTimeToLive){
		this.timeToLive = pTimeToLive;
	}

	public abstract void DoAction ();
}