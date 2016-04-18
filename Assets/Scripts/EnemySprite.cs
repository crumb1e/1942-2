using UnityEngine;
using System.Collections;

public class EnemySprite : MonoBehaviour 
{
	public Sprite up;
	public Sprite down;

	SpriteRenderer spriteRen;

	void Start()
	{
		spriteRen = GetComponent<SpriteRenderer> ();

	}

	void Update()
	{
		GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
		EnemyMovement enemyMovement = enemy.GetComponent<EnemyMovement> ();

		if (enemyMovement.goingDown == true) 
		{
			spriteRen.sprite = down;
		}

		if (enemyMovement.goingDown == false) 
		{
			spriteRen.sprite = up;
		}
	}
}
