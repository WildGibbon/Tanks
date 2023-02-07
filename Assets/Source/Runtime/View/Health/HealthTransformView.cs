using Tanks.Model.Health;
using System;
using UnityEngine;

namespace Tanks.View.Health
{
	public class HealthTransformView : MonoBehaviour, IHealthTransformView
	{
		public IHealth Health { get; private set; }
		
		public void Init(IHealth health)
		{
			Health = health ?? throw new ArgumentNullException("Health can not be null");
		}
	}
}
