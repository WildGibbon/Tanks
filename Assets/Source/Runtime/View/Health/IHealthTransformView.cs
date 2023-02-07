using Tanks.Model.Health;

namespace Tanks.View.Health
{
	public interface IHealthTransformView
	{
		IHealth Health { get; }

		void Init(IHealth health);
	}
}