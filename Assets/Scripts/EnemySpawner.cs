using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour 
{
	public GameObject enemy;
	
	float time = 1f;
	float rate = 1f;

	void Start()
	{
		InvokeRepeating ("SpawnEnemy", time, rate);
	}

	void SpawnEnemy()
	{
		Instantiate (enemy, gameObject.transform.position, enemy.transform.rotation);
	}

	void PauseSpawn(int seconds)
	{

	}

}
