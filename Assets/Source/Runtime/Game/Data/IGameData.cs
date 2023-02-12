using Tanks.Factories;

namespace Tanks.Game
{
	public interface IGameData
	{
		IPlayerFactory PlayerFactory { get; }
	}
}
