using Sirenix.OdinInspector;
using Tanks.Model.Gun;
using Tanks.UI;
using Tanks.UI.Buttons;
using UnityEngine;

namespace Tanks.Factories.Gun
{
	public class ShootButtonFactory : SerializedMonoBehaviour, IButtonFactory
	{
		[SerializeField] private IGunFactory _gunFactory;
		[SerializeField] private Transform _shootPoint;
		[SerializeField] private UnityButton _shootButton;

		public IButton Create()
		{
			var shootButton = new ShootButton(_gunFactory.Create(), _shootPoint);
			_shootButton.Init(shootButton);

			return shootButton;
		}
	}
}
