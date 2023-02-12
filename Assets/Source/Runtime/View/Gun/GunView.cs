using UnityEngine;
using System;

namespace Tanks.View.Gun
{
	public class GunView : MonoBehaviour, IGunView
	{
		[SerializeField] private ParticleSystem _shootEffect;

		public void Visualize()
		{
			_shootEffect.Play();
		}
	}
}
