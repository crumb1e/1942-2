using UnityEngine;
using System.Collections;

public class BossSpawning : MonoBehaviour {

	public GameObject boss;

	float time = 20f;

	void Start()
	{
		Invoke ("SpawnBoss", time);
	}

	void SpawnBoss()
	{
		Instantiate (boss, gameObject.transform.position, boss.transform.rotation);
	}
}
