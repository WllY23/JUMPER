using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
	private float score = 0f;
	public Text scoreText;
	private float timer = 0f;
	public Text timerText;
	private int difficultLevel = 1;
	private int maxLevel = 10;
	private int scoreNextLevel = 10;
	private bool isDead = false;
	
	void Update () 
	{
		if (isDead)
			return;
		if (score >= scoreNextLevel)
			LevelUP ();
		score += Time.deltaTime * difficultLevel;
		scoreText.text = "Score: " + ((int)score).ToString () + " m";
		timer += Time.deltaTime;
		timerText.text = "Time: " + ((int)timer).ToString () + " s";
		if (score >=232) 
		{
			score = 232;
		}
	}

	void LevelUP ()
	{
		if (difficultLevel == maxLevel)
			return;
		scoreNextLevel *= 2;
		difficultLevel++;
		GetComponent<PruebaPlayer>().Setspeed (difficultLevel);
	}

	public void Death()
	{
		isDead = true;
	}
}
