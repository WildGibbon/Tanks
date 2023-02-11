﻿using Tanks.View.Health;
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

		private void OnCollisionEnter2D(Collision2D collision)
		{
			if(collision.transform.TryGetComponent<IHealthTransformView>(out var healthTransformView))
			{
				_bullet.Attack(healthTransformView.Health);
			}
			Destroy(gameObject);
		}
	}
}
