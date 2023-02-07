using Tanks.View.Health;
using Tanks.Model.Gun;
using UnityEngine;
using System;

namespace Tanks.View.Gun
{
	public class BulletTransformView : MonoBehaviour
	{
		private IBullet _bullet;

		public void Init(IBullet bullet)
		{
			_bullet = bullet ?? throw new ArgumentNullException(nameof(bullet));
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			if(collision.TryGetComponent<IHealthTransformView>(out var healthTransformView))
			{
				_bullet.Attack(healthTransformView.Health);
			}
		}
	}
}
