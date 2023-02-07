using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Model.Gun;
using Tanks.Model.Health;
using Tanks.View.Gun;
using UnityEngine;

namespace Tanks.Model.Gun
{
	public class DefaultBullet : IBullet
	{
		private readonly IBulletView _view;
		private readonly int _damage;
		private readonly float _throwForce;

		public DefaultBullet(IBulletView view, float throwForce, int damage)
		{
			if(damage <= 0)
				throw new ArgumentOutOfRangeException(nameof(damage));
			if(throwForce <= 0)
				throw new ArgumentOutOfRangeException(nameof(throwForce));

			_damage = damage;
			_throwForce = throwForce;
			_view = view ?? throw new ArgumentNullException(nameof(view));
		}

		public void Throw(Vector2 direction)
		{
			var rotation = Quaternion.LookRotation(Vector2.up, direction);
			_view.Visualize(direction.normalized * _throwForce, rotation);
		}

		public void Attack(IHealth health)
		{
			health.TakeDamage(_damage);
		}
	}
}
