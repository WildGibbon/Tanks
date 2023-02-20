using Tanks.Model.Gun;
using Tanks.UI;

namespace Tanks.Factories
{
	public interface IShootButtonFactory
	{
		IButton Create(IGun gun);
	}
}
