using System;
using System.Collections.Generic;
using Tanks.Factories;
using Tanks.Model.Player;
using Tanks.Tools.SystemUpdates;

namespace Tanks.Game
{
	public class Game : IGame
	{
		private readonly ISystemUpdate _systemUpdate;
		private readonly IGameData _data;

		public Game(IGameData GameData)
		{
			_data = GameData ?? throw new ArgumentNullException(nameof(GameData));
			_systemUpdate = new SystemUpdate();
		}

		public void Play()
		{
			_systemUpdate.Add(_data.PlayerFactory.Create());
		}

		public void Update(float deltaTime)
		{
			_systemUpdate.UpdateAll(deltaTime);
		}
	}
}
