using System;
using System.Collections.Generic;
using Tanks.Factories;
using Tanks.Model.Player;
using Tanks.Tools.SystemUpdates;

namespace Tanks.Game
{
	public class Game : IGame
	{
		private readonly List<IPlayerFactory> _playerFactories;
		private readonly ISystemUpdate _systemUpdate;

		public Game(List<IPlayerFactory> playerFactories)
		{
			_playerFactories = playerFactories ?? throw new ArgumentNullException(nameof(playerFactories));
			_systemUpdate = new SystemUpdate();
		}

		public void Play()
		{
			foreach(var playerFactory in _playerFactories)
				_systemUpdate.Add(playerFactory.Create());
		}

		public void Update(float deltaTime)
		{
			_systemUpdate.UpdateAll(deltaTime);
		}
	}
}
