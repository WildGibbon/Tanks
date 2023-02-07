namespace Tanks.Factories
{
	public interface IFactory<T>
	{
		T Create();
	}
}
