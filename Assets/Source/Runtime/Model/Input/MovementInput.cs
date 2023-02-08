using Sirenix.OdinInspector;
using System;
using Tanks.Model.UI;
using UnityEngine;

namespace Tanks.Model.Input
{
	public class MovementInput : SerializedMonoBehaviour, IMovementInput
	{
		[SerializeField] private IHoldUIElement _leftButton;
		[SerializeField] private IHoldUIElement _rightButton;

		public bool IsLeftButtonHold => _leftButton.IsHold;

		public bool IsRightButtonHold => _rightButton.IsHold;
	}
}
