using UnityEngine;
using System.Collections;

public class ScreenRes : MonoBehaviour 
{
	void Awake()
	{
		Screen.SetResolution (480, 640, false);
	}

}
