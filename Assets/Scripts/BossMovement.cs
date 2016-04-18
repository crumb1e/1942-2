using UnityEngine;
using System.Collections;

public class BossMovement : MonoBehaviour 
{
	Vector3 movement;
	int speed = 2;

	void Start () 
	{
		movement = new Vector3 (0, 1, 0);
	}
	
	void Update () 
	{
		transform.Translate (movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "BossFirstStop") 
		{
			print ("First Stop");
			speed = 0;
		}
	}
}
