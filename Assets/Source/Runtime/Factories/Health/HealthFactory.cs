using Sirenix.OdinInspector;
using Tanks.Model.Health;
using Tanks.View.Health;
using UnityEngine;

namespace Tanks.Factories
{
	public class HealthFactory : SerializedMonoBehaviour, IHealthFactory
	{
		[SerializeField] private IHealthTransformView _healthTransformView;
		[SerializeField] private IHealthView _healthView;
		[SerializeField] private int _healthValue;

		public IHealth Create()
		{
			var health = new Health(_healthView, _healthValue);
			_healthTransformView.Init(health);

			return health;
		}
	}
}
