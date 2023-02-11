using System;
using Tanks.Model.Input;
using Tanks.Model.Movement;
using Tanks.Tools.SystemUpdates;
using UnityEngine;

namespace Tanks.Model.Player
{
	public class Player : IUpdatable
	{
		private readonly IDirectionalMovement _movement;
		private readonly IMovementInput _movementInput;
		private readonly IRotation _rotation;

		public Player(IMovementInput movementInput, IDirectionalMovement movement, IRotation rotation)
		{
			_movementInput = movementInput ?? throw new ArgumentNullException(nameof(movementInput));
			_movement = movement ?? throw new ArgumentNullException(nameof(movement));
			_rotation = rotation ?? throw new ArgumentNullException(nameof(rotation));
		}

		public void Update(float deltaTime)
		{
			if (_movementInput.IsLeftButtonHold)
				_rotation.RotateTo(RotationDirection.Left, deltaTime); 

			if (_movementInput.IsRightButtonHold)
				_rotation.RotateTo(RotationDirection.Right, deltaTime);

			if(_movementInput.IsLeftButtonHold && _movementInput.IsRightButtonHold)
			{
				var directionX = Mathf.Cos(_rotation.CurrentRotation.eulerAngles.z * Mathf.Deg2Rad);
				var directionY = Mathf.Sin(_rotation.CurrentRotation.eulerAngles.z * Mathf.Deg2Rad);
				var direction = new Vector2(directionX, directionY);

				_movement.Move(direction);
			}
			else
			{
				_movement.Move(Vector2.zero);
			}
		}
	}
}
