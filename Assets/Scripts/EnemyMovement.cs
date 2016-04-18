using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour 
{
	public Transform bottom;
	public Transform top;
	public bool goingDown;
	float planeRot;

	Vector3 movement;
	int speed = 2;

	void Start()
	{
		goingDown = true;
		movement = new Vector3 (0, 1, 0);
		planeRot = transform.localScale.y;

	}

	void Update()
	{
		transform.Translate (movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "TopTurn") 
		{
			movement = new Vector3 (0, 1, 0);
			goingDown = true;
			transform.localScale = new Vector2(transform.localScale.x, planeRot);
		}

		if (other.gameObject.tag == "BottomTurn") 
		{
			movement = new Vector3(0, -0.5f, 0);
			goingDown = false;
			transform.localScale = new Vector2(transform.localScale.x, -planeRot);

		}
	}

}
