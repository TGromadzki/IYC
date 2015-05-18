using UnityEngine;
using System.Collections;

public class CoinCollected : MonoBehaviour {

	private bool isCollected = false;
	private float lerpAmount;
	private Vector3 coinStartPoint = new Vector3(0, 0, 0);
	private Vector3 coinEndPoint = new Vector3(-5.5f, 0, 0);
	private Transform player;
	public ParticleSystem coinCollectParticles;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (isCollected == true)
		{
			coinEndPoint.y = player.position.y + 5.3f;
			transform.position = Vector3.Lerp(coinStartPoint, coinEndPoint, lerpAmount);
			lerpAmount += Time.deltaTime * 2.5f;
			if (coinEndPoint.x == transform.position.x)
			{
				PlayerControlsScript.score++;
				Destroy(gameObject);
			}
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{		
		if (coll.gameObject.name == "player")
		{
			coinStartPoint = transform.position;
			Instantiate(coinCollectParticles, coinStartPoint, transform.rotation);
			isCollected = true;
		}
	}
}
