using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks.Model.Gun
{
	public interface IBulletMagazine
	{
		IBullet TakeBullet();
		bool CanTakeBullet();
		void Fill();
	}
}
