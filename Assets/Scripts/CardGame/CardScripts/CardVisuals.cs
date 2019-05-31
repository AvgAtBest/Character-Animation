using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HearthStone2
{
	public class CardVisuals : MonoBehaviour
	{
		public Card card;
		public CardVisualProperties[] properties;
		public GameObject statHolder;

		private void Start()
		{
			LoadCard(card);
		}
		public void LoadCard(Card c)
		{
			if(c == null)
			{
				return;
			}
			card = c;
			for (int i = 0; i < c.properties.Length; i++)
			{
				CardProperties cp = c.properties[i];
				CardVisualProperties p = GetProperties(cp.element);
				if(p == null)
				{
					continue;
				}
				if(cp.element is ElementInt)
				{
					p.text.text = cp.intValue.ToString();
				}
				if(cp.element is ElementImage)
				{
					p.img.sprite = cp.sprite;
				}
				if(cp.element is ElementText)
				{
					p.text.text = cp.stringValue;
				}
			}
		}
		public CardVisualProperties GetProperties(Element e)
		{
			CardVisualProperties result = null;
			for (int i = 0; i < properties.Length; i++)
			{
				if(properties[i].element == e)
				{
					result = properties[i];
					break;
				}
				
			}
			return result;
		}
	} 
}
