using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour 
{
	private Animator anim;
	private bool mGameOver = false;
	
	void Start()
	{
		anim = GetComponent<Animator> ();
	}

	public void Restart()
	{
		if (mGameOver) 
		{
			Application.LoadLevel(Application.loadedLevel);
			mGameOver = false;
		}
	}
	public void Over()
	{
		anim.SetTrigger ("GameOver");
		mGameOver = true;
	}
}
