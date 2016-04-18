using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public float speed = 15f;
	Vector3 movement;
	CharacterController superAce;

	void Start () 
	{
		superAce = GetComponent<CharacterController> ();

	}
	

	void Update () 
	{
		movement.x = Input.GetAxis("Horizontal");
		movement.y = Input.GetAxis("Vertical");
		superAce.Move (movement * speed * Time.deltaTime);
	}
}
