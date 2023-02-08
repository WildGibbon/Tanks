using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Model.Gun;

namespace Tanks.UI.Buttons
{
	public class ShootButton : IButton
	{
		private readonly IGun _gun;
		private readonly Transform _shootingPoint;

		public ShootButton(IGun gun, Transform shootingPoint)
		{
			_shootingPoint = shootingPoint ?? throw new ArgumentNullException(nameof(shootingPoint));
			_gun = gun ?? throw new ArgumentNullException(nameof(gun));
		}

		public void Press()
		{
			var shootDirection = _shootingPoint.position + _shootingPoint.forward;
			_gun.Shoot(shootDirection);
		}
	}
}
