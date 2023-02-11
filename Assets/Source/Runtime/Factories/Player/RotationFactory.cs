using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Model.Movement;
using Tanks.View.Movement;
using UnityEngine;

namespace Tanks.Factories
{
	public class RotationFactory : SerializedMonoBehaviour, IRotationFactory
	{
		[SerializeField] private IRotationView _view;
		[SerializeField] private float _rotationSpeed;

		public IRotation Create()
		{
			return new Rotation(_view, _rotationSpeed, Quaternion.identity);
		}
	}
}
