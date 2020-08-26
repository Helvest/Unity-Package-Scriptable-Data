﻿using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerGameObjectArray : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventGameObjectArray _ScriptableEvent = null;
		[SerializeField]
		private UnityEventGameObjectArray _response = null;

		private void OnEnable()
		{
			_ScriptableEvent.action += OnEventRaised;
		}

		private void OnDisable()
		{
			_ScriptableEvent.action -= OnEventRaised;
		}

		private void OnEventRaised(GameObject[] value)
		{
			_response?.Invoke(value);
		}
	}
}
