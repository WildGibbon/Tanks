using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Tanks.Model.UI
{
	internal class HoldUIElement : MonoBehaviour, IHoldUIElement, IPointerDownHandler, IPointerUpHandler
	{
		public bool IsHold { get; private set; }

		public void OnPointerDown(PointerEventData eventData)
		{
			IsHold = true;
		}

		public void OnPointerUp(PointerEventData eventData)
		{
			IsHold = false;
		}
	}
}
