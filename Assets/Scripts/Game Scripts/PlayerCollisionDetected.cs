using UnityEngine;
using System.Collections;

public class PlayerCollisionDetected : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll)
	{		
		if (coll.gameObject.name == "obstacle_prefab(Clone)")
		{
			PlayerControlsScript.speed = 0;
			Application.LoadLevel("EndGameScreen");
		}
	}
}
