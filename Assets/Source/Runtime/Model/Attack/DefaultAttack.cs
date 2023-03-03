using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Model.Health;

namespace Tanks.Model.Attack
{
	public class DefaultAttack : IAttack
	{
		private readonly int _damage;

		public DefaultAttack(int damage)
		{
			if(damage <= 0) 
				throw new ArgumentOutOfRangeException(nameof(damage));

			_damage = damage;
		}

		public void Attack(IHealth health)
		{
			health.TakeDamage(_damage);
		}
	}
}
