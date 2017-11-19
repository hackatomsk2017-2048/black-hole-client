using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Card : MonoBehaviour {
	public enum CardType
	{
		PLUS_1 = 0,
		PLUS_2 = 1,
		PLUS_3 = 2,
		PLUS_4 = 3,
		PLUS_5 = 4,
		PLUS_6 = 5,
		PLUS_7 = 6,
		PLUS_8 = 7,
		PLUS_9 = 8
	}

	public static int cardTypeToInt(CardType cardType)
	{
		return (int) cardType;
	}

	public static CardType intToCardType(int index)
	{
		switch(index)
		{
			case 0: { return CardType.PLUS_1; }; break;
			case 1: { return CardType.PLUS_2; }; break;
			case 2: { return CardType.PLUS_3; }; break;
			case 3: { return CardType.PLUS_4; }; break;
			case 4: { return CardType.PLUS_5; }; break;
			case 5: { return CardType.PLUS_6; }; break;
			case 6: { return CardType.PLUS_7; }; break;
			case 7: { return CardType.PLUS_8; }; break;
			case 8: { return CardType.PLUS_9; }; break;
		}
		return CardType.PLUS_1;
	}

	private GameObject m_button;
	private bool m_positionActivated = true;
	private int m_id;
	private CardType m_cardType;

	public int id()
	{
		return m_id;
	}

	public CardType cardType()
	{
		return m_cardType;
	}

	public void setPosition(Vector3 position)
	{
		if (m_positionActivated)
		{
			m_button.transform.position = position;
		}
	}

	public void activatePositioning(bool activate)
	{
		m_positionActivated = activate;
	}

	public Card(GameObject prefab, Transform transform, int id, Vector3 position, Sprite[] cards, CardType cardType, Deck deck)
	{
		m_id = id;
		m_cardType = cardType;

 		m_button = Instantiate(prefab, transform);
 		m_button.transform.position = position;
 		m_button.transform.localScale = new Vector3(2f, 2f, 2f);
 		// button.GetComponent<Image>().sprite = m_cards[Random.Range(0, m_cards.Length - 1)];
 		m_button.GetComponent<Image>().sprite = cards[Card.cardTypeToInt(cardType)];
 		// button.GetComponent<Image>().sprite = m_cards[0];
		// button.GetComponent<Button>().onClick.AddListener(OnClick);
		m_button.GetComponent<Button>().onClick.AddListener(() => deck.OnCardClick(m_id));

	}

	// Use this for initialization
	public void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

}
