using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour 
{
	public GameObject bullet;
	public Transform barrelLeft;		
	public Transform barrelRight;
	public Transform leftPow;
	public Transform rightPow;

	public bool doubleDamage;

	void Start()
	{
		doubleDamage = false;
	}

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Z) && doubleDamage == false) 
		{
			Instantiate(bullet, barrelLeft.position, Quaternion.identity);
			Instantiate(bullet, barrelRight.position, Quaternion.identity);

		}

		if (Input.GetKeyDown (KeyCode.Z) && doubleDamage == true) 
		{
			Instantiate(bullet, barrelLeft.position, Quaternion.identity);
			Instantiate(bullet, barrelRight.position, Quaternion.identity);
			Instantiate(bullet, leftPow.position, Quaternion.identity);
			Instantiate(bullet, rightPow.position, Quaternion.identity);
		}
	}
}
