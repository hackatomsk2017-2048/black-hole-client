using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deck : MonoBehaviour
{
	public GameObject prefab;
	public Canvas canvas;

	private Card [][] m_cards;

	// Use this for initialization
	void Start ()
	{
		m_cards = new Card[5][];
		for (int i = 0; i < 5; i++)
		{
			m_cards[i] = new Card[5];
		}
		
		Sprite[] cardsImages = Resources.LoadAll<Sprite> ("cards");
		float absWidth = canvas.GetComponent<RectTransform>().rect.width;
		float oneAbsW = absWidth / 9; // единица масштабирования ширины - смотреть issue #49
		float absHeight = canvas.GetComponent<RectTransform>().rect.height;
		float oneAbsH = absHeight / 16; // единица масштабирования высоты - смотреть issue #49
		for (int i = 0; i < 3; ++i)
		{
			for (int j = 0; j < 4; ++j)
			{
				Debug.Log("wqewef");
				m_cards [i] [j] = new Card(prefab, canvas.transform, i*j, new Vector3(
					-3f * oneAbsW + j * 2f * oneAbsW, 
					0.5f * oneAbsH + i * 2f * oneAbsH, 
					0f), cardsImages
				);
				m_cards [i] [j].Start();
			}
		}

	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
