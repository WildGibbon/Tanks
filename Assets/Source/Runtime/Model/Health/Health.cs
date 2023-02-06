using System;
using UnityEngine;

namespace Runner.Model.Health
{
	public class Health : IHealth
	{
		public int Value { get; private set; }
		public int MaxValue { get; private set; }
		public bool IsDead => Value <= 0;

		public Health(int value, int maxValue)
		{
			if (value <= 0)
				throw new ArgumentOutOfRangeException("Health value can not be less than 0");

			MaxValue = maxValue;
			Value = maxValue;
		}

		public void TakeDamage(int value)
		{
			if (IsDead)
				throw new InvalidOperationException("Can not take damage to dead health");

			if (value < 0)
				throw new ArgumentOutOfRangeException("Damage can not be less than 0");

			Value -= value;
			Debug.Log("Damaged");
		}

		public void Heal(int count)
		{
			if (count < 0)
				throw new ArgumentOutOfRangeException("Heal value can not be less than 0");

			if (IsDead)
				throw new InvalidOperationException("Can not heal dead health");

			if (Value + count > MaxValue)
			{
				Value = MaxValue;
				return;
			}

			Value += count;
			Debug.Log("Heal");
		}

		public bool CanHeal(int count)
		{
			return Value + count <= MaxValue; 
		}
	}
}
