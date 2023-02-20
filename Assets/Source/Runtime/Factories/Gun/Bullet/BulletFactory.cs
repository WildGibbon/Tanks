using Tanks.Model.Gun;
using Tanks.View.Gun;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tanks.Factories
{
	public class BulletFactory : SerializedMonoBehaviour, IBulletFactory
	{
		[SerializeField] private GameObject _bulletPrefab;
		[SerializeField] private int _bulletDamage;
		[SerializeField] private float _bulletThrowForce;
		[SerializeField] private Transform _spawnPoint;

		public IBullet Create()
		{
			var bulletObject = Instantiate(_bulletPrefab, _spawnPoint.position, Quaternion.identity);
			var bulletView = bulletObject.GetComponent<BulletView>();
			var bullet = new DefaultBullet(bulletView, _bulletThrowForce, _bulletDamage);

			var bulletTransformView = bulletObject.GetComponent<BulletTransformView>();
			bulletTransformView.Init(bullet);

			return bullet;
		}
	}
}
