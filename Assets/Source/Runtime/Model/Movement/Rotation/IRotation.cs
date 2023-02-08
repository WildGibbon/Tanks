using Tanks.Tools.SystemUpdates;

namespace Tanks.Model.Movement
{
	public interface IRotation : IUpdatable
	{
		void SetRotationMode(RotationMode mode);
	}
}
