using UnityEngine;
using System.Collections;

public class StartGameButtonScript : MonoBehaviour {
	
	public void LoadGame()
	{
		Application.LoadLevel ("Game");
	}
}