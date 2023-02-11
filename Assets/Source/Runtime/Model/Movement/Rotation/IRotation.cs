using Tanks.Tools.SystemUpdates;
using UnityEngine;

namespace Tanks.Model.Movement
{
	public interface IRotation
	{
		Quaternion CurrentRotation { get; }
		void RotateTo(RotationDirection direction, float deltaTime);
	}
}
