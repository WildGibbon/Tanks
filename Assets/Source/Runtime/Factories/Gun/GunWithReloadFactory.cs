using Sirenix.OdinInspector;
using Tanks.Model.Gun;
using Tanks.Model.Gun.Magazine;
using Tanks.View;
using Tanks.View.Gun;
using UnityEngine;

namespace Tanks.Factories.Gun
{
	public class GunWithReloadFactory : SerializedMonoBehaviour, IGunFactory
	{
		[SerializeField] private IGunFactory _gunFactory; 
		[SerializeField] private float _reloadDelay;

		public IGun Create()
		{
			var gunWithReload = new GunWithReloadDelay(_reloadDelay, _gunFactory.Create());

			return gunWithReload;
		}
	}
}
