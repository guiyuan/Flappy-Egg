using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour 
{
	public int UnitScore;
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

	void OnTriggerExit(Collider other) 
	{
		if (other.tag == "Bird") 
		{
			gc.Score(UnitScore);
		}
	}
}
