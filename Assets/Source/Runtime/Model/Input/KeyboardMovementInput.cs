using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Tanks.Model.Input
{
	public class KeyboardMovementInput : MonoBehaviour, IMovementInput
	{
		[SerializeField] private KeyCode _leftButton;
		[SerializeField] private KeyCode _rightButton;

		public bool IsLeftButtonHold => UnityEngine.Input.GetKey(_leftButton);

		public bool IsRightButtonHold => UnityEngine.Input.GetKey(_rightButton);
	}
}
