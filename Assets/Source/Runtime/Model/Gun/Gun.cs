using System;
using UnityEngine;
using Cysharp.Threading.Tasks;
using UnityEngine.EventSystems;
using Tanks.View.Gun;
using Tanks.Factories;

namespace Tanks.Model.Gun
{
	public class Gun : IGun
	{
		public bool CanShoot => _magazine.CanTakeBullet();

		private readonly IBulletFactory _bulletFactory;
		private readonly IBulletMagazine _magazine;
		private readonly IGunView _view;

		public Gun(IGunView view, IBulletMagazine magazine, IBulletFactory bulletFactory)
		{
			_bulletFactory = bulletFactory ?? throw new ArgumentNullException(nameof(bulletFactory));
			_magazine = magazine ?? throw new ArgumentNullException(nameof(magazine));
			_view = view ?? throw new ArgumentNullException(nameof(view));
		}

		public void Shoot(Vector2 direction)
		{
			if (!CanShoot)
				throw new InvalidOperationException();

			if (_magazine.CanTakeBullet())
			{
				_magazine.TakeBullet();
				_bulletFactory.Create().Throw(direction);
				_view.Visualize();
			}
		}

		public void Reload()
		{
			_magazine.Fill();
		}
	}
}
