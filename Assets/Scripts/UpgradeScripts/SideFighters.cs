using UnityEngine;
using System.Collections;

public class SideFighters : MonoBehaviour 
{
	public GameObject sideRight;
	public GameObject sideLeft;

	void OnTriggerEnter()
	{
		sideRight.SetActive (true); //memes
		sideLeft.SetActive (true);
	}

}
