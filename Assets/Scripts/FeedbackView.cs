using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FeedbackView : MonoBehaviour {

	#region public variables
	GameObject feedBackView;
	Image img;
	Text txt;
	#endregion

	/// <summary>
	/// Initializes a new instance of the <see cref="FeedbackView"/> class.
	/// </summary>
	/// <param name="feedback">Feedback.</param>
	/// <param name="feedbackImage">Feedback image.</param>
	public FeedbackView(FeedbackEvent evt){
		if (GameObject.Find ("Canvas") == null) 
			Debug.Log ("Please add the FeedbackCanvas prefab from Resources");
		
		else {
			feedBackView = (GameObject)Instantiate (Resources.Load ("Panel")); 
			feedBackView.SetActive (true);
			GameObject canvas = GameObject.Find ("Canvas");
			feedBackView.transform.SetParent (canvas.transform, false);

			GameObject go = GameObject.FindGameObjectWithTag ("Panel");
			go.GetComponentInChildren<Text>().text = evt.getMessageToUser();

			string pathToImage = "Images/" + evt.getImage();
			Sprite texture = Resources.Load<Sprite> (pathToImage);
			img = go.transform.GetChild(0).GetComponent<Image>();
			img.sprite = texture;
		} 
	}
						
	/// <summary>
	/// Shows and hides the feedback.
	/// </summary>
	/// <returns>The and hide.</returns>
	public IEnumerator showAndHide(int time){
		if (feedBackView != null) {
			feedBackView.transform.GetComponent<Animation> ().Play ("FadeIn");
			yield return new WaitForSeconds (time);
			feedBackView.transform.GetComponent<Animation> ().Play ("FadeOut");
			yield return new WaitForSeconds (2);
			Destroy (feedBackView);
		}
	}
}