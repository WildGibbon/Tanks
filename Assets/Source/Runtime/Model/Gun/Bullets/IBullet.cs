using Tanks.Model.Health;
using UnityEngine;

namespace Tanks.Model.Gun
{
	public interface IBullet
	{
		void Throw(Vector2 direction);
		void Attack(IHealth health);
	}
}
