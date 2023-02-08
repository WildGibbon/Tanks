using System;
using UnityEngine;
using UnityEngine.UI;

namespace Tanks.UI
{
	public class UnityButton : MonoBehaviour
	{
		private Button _unityButton;
		private IButton _button;

		public void Init(IButton button)
		{
			_button = button ?? throw new ArgumentNullException(nameof(button));

			_unityButton = GetComponent<Button>();
			_unityButton.onClick.AddListener(_button.Press);
		}
	}
}
