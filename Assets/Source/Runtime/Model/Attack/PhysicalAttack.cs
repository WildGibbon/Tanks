using System;
using Tanks.Model.Health;
using UnityEngine;

namespace Tanks.Model.Attack
{
	public class PhysicalAttack : MonoBehaviour, IAttack
	{
		private IAttack _attack;

		public void Init(IAttack attack)
		{
			_attack = attack ?? throw new ArgumentNullException(nameof(attack));
		}

		public void Attack(IHealth health)
		{
			_attack.Attack(health);
			Destroy(gameObject);
		}
	}
}
