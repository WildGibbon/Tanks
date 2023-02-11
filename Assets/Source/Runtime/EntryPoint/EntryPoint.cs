using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Factories;
using Tanks.Game;
using UnityEngine;

namespace Tanks.EntryPoint
{
	public class EntryPoint : SerializedMonoBehaviour
	{
		[SerializeField] private List<IPlayerFactory> _playerFactories;

		private IGame _game;

		private void Awake()
		{
			_game = new Game.Game(_playerFactories);
			_game.Play();
		}

		private void Update()
		{
			_game.Update(Time.deltaTime);
		}
	}
}
