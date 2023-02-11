using Tanks.Model.Gun;

namespace Tanks.Factories
{
	public interface IGunFactory
	{
		IGun Create();
	}
}
