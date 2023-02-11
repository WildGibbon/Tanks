using System;
using Tanks.View.Movement;
using UnityEngine;

namespace Tanks.Model.Movement
{
	public class Rotation : IRotation
	{
		private readonly float _speed;
		private readonly IRotationView _view;

		public Quaternion CurrentRotation { get; private set; }

		public Rotation(IRotationView view, float speed, Quaternion rotation)
		{
			if(speed <= 0) 
				throw new ArgumentOutOfRangeException(nameof(speed));

			_view = view ?? throw new ArgumentNullException(nameof(view));
			CurrentRotation = rotation;
			_speed = speed;
		}

		public void RotateTo(RotationDirection direction, float deltaTime)
		{
			var nextRotationZ = CurrentRotation.eulerAngles.z + (int)direction * _speed * deltaTime;
			CurrentRotation = Quaternion.Euler(CurrentRotation.x, CurrentRotation.y, nextRotationZ);
			_view.Visualize(CurrentRotation);
		}
	}
}
