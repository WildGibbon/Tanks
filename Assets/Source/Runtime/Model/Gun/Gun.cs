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
		private readonly IBulletFactory _bulletFactory;
		private readonly IBulletMagazine _magazine;
		private readonly IGunView _view;
		private readonly float _shootDelay;
		private readonly float _reloadDelay;
		
		public bool CanShoot { get; private set; }

		public Gun(IGunView view, IBulletMagazine magazine, float reloadDelay, float shootDelay)
		{
			if(shootDelay < 0)
				throw new ArgumentOutOfRangeException(nameof(shootDelay));
			if(reloadDelay < 0) 
				throw new ArgumentOutOfRangeException(nameof(reloadDelay));

			_magazine = magazine ?? throw new ArgumentNullException(nameof(magazine));
			_view = view ?? throw new ArgumentNullException(nameof(view)); 
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
				_bulletFactory.Create().Throw(direction);
				_magazine.TakeBullet();
				_view.Visualize();

				StartRollback();
			}
			if(!_magazine.CanTakeBullet())
			{
				Reload();
			}
		}

		public async void Reload()
		{
			CanShoot = false;
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
	}
}
