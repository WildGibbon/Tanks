using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Tanks.View.Gun
{
	public interface IBulletView
	{
		void Visualize(Vector2 direction, Quaternion rotation);
	}
}
