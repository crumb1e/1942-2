using UnityEngine;
using System.Collections;

public class SmallRedShooting : MonoBehaviour 
{
	public Transform leftGun;
	public Transform middleGun;
	public Transform rightGun;

	public GameObject bullet;
	
	void Start () 
	{
		StartCoroutine (Shooting ());
	}

	IEnumerator Shooting()
	{
		while (true) 
		{
			Instantiate (bullet, leftGun.position, leftGun.rotation);
			Instantiate (bullet, middleGun.position, middleGun.rotation);
			Instantiate (bullet, rightGun.position, rightGun.rotation);
			yield return new WaitForSeconds(3f);

		}
	}
}
