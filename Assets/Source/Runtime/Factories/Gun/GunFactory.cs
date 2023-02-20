using Tanks.Model.Gun;
using Tanks.View.Gun;
using Tanks.View;
using UnityEngine;
using Sirenix.OdinInspector;
using Tanks.Model.Gun.Magazine;

namespace Tanks.Factories.Gun
{
	public class GunFactory : SerializedMonoBehaviour, IGunFactory
	{
		[SerializeField] private IBulletMagazineView _magazineView;
		[SerializeField] private IBulletFactory _bulletFactory;
		[SerializeField] private IGunView _gunView;
		[SerializeField] private int _magazineCapacity;

		public IGun Create()
		{
			var magazine = new BulletMagazine(_magazineView, _bulletFactory, _magazineCapacity);

			return new Model.Gun.Gun(_gunView, magazine, _bulletFactory);
		}
	}
}
