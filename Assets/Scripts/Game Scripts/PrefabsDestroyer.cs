using UnityEngine;
using System.Collections;

public class PrefabsDestroyer : MonoBehaviour {

	private Transform cameraHandle;

	// Use this for initialization
	void Start () {
		cameraHandle = GameObject.Find ("Main Camera").transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 cameraPosition = cameraHandle.position;
		if (transform.position.y < cameraPosition.y - 6.0f) {
			DestroyObject(gameObject);	
		}
	}
}
