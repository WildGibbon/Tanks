using UnityEngine;

namespace Tanks.View.Movement
{
	public class RotationView : MonoBehaviour, IRotationView
	{
		public void Visualize(Quaternion rotation)
		{
			transform.rotation = rotation;
		}
	}
}
