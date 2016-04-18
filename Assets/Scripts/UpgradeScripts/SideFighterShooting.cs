using UnityEngine;
using System.Collections;

public class SideFighterShooting : MonoBehaviour 
{
	public Transform barrel;
	public GameObject bullet;

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Z)) 
		{
			Instantiate(bullet, barrel.position, Quaternion.identity);
		}
	}

}
