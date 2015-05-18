using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour {

	public Vector3 cameraStartPoint = new Vector3(0, 0, -10);
	public int bgCounter = 0;
	public bool bgFlag = true;
	public GameObject backgroundPrefab;
	private Transform player;

	// Use this for initialization
	void Start () {
		DrawBackground (bgCounter);
		player = GameObject.Find ("player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if ((cameraStartPoint.y > (bgCounter - 1) * 7.2f - 0.3f) && bgFlag == true) {
			bgFlag = false;
			DrawBackground(bgCounter);
		}
		cameraStartPoint.y = player.position.y + 2.5f;
		transform.position = cameraStartPoint;
	}

	void DrawBackground(int i){
		float newY = i * 7.2f;
		Vector3 newPosition = new Vector3 (0, newY, 1);
		Instantiate (backgroundPrefab, newPosition, transform.rotation);
		bgCounter++;
		bgFlag = true;
	}
}