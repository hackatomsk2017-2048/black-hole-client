using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPoint : MonoBehaviour
{
	public GameObject prefub;
	public GameObject button;

	void Start () 
	{
		Debug.Log ("wefkhwekfweknfj");
		// for (int i = 0; i < 5; i++)
		// {
			button = Instantiate(prefub, prefub.transform);
			button.SetActive(true);
			button.transform.position = new Vector3(Screen.width/2, Screen.height/2, 0);
		// }

	}
}
