using UnityEngine;
using System.Collections;

public class Enemy : Death, IDamageable<int>
{
	public int health = 4;
	int points = 10;
	int chooseSpawn;
	GameObject spawn;
	GameObject[] spawnpoints = new GameObject[5];

	void Start()
	{
		spawnpoints = GameObject.FindGameObjectsWithTag("TopSpawns");
		chooseSpawn = Random.Range (0, spawnpoints.Length);
		spawn = spawnpoints [chooseSpawn];

		gameObject.transform.position = spawn.transform.position;
	}

	void Update()
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
			print ("Enemy damage boys");
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
