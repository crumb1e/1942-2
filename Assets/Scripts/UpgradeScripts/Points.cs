using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		GameObject scoreMan = GameObject.Find ("ScoreManager");
		ScoreManager score = scoreMan.GetComponent<ScoreManager> ();

		if (other.gameObject.tag == "SuperAce") 
		{
			score.scoreAmount += 100;
			Destroy(gameObject);
		}
	}

}
