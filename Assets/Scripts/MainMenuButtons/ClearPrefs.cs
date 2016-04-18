using UnityEngine;
using System.Collections;

public class ClearPrefs : MonoBehaviour 
{
	public void OnClick()
	{
		PlayerPrefs.DeleteAll ();
	}

}
