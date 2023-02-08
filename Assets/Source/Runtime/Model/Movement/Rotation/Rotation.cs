using System;
using UnityEngine;

namespace Tanks.Model.Movement
{
	public class Rotation : IRotation
	{
		private readonly float _speed;

		private Quaternion _currentValue;
		private RotationMode _mode;

		public Rotation(float speed, Quaternion value)
		{
			if(speed <= 0) 
				throw new ArgumentOutOfRangeException(nameof(speed));

			_mode = RotationMode.None;
			_currentValue = value;
			_speed = speed;
		}

		public void SetRotationMode(RotationMode mode)
		{
			_mode = mode;
		}

		public void Update(float deltaTime)
		{
			var nextRotationZ = _currentValue.z + _speed * ((int)_mode) * deltaTime;
			_currentValue = Quaternion.Euler(0, 0, nextRotationZ);
		}
	}
}
