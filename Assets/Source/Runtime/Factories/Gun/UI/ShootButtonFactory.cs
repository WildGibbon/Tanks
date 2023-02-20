using Sirenix.OdinInspector;
using Tanks.Model.Gun;
using Tanks.UI;
using Tanks.UI.Buttons;
using UnityEngine;

namespace Tanks.Factories.Gun
{
	public class ShootButtonFactory : SerializedMonoBehaviour, IShootButtonFactory
	{
		[SerializeField] private Transform _shootPoint;
		[SerializeField] private UnityButton _shootButton;

		public IButton Create(IGun gun)
		{
			var shootButton = new ShootButton(gun, _shootPoint);
			_shootButton.Init(shootButton);

			return shootButton;
		}
	}
}
