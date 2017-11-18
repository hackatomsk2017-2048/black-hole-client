using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloneCard : MonoBehaviour 
{
	public GameObject button;
	public Canvas canvas;

	private GameObject[][] buttons;

	// Use this for initialization
	void Start () 
	{
		Debug.Log ("wefwef");

		buttons = new GameObject[5][];
		for (int i = 0; i < 5; i++) {
			buttons[i] = new GameObject[5];
		}

		Sprite[] cards = Resources.LoadAll<Sprite> ("cards");

		for (int i = 0; i < 1; i++) {
			Debug.Log ("1");
				
			for (int j = 0; j < 3; j++) {

				GameObject newButton = Instantiate (button, button.transform);
				newButton.GetComponent<Image> ().overrideSprite = cards [j];
			}
		}

	}
}
