using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour 
{
	private GameController gc;

	void Start()
	{
		GameObject go = GameObject.FindGameObjectWithTag ("GameController");
		if (go != null) 
		{
			gc = go.GetComponent<GameController>();		
		}

		if (gc == null) 
		{
			Debug.Log("GameOver object is not find!");		
		}
	}

	void OnTriggerEnter(Collider other) 
	{
		if (gameObject.name != "Boundary" && other.tag == "Bird") 
		{
			// Game Over
			print("Failed!");
			gc.GameOver();
		}
	}

	void OnTriggerExit(Collider other) 
	{
		if (gameObject.name == "Boundary" && other.tag == "Bird") 
		{
			gc.GameOver();		
		}
	}

}
