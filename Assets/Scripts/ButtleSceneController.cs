using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Networking; 
using System.Text; 

public class ButtleSceneController : MonoBehaviour {

	public GameObject prefab;
	public Canvas canvas;

	// Use this for initialization
	void Start () {
		StartCoroutine(Upload());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Upload()
	{ 
		//WWWForm form = new WWWForm(); 
		//form.AddField("myField", "myData"); 

		UnityWebRequest www = UnityWebRequest.Get("http://game.fr.to/cards"); 
		yield return www.SendWebRequest(); 

		//if(www.isNetworkError || www.isHttpError) { 
		//Debug.Log(www.error); 
		//} 
		//else { 

		int cardIndex = Convert.ToInt32(www.downloadHandler.text);

		Debug.Log(cardIndex);

		Sprite[] cardsImages = Resources.LoadAll<Sprite> ("cards");
		float absWidth = canvas.GetComponent<RectTransform>().rect.width;
		float oneAbsW = absWidth / 9; // единица масштабирования ширины - смотреть issue #49
		float absHeight = canvas.GetComponent<RectTransform>().rect.height;
		float oneAbsH = absHeight / 16; // единица масштабирования высоты - смотреть issue #49
		
		int index = 0;

		Card card = new Card(prefab, canvas.transform, index, new Vector3(
			-3f * oneAbsW + 3 * 2f * oneAbsW, 
			0.5f * oneAbsH + 3 * 3f * oneAbsH, 
			0f), 
			cardsImages,
			Card.intToCardType(cardIndex),
			null
		);

		card.setPosition(new Vector3(100,100, 1));

	}

	public void ExitGame()
	{
		Debug.Log("Application.Quit();");
		Application.Quit();		
	}

}
