using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Model.Player;
using Tanks.Tools.SystemUpdates;

namespace Tanks.Factories
{
	public interface IPlayerFactory
	{
		Player Create();
	}
}
