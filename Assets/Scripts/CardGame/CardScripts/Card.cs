using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HearthStone2
{
	[CreateAssetMenu(menuName = "Card", fileName = "New Card")]
	public class Card : ScriptableObject
	{
		public CardType cardType;
		public CardProperties[] properties;
	} 
}
