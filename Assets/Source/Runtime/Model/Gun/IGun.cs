using UnityEngine;

namespace Tanks.Model.Gun
{
	public interface IGun
	{
		void Shoot(Vector2 direction);
		bool CanShoot { get; }
	}
}
