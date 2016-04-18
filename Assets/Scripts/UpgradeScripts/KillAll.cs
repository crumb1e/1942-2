using UnityEngine;
using System.Collections;

public class KillAll : MonoBehaviour
{
	int total;
	GameObject[] enemies;

	void Update()
	{
		enemies = GameObject.FindGameObjectsWithTag ("Enemy");
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "SuperAce") 
		{
			print (enemies.Length);
			foreach(GameObject e in enemies)
			{
				Destroy(e);
				Destroy(gameObject);
			}
		}
	}

}
