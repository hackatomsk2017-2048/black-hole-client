using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Deck : MonoBehaviour
{
	public GameObject prefab;
	public Canvas canvas;

	private List<Card> m_cards;
	private List<int> m_selectedCards;

	// Use this for initialization
	void Start ()
	{
		createCards();
	}
	
	private void createCards()
	{
		m_cards = new List<Card>();
		m_selectedCards = new List<int>();
		
		Sprite[] cardsImages = Resources.LoadAll<Sprite> ("cards");
		float absWidth = canvas.GetComponent<RectTransform>().rect.width;
		float oneAbsW = absWidth / 9; // единица масштабирования ширины - смотреть issue #49
		float absHeight = canvas.GetComponent<RectTransform>().rect.height;
		float oneAbsH = absHeight / 16; // единица масштабирования высоты - смотреть issue #49
		
		int index = 0;

		for (int i = 0; i < 3; ++i)
		{
			for (int j = 0; j < 4; ++j)
			{
				m_cards.Add(new Card(prefab, canvas.transform, index, new Vector3(
					-3f * oneAbsW + j * 2f * oneAbsW, 
					0.5f * oneAbsH + i * 3f * oneAbsH, 
					0f), 
					cardsImages,
					Card.intToCardType(UnityEngine.Random.Range(0, cardsImages.Length - 1)),
					this
				));
				index++;
			}
		}

	}

	public void OnCardClick(int index)
	{
		Debug.Log("You have clicked the button! " + Convert.ToString(index));

		if (!m_selectedCards.Contains(index)) 
		{
			Card card = m_cards[index];

			m_selectedCards.Add(index);

			float absWidth = canvas.GetComponent<RectTransform>().rect.width;
			float oneAbsW = absWidth / 9; // единица масштабирования ширины - смотреть issue #49
			float absHeight = canvas.GetComponent<RectTransform>().rect.height;
			float oneAbsH = absHeight / 16; // единица масштабирования высоты - смотреть issue #49

			if (m_selectedCards.Count < 5)
			{
				card.setPosition(new Vector3(
							-250 + m_selectedCards.Count * 100, 
							-300, 
							0f));
				card.activatePositioning(false);

				Debug.Log(Convert.ToString(m_selectedCards.Count));

			}

		}


	}

	// Update is called once per frame
	void Update ()
	{
		
	}
}
