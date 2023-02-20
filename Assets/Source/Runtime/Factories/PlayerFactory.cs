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
		[SerializeField] private IShootButtonFactory _shootButtonFactory;
		[SerializeField] private IRotationFactory _rotationFactory;
		[SerializeField] private IHealthFactory _healthFactory;
		[SerializeField] private IGunFactory _gunFactory; 
		[SerializeField] private IMovementInput _input;

		private Player _player;

		public Player Create()
		{
			var directionalMovement = _directionalMovementFactory.Create();
			var rotation = _rotationFactory.Create();
			var gun = _gunFactory.Create();

			_shootButtonFactory.Create(gun);
			_healthFactory.Create();

			_player = new Player(_input, directionalMovement, rotation, gun);
			return _player;
		}
	}
}
