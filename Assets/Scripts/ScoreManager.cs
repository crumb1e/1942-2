using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour 
{
	public int scoreAmount;
	public int hsAmount;
	public int health;
	public Text score;
	public Text lives;
	public Text highScore;

	void Start()
	{
		hsAmount = PlayerPrefs.GetInt("highScore");
		highScore.text = "HighScore: " + hsAmount.ToString(); 

	}

	void Update()
	{	
		score.text = "Score: " + scoreAmount.ToString ();
		lives.text = "Lives Remaining: " + health.ToString ();

		if (health <= 0 && hsAmount < scoreAmount) 
		{	
			hsAmount = scoreAmount;
			PlayerPrefs.SetInt("highScore", hsAmount);
			Application.LoadLevel(Application.loadedLevel);
		}

		if (health <= 0) 
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}