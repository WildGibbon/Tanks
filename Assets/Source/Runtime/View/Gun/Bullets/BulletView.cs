using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Tanks.View.Gun
{
	[RequireComponent(typeof(Rigidbody2D))]
	public class BulletView : MonoBehaviour, IBulletView
	{
		private Rigidbody2D _rigidbody;

		private void Awake()
		{
			_rigidbody = GetComponent<Rigidbody2D>();
		}

		public void Visualize(Vector2 direction, Quaternion rotation)
		{
			_rigidbody.AddForce(direction);
			gameObject.transform.rotation = rotation;
		}
	}
}
