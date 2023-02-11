using System;
using Tanks.View.Movement;
using UnityEngine;

namespace Tanks.Model.Movement
{
	public class DirectionalMovement : IDirectionalMovement
	{
		private readonly IMovementView _view;
		private readonly float _speed;

		public DirectionalMovement(IMovementView view, float speed)
		{
			if(speed <= 0)
				throw new ArgumentOutOfRangeException(nameof(speed));

			_speed = speed;
			_view = view;
		}

		public void Move(Vector2 direction)
		{
			_view.Visualize(direction * _speed);
		}
	}
}
