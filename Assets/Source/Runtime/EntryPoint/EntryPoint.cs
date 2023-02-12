using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Factories;
using Tanks.Game;
using Tanks.Tools.SystemUpdates;
using UnityEngine;

namespace Tanks.EntryPoint
{
	public class EntryPoint : SerializedMonoBehaviour
	{
		[SerializeField] private List<IPlayerFactory> _playerFactories;

		private ISystemUpdate _systemUpdate;

		private void Awake()
		{
			_systemUpdate = new SystemUpdate();

			foreach(var playerFactory in _playerFactories)
			{
				var gameData = new GameData(playerFactory);
				var game = new Game.Game(gameData);
				game.Play();

				_systemUpdate.Add(game);
			}
		}

		private void Update()
		{
			_systemUpdate.UpdateAll(Time.deltaTime);
		}
	}
}
