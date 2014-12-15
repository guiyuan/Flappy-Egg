using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour 
{
	public GameObject UICanvas;
	public Text ScoreText;

	private int mScore = 0;

	public void GameOver()
	{
		UICanvas.GetComponent<GameOver> ().Over ();
	}

	public void Score(int s)
	{
		mScore += s;
	}

	void Update()
	{
		ScoreText.text = "Score: " + mScore;
	}
}
