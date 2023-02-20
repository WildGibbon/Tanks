using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Factories;
using Tanks.View;

namespace Tanks.Model.Gun.Magazine
{
	public class BulletMagazine : IBulletMagazine
	{
		private readonly IBulletMagazineView _view;
		private readonly int _capacity;

		private int _currentBulletsCount;

		public BulletMagazine(IBulletMagazineView view, IBulletFactory factory, int capacity)
		{
			if(capacity <= 0)
				throw new ArgumentOutOfRangeException(nameof(capacity));

			_view = view ?? throw new ArgumentNullException(nameof(view));
			_capacity = _currentBulletsCount = capacity;
		}

		public void TakeBullet()
		{
			if(!CanTakeBullet())
				throw new InvalidOperationException();

			_currentBulletsCount--;
			_view.Visualize(_currentBulletsCount, _capacity);
		}

		public bool CanTakeBullet()
		{
			return _currentBulletsCount - 1 >= 0;
		}

		public void Fill()
		{
			_currentBulletsCount = _capacity;
			_view.Visualize(_currentBulletsCount, _capacity);
		}
	}
}
