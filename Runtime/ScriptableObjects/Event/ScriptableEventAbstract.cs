using System;
using UnityEngine;


namespace Helvest.ScriptableData
{
	public abstract class ScriptableEventAbstract<T> : ScriptableObject
	{
		public event Action<T> action;

		[SerializeField]
		private bool _saveValue = false;

		[NonSerialized]
		public T savedValue;

		public void Raise(T value)
		{
			if (_saveValue)
			{
				savedValue = value;
			}	

			if (useDebug)
			{
				Debug.Log(name + ": " + value.ToString(), this);
			}
			
			action?.Invoke(value);
		}

		[Header("Debug")]

		[SerializeField]
		private bool useDebug = false;
	}
}