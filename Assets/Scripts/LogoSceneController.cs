using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoSceneController : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		StartCoroutine(ToPrepeareScene());
	}

	public IEnumerator ToPrepeareScene()
	{
		yield return new WaitForSeconds(3); // waits 3 seconds
		//trigger = true; // will make the update method pick up 
		Debug.Log("wefwkuehfwkej");
		Application.LoadLevel("PrepareScene");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
