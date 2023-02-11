using Sirenix.OdinInspector;
using System;
using Tanks.Model.Movement;
using Tanks.View.Movement;
using UnityEngine;

namespace Tanks.Factories
{
	public class DirectionalMovementFactory : SerializedMonoBehaviour, IDirectionalMovementFactory
	{
		[SerializeField] private IMovementView _movementView;
		[SerializeField] private float _moveSpeed;

		public IDirectionalMovement Create()
		{
			return new DirectionalMovement(_movementView, _moveSpeed);
		}
	}
}
