using UnityEngine;
using System.Collections;

public class DoubleDamage : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		GameObject player = GameObject.FindGameObjectWithTag("SuperAce");
		PlayerShooting shooting = player.GetComponent<PlayerShooting> ();

		if (other.gameObject.tag == "SuperAce") 
		{
			print ("doubleDamage collide");
			shooting.doubleDamage = true;
			Destroy(gameObject); //:(

		}
	}

}
