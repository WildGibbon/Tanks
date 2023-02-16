using System;
using UnityEngine;
using Cysharp.Threading.Tasks; 

namespace Tanks.Model.Gun
{
	public class GunWithShootDelay : IGun
	{
		public bool CanShoot => _gun.CanShoot && !_isDelaying;
		
		private readonly float _delay;
		private readonly IGun _gun;

		private bool _isDelaying;

		public GunWithShootDelay(float delay, IGun gun)
		{
			if(delay <= 0)
				throw new ArgumentOutOfRangeException(nameof(delay));

			_gun = gun ?? throw new ArgumentNullException(nameof(gun));
			_isDelaying = false;
			_delay = delay;
		}

		public void Shoot(Vector2 direction)
		{
			if(!CanShoot) 
				throw new ArgumentNullException(nameof(CanShoot));

			_gun.Shoot(direction);
			StartDelay();
		}

		private async void StartDelay()
		{
			_isDelaying = true;
			await UniTask.Delay(TimeSpan.FromSeconds(_delay));
			_isDelaying = false;
		}
	}
}
