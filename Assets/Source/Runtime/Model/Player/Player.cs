using System;
using Tanks.Model.Gun;
using Tanks.Model.Input;
using Tanks.Model.Movement;
using Tanks.Tools.SystemUpdates;

namespace Tanks.Model.Player
{
	public class Player : IUpdatable
	{
		private readonly IMovementInput _movementInput;
		private readonly IDirectionalMovement _movement;
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
				_rotation.SetRotationMode(RotationMode.Left);     

			if (_movementInput.IsRightButtonHold)
				_rotation.SetRotationMode(RotationMode.Right);

			if(_movementInput.IsLeftButtonHold && _movementInput.IsRightButtonHold)
			{

			}
		}
	}
}
