using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Tanks.View.Movement
{
	public interface IRotationView
	{
		void Visualize(Quaternion rotation);
	}
}
