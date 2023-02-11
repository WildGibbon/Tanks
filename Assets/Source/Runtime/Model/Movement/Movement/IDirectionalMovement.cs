using Tanks.Tools.SystemUpdates;
using UnityEngine;

namespace Tanks.Model.Movement
{
	public interface IDirectionalMovement
	{
		void Move(Vector2 direction);
	}
}
