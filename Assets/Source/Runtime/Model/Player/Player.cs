using System;
using Tanks.Model.Gun;
using Tanks.Model.Input;
using Tanks.Model.Movement;
using Tanks.Game.SystemUpdates;
using UnityEngine;

namespace Tanks.Model.Player
{
	public class Player : IUpdatable
	{
		private readonly IDirectionalMovement _movement;
		private readonly IMovementInput _movementInput;
		private readonly IRotation _rotation;
		private readonly IGun _gun;

		public Player(IMovementInput movementInput, IDirectionalMovement movement, IRotation rotation, IGun gun)
		{
			_movementInput = movementInput ?? throw new ArgumentNullException(nameof(movementInput));
			_movement = movement ?? throw new ArgumentNullException(nameof(movement));
			_rotation = rotation ?? throw new ArgumentNullException(nameof(rotation));
			_gun = gun ?? throw new ArgumentNullException(nameof(gun));
		}

		public void Update(float deltaTime)
		{
			if (_movementInput.IsLeftButtonHold)
				_rotation.RotateTo(RotationDirection.Left, deltaTime); 

			if (_movementInput.IsRightButtonHold)
				_rotation.RotateTo(RotationDirection.Right, deltaTime);

			if(!_gun.CanShoot)
				_gun.Reload();

			if(_movementInput.IsLeftButtonHold && _movementInput.IsRightButtonHold)
			{
				var rotationAngleZ = _rotation.CurrentRotation.eulerAngles.z * Mathf.Deg2Rad;
				var directionX = Mathf.Cos(rotationAngleZ);
				var directionY = Mathf.Sin(rotationAngleZ);
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
