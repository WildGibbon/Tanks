using Tanks.Model.Gun;
using Tanks.View.Gun;
using UnityEngine;
using Sirenix.OdinInspector;
using Tanks.Model.Attack;

namespace Tanks.Factories
{
	public class BulletFactory : SerializedMonoBehaviour, IBulletFactory
	{
		[SerializeField] private GameObject _bulletPrefab;
		[SerializeField] private int _damage;
		[SerializeField] private float _throwForce;
		[SerializeField] private Transform _spawnPoint;

		public IBullet Create()
		{
			var bulletObject = Instantiate(_bulletPrefab, _spawnPoint.position, Quaternion.identity);

			var bulletView = bulletObject.GetComponent<BulletView>();
			var physicalAttack = bulletObject.GetComponent<PhysicalAttack>();
			physicalAttack.Init(new DefaultAttack(_damage));
			
			var bullet = new DefaultBullet(bulletView, _throwForce);


			return bullet;
		}
	}
}
