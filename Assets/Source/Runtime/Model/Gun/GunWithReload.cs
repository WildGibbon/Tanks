using Cysharp.Threading.Tasks;
using System;
using UnityEngine;

namespace Tanks.Model.Gun
{
	public class GunWithReload : IGun
	{
		public bool CanShoot => _gun.CanShoot && !_isReloading;

		private readonly float _reloadTime;
		private readonly IGun _gun;

		private bool _isReloading;

		public void Shoot(Vector2 direction)
		{
			_gun.Shoot(direction);
		}

		private async void StartReload()
		{
			_isReloading = true;
			await UniTask.Delay(TimeSpan.FromSeconds(_reloadTime));
			_isReloading = false;
		}
		//not finished
	}
}
