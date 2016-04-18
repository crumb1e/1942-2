using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour 
{
	public float speed = 0.5f;

	void Update()
	{
		Vector2 offset = new Vector2 (0, Time.time * speed);
		GetComponent<Renderer>().material.mainTextureOffset = offset;

		//transform.Translate (Vector3.down * Time.deltaTime);
	}

}
