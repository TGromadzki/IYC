using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndGameSummary : MonoBehaviour {
	
	public Text endScoreText;

	// Use this for initialization
	void Start () {
		endScoreText.text = PlayerControlsScript.score.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
