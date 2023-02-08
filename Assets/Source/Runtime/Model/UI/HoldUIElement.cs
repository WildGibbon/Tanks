using System;
using UnityEngine.EventSystems;

namespace Tanks.Model.UI
{
	internal class HoldUIElement : IHoldUIElement, IPointerDownHandler, IPointerUpHandler
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
