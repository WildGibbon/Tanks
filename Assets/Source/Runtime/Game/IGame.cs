using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Game.SystemUpdates;

namespace Tanks.Game
{
	public interface IGame : IUpdatable
	{
		void Play();
	}
}
