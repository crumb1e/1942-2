using UnityEngine;
using System.Collections;

public class MainBoss : Death, IDamageable<int>
{
	public int health = 150;
	int points = 1500;


	void Start () 
	{
	}
	

	void Update () 
	{
		if (health <= 0) 
		{
			Die(points);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Bullet") 
		{
			Destroy(other.gameObject);
			TakeDamage(1);
		}
		
		if (other.gameObject.tag == "SuperAce") 
		{
			Destroy(other.gameObject);
			Application.LoadLevel(Application.loadedLevel);
		}
	}

	public void TakeDamage(int damage)
	{
		health -= damage;
	}
}
