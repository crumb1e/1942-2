using UnityEngine;
using System.Collections;

public class DestroyBullets : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		print ("collide");
		if(other.gameObject.tag == "Bullet" || other.gameObject.tag == "EnemyBullet");
		{
			Destroy(other.gameObject);
		}


	}

}
