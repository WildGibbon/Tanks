using System;
using UnityEngine;
using UnityEngine.UI;

namespace Tanks.View.Health
{
	public class SliderHealthView : MonoBehaviour, IHealthView
	{
		[SerializeField] private Slider _slider;

		public void Visualize(int value, int maxValue)
		{
			_slider.maxValue = maxValue;
			_slider.value = value;
		}
	}
}
