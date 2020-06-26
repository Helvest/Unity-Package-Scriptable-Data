using System;
using UnityEngine;

namespace Helvest.ScriptableData
{

	public abstract class ScriptableVariable<T> : ScriptableObject, ISerializationCallbackReceiver
	{
		public T InitialValue;

		[NonSerialized]
		public T RuntimeValue;

		public void OnAfterDeserialize()
		{
			RuntimeValue = InitialValue;
		}

		public void OnBeforeSerialize() { }
	}

}
