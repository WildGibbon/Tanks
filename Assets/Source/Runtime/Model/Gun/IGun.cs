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
