using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.View;
using UnityEngine;
using UnityEngine.UI;

namespace Tanks.View.Gun
{
	public class TextBulletMagazineView : MonoBehaviour, IBulletMagazineView
	{
		[SerializeField] private Text _label; 

		public void Visualize(int count, int maxCount)
		{
			_label.text = $"{count}/{maxCount}";
		}
	}
}
