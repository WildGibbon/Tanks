using System;
using Tanks.Factories;

namespace Tanks.Game
{
	public class GameData : IGameData
	{
		public IPlayerFactory PlayerFactory { get; }
	
		public GameData(IPlayerFactory playerFactory)
		{
			PlayerFactory = playerFactory ?? throw new ArgumentNullException(nameof(playerFactory));
		}
	}
}
