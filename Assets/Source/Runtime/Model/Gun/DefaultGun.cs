using System;
using UnityEngine;
using Cysharp.Threading.Tasks;
using UnityEngine.EventSystems;

namespace Tanks.Model.Gun
{
	public class DefaultGun : IGun, IPointerDownHandler
	{
		private readonly IBulletMagazine _magazine;
		private readonly float _shootDelay;
		private readonly float _reloadDelay;
		
		public bool CanShoot { get; private set; }

		public DefaultGun(IBulletMagazine magazine, float reloadDelay, float shootDelay)
		{
			if(shootDelay < 0)
				throw new ArgumentOutOfRangeException(nameof(shootDelay));
			if(reloadDelay < 0) 
				throw new ArgumentOutOfRangeException(nameof(reloadDelay));

			_magazine = magazine ?? throw new ArgumentNullException(nameof(magazine));
			_reloadDelay = reloadDelay;
			_shootDelay = shootDelay;
			CanShoot = true;
		}

		public void Shoot(Vector2 direction)
		{
			if (!CanShoot)
				throw new InvalidOperationException();

			if (_magazine.CanTakeBullet())
			{
				_magazine.TakeBullet().Throw(direction);
				StartRollback();
			}

			if (!_magazine.CanTakeBullet())
				CanShoot = false;
		}

		public async void Reload()
		{
			await UniTask.Delay(TimeSpan.FromSeconds(_reloadDelay));
			_magazine.Fill();
			CanShoot = true;
		}
		
		private async void StartRollback()
		{
			CanShoot = false;
			await UniTask.Delay(TimeSpan.FromSeconds(_shootDelay));
			CanShoot = true;		
		}

		public void OnPointerDown(PointerEventData eventData)
		{
			
		}
	}
}
