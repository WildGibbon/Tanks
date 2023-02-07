using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Tanks.Model.Gun
{
	public interface IGun
	{
		void Shoot(Vector2 direction);
		void Reload();
		bool CanShoot { get; }
	}
}
