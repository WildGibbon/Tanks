using Tanks.Model.Gun;
using Tanks.View.Gun;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tanks.Factories
{
	public class BulletFactory : SerializedMonoBehaviour, IBulletFactory
	{
		[SerializeField] private GameObject _bulletPrefab;
		[SerializeField] private ParticleSystem _shootParticle;
		[SerializeField] private int _bulletDamage;
		[SerializeField] private float _bulletThrowForce;
		[SerializeField] private Transform _spawnPoint;

		private BulletTransformView _bulletTransformView;

		public IBullet Create()
		{
			var bulletObject = Instantiate(_bulletPrefab, _spawnPoint.position, Quaternion.identity);
			var bulletView = bulletObject.GetComponent<BulletView>();
			var bullet = new DefaultBullet(bulletView, _bulletThrowForce, _bulletDamage);

			_bulletTransformView = bulletObject.GetComponent<BulletTransformView>();
			_bulletTransformView.Init(bullet);

			_shootParticle.Stop();
			_shootParticle.Play();

			return bullet;
		}
	}
}
