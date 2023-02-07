using Tanks.Model.Gun;
using Tanks.View.Gun;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tanks.Factories
{
	public class BulletFactory : SerializedMonoBehaviour, IFactory<IBullet>
	{
		[SerializeField] private BulletTransformView _spawningBullet;
		[SerializeField] private IBulletView _bulletView;
		[SerializeField] private int _bulletDamage;
		[SerializeField] private float _bulletThrowForce;
		[SerializeField] private Transform _spawnPoint;

		public IBullet Create()
		{
			var bulletTransformView = Instantiate(_spawningBullet, _spawnPoint.position, Quaternion.identity);

			var bullet = new DefaultBullet(_bulletView, _bulletThrowForce, _bulletDamage);
			bulletTransformView.Init(bullet);

			return bullet;
		}
	}
}
