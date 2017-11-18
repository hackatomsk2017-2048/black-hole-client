using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneCard : MonoBehaviour 
{
	public GameObject button;
	public Canvas canvas;
	// Use this for initialization
	void Start () 
	{
		GameObject newButton = Instantiate(button, button.transform);
		// newButton.SetActive(true);
		var buttonPosition = newButton.transform.position;
		newButton.transform.position.Set(buttonPosition.x, buttonPosition.y + 50, buttonPosition.z);
	}
}
