using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerControlsScript : MonoBehaviour {

	public Vector3 startPoint = new Vector3(0, -2.5f, 0);
	public static float speed = 2.0f;
	public bool isJumpPossible = true;
	private Vector3 endPoint = new Vector3(0, 0, 0);
	private float lerpAmount;
	public static int score = 0;
	public Text scoreText;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = score.ToString ();
		startPoint.y += Time.deltaTime * speed;
		if (isJumpPossible == true)
		{
			startPoint.x = endPoint.x;
			lerpAmount = 0;
			transform.position = startPoint;
			if (Input.GetKeyDown(KeyCode.LeftArrow) == true && transform.position.x >= 0)
			{
				isJumpPossible = false;
				endPoint.x -= 3.5f;
			}
			if (Input.GetKeyDown(KeyCode.RightArrow) == true && transform.position.x <= 0)
			{
				isJumpPossible = false;
				endPoint.x += 3.5f;
			}
		}
		if (isJumpPossible == false)
		{
			endPoint.y = startPoint.y;
			transform.position = Vector3.Lerp(startPoint, endPoint, lerpAmount);
			lerpAmount += Time.deltaTime * speed;
			if (transform.position.x == endPoint.x)
			{
				isJumpPossible = true;
			}
		}
		if (startPoint.y > 20 && startPoint.y < 50) {
			speed = 2.5f;
		}
		if (startPoint.y >= 50 && startPoint.y < 75) {
			speed = 2.5f;
		}
		if (startPoint.y >= 75) {
			speed = 3.0f;
		}
	}
}
