using Tanks.Model.Health;

namespace Tanks.Model.Attack
{
	public interface IAttack
	{
		void Attack(IHealth health);
	}
}
