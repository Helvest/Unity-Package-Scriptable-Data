using System;
using UnityEngine;

namespace Helvest.ScriptableData
{
	[CreateAssetMenu(menuName = "ScriptableArchit/Event/Void")]
	public class ScriptableEventVoid : ScriptableObject
	{
		public event Action action;

		public void Raise()
		{
			action?.Invoke();
		}
	}
}
