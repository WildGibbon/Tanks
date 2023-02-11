using Sirenix.OdinInspector;
using Tanks.Model.Gun;
using Tanks.Model.Gun.Magazine;
using Tanks.View;
using UnityEngine;

namespace Tanks.Factories.Gun
{
	public class GunFactory : SerializedMonoBehaviour, IGunFactory
	{
		[SerializeField] private IBulletFactory _bulletFactory;
		[SerializeField] private IBulletMagazineView _magazineView;
		[SerializeField] private int _magazineCapacity;
		[SerializeField] private float _shootDelay;
		[SerializeField] private float _reloadDelay;

		private IBulletMagazine _magazine;
		private IGun _gun;

		public IGun Create()
		{
			_magazine = new BulletMagazine(_magazineView, _bulletFactory, _magazineCapacity);
			_gun = new DefaultGun(_magazine, _reloadDelay, _shootDelay);

			return _gun;
		}
	}
}
