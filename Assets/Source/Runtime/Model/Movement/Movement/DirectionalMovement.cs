using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Tanks.Model.Movement
{
	public class DirectionalMovement : IDirectionalMovement
	{
		private readonly float _speed;

		private Vector2 _position;
		private Vector2 _direction;

		public DirectionalMovement(float speed, Vector2 position)
		{
			if(speed <= 0)
				throw new ArgumentOutOfRangeException(nameof(speed));

			_position = position;
			_speed = speed;
		}

		public void Move(Vector2 direction)
		{
			_direction = direction.normalized;
		}

		public void Update(float deltaTime)
		{
			_position += _direction * _speed * deltaTime;
		}
	}
}
