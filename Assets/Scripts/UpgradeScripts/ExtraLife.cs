using UnityEngine;
using System.Collections;

public class ExtraLife : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		GameObject scoreMan = GameObject.Find("ScoreManager");
		ScoreManager score = scoreMan.GetComponent<ScoreManager> ();

		if (other.gameObject.tag == "SuperAce") 
		{
			score.health++;
			Destroy(gameObject);
		}
	}

}
