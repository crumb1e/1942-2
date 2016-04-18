using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour 
{
	public void Die(int points)
	{
		GameObject score = GameObject.FindGameObjectWithTag ("Score");
		ScoreManager scoreManager = score.GetComponent<ScoreManager> ();

		scoreManager.scoreAmount += points;
		Destroy (gameObject);
	}
}
