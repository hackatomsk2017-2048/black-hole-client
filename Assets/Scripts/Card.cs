using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour {

	private int m_id;
	private GameObject m_prefab;
	private Transform m_transform;
	private Vector3 m_position;
	private Sprite[] m_cards;

	public int id()
	{
		return m_id;
	}

	public Card(GameObject prefab, Transform transform, int id, Vector3 position, Sprite[] cards)
	{
		m_id = id;
		m_position = position;
		m_prefab = prefab;
		m_transform = transform;
		m_cards = cards;
	}

	// Use this for initialization
	public void Start ()
	{
 		GameObject button = Instantiate(m_prefab, m_transform);
 		button.transform.position = m_position;
 		button.transform.localScale = new Vector3(3f, 3f, 3f);
 		button.GetComponent<Image>().sprite = m_cards[Random.Range(0, m_cards.Length - 1)];
		button.GetComponent<Button>().onClick.AddListener(OnClick);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnClick()
	{
		Debug.Log("You have clicked the button!");
	}

}
