using UnityEngine;
using System.Collections;

public class PrefabsSpawner : MonoBehaviour {

	public GameObject obstaclePrefab;
	public GameObject coinPrefab;
	private float currentY;

	// Use this for initialization
	void Start () {
		currentY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentY - transform.position.y < - 2.5f) 
		{
			currentY = transform.position.y;
			SpawnObstacle (currentY);
		}
	}

	void SpawnObstacle(float y){
		float randomX;
		float randomX2;
		float coinX;
		int randomInt = Random.Range (0, 6);
		if (randomInt == 0) {
			randomX = -3.5f;
			int randomCoin = Random.Range (0, 2);
			if (randomCoin == 0){
				coinX = 0;
			} else {
				coinX = 3.5f;
			}
			Vector3 newCoinPosition = new Vector3 (coinX, y + 4.0f, 0);
			Instantiate (coinPrefab, newCoinPosition, transform.rotation);
		} else if (randomInt == 1) {
			randomX = 0;
			int randomCoin = Random.Range (0, 2);
			if (randomCoin == 0){
				coinX = -3.5f;
			} else {
				coinX = 3.5f;
			}
			Vector3 newCoinPosition = new Vector3 (coinX, y + 4.0f, 0);
			Instantiate (coinPrefab, newCoinPosition, transform.rotation);
		} else if (randomInt == 2) {
			randomX = 3.5f;
			int randomCoin = Random.Range (0, 2);
			if (randomCoin == 0){
				coinX = 0;
			} else {
				coinX = -3.5f;
			}
			Vector3 newCoinPosition = new Vector3 (coinX, y + 4.0f, 0);
			Instantiate (coinPrefab, newCoinPosition, transform.rotation);
		} else if (randomInt == 3) {
			randomX = -3.5f;
			randomX2 = 0;
			Vector3 newPosition2 = new Vector3 (randomX2, y + 4.0f, 0);
			Instantiate (obstaclePrefab, newPosition2, transform.rotation);
		} else if (randomInt == 4){
			randomX = 3.5f;
			randomX2 = 0;
			Vector3 newPosition2 = new Vector3 (randomX2, y + 4.0f, 0);
			Instantiate (obstaclePrefab, newPosition2, transform.rotation);
		} else {
			randomX = -3.5f;
			randomX2 = 3.5f;
			Vector3 newPosition2 = new Vector3 (randomX2, y + 4.0f, 0);
			Instantiate (obstaclePrefab, newPosition2, transform.rotation);
		}
		Vector3 newPosition = new Vector3 (randomX, y + 4.0f, 0);
		Instantiate (obstaclePrefab, newPosition, transform.rotation);
	}
}
