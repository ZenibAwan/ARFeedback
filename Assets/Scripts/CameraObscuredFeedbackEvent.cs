﻿using UnityEngine;
using System.Collections;

class CameraObscuredFeedbackEvent : FeedbackEvent {

	public CameraObscuredFeedbackEvent(){
		this.messageToUser = "Weiß man noch nicht so genau.. TBD";
		this.image = "test";
		this.timeToLive = 10;
	}

	public override void DoAction (){
		return;
	}
}
