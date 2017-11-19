using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloneCard : MonoBehaviour 
{
	public GameObject prefab;
	public Canvas canvas;
	
	// Use this for initialization
	void Start ()
	{
		Sprite[] cards = Resources.LoadAll<Sprite> ("cards");
		// Canvas canvas = GameObject.FindWithTag("Canvas").GetComponent<Canvas>();
		float absWidth = canvas.GetComponent<RectTransform>().rect.width;
		float oneAbsW = absWidth / 9; // единица масштабирования ширины - смотреть issue #49
		float absHeight = canvas.GetComponent<RectTransform>().rect.height;
		float oneAbsH = absHeight / 16; // единица масштабирования высоты - смотреть issue #49
		for (int i = 0; i < 3; ++i)
		{
			for (int j = 0; j < 4; ++j)
			{
		 		GameObject button = Instantiate(prefab, canvas.transform);
		 		button.name = "Card" + i.ToString() + j.ToString();
		 		button.transform.position = new Vector3(-3f * oneAbsW + j * 2f * oneAbsW, 
		 												0.5f * oneAbsH + i * 2f * oneAbsH, 
		 												0f);
		 		button.transform.localScale = new Vector3(3f, 3f, 3f);
		 		button.GetComponent<Image>().sprite = cards[Random.Range(0, cards.Length - 1)];
			}
		}

	}
}