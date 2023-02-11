using UnityEngine;

namespace Tanks.View.Movement
{
	public interface IMovementView
	{
		void Visualize(Vector2 velocity);
	}
}
