using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Model.Movement;

namespace Tanks.Factories
{
	public interface IDirectionalMovementFactory
	{
		IDirectionalMovement Create();
	}
}
