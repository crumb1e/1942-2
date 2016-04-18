using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour 
{
	public Text highScore;
	public int num;

	void Update()
	{
		num = PlayerPrefs.GetInt ("highScore");
		highScore.text = "HighScore: " + num.ToString();
	}

}
