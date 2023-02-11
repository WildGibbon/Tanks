using Sirenix.OdinInspector;
using Tanks.Model.Health;
using Tanks.Model.Input;
using Tanks.Model.Player;
using Tanks.UI;
using Tanks.UI.Buttons;
using UnityEngine;

namespace Tanks.Factories
{
	public class PlayerFactory : SerializedMonoBehaviour, IPlayerFactory
	{
		[SerializeField] private IDirectionalMovementFactory _directionalMovementFactory;
		[SerializeField] private IRotationFactory _rotationFactory;
		[SerializeField] private IButtonFactory _shootButtonFactory;
		[SerializeField] private IHealthFactory _healthFactory;
		[SerializeField] private IMovementInput _input;

		private Player _player;

		public Player Create()
		{
			_shootButtonFactory.Create();
			_healthFactory.Create();

			_player = new Player(_input, _directionalMovementFactory.Create(), _rotationFactory.Create());
			return _player;
		}
	}
}
