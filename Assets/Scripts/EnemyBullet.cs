using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour

{
	public float speed;
	
	void Start()
	{
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.up * speed;
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "SuperAce")
		{
			print("HitSuperAce");
			GameObject score = GameObject.FindGameObjectWithTag("Score");
			ScoreManager scoreManager = score.GetComponent<ScoreManager> ();

			scoreManager.health--;
			Destroy(gameObject);
		}
	}

}
