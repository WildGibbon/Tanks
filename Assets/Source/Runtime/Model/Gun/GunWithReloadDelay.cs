using Cysharp.Threading.Tasks;
using System;
using UnityEngine;

namespace Tanks.Model.Gun
{
	public class GunWithReloadDelay : IGun
	{
		public bool CanShoot => _gun.CanShoot && !_isReloading;

		private readonly float _reloadDelay;
		private readonly IGun _gun;

		private bool _isReloading;

		public GunWithReloadDelay(float reloadDelay, IGun gun)
		{
			if(reloadDelay < 0)
				throw new ArgumentOutOfRangeException(nameof(reloadDelay));

			_gun = gun ?? throw new ArgumentNullException(nameof(gun));
			_reloadDelay = reloadDelay;
		}

		public void Shoot(Vector2 direction)
		{
			if (!CanShoot)
				throw new InvalidOperationException();

			_gun.Shoot(direction);
		}

		public async void Reload()
		{
			if (!_isReloading)
			{   
				_isReloading = true;
				await UniTask.Delay(TimeSpan.FromSeconds(_reloadDelay));
				_gun.Reload();
				_isReloading = false;
			}
   		}
	}
}
