﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Factories;
using Tanks.View;

namespace Tanks.Model.Gun.Magazine
{
	public class BulletMagazine : IBulletMagazine
	{
		private readonly IFactory<IBullet> _factory;
		private readonly int _capacity;
		private readonly ITextView _view;

		private int _currentBulletsCount;

		public BulletMagazine(ITextView view, IFactory<IBullet> factory, int capacity)
		{
			if(capacity <= 0)
				throw new ArgumentOutOfRangeException(nameof(capacity));

			_factory = factory ?? throw new ArgumentNullException(nameof(factory));
			_view = view ?? throw new ArgumentNullException(nameof(view));
			_capacity = _currentBulletsCount = capacity;
		}

		public IBullet TakeBullet()
		{
			if(!CanTakeBullet())
				throw new InvalidOperationException();

			_currentBulletsCount--;

			return _factory.Create();
		}

		public bool CanTakeBullet()
		{
			return _currentBulletsCount - 1 >= 0;
		}

		public void Fill()
		{
			_currentBulletsCount = _capacity;
		}
	}
}