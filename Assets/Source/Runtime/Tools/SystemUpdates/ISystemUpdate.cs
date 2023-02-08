namespace Tanks.Tools.SystemUpdates
{
	public interface ISystemUpdate
	{
		void Add(params IUpdatable[] updatables);
		void UpdateAll(float deltaTime);
	}
}
