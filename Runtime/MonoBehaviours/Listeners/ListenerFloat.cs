﻿using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerFloat : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventFloat _ScriptableEvent = null;
		[SerializeField]
		private UnityEventFloat _response = null;

		private void OnEnable()
		{
			_ScriptableEvent.action += OnEventRaised;
		}

		private void OnDisable()
		{
			_ScriptableEvent.action -= OnEventRaised;
		}

		private void OnEventRaised(float value)
		{
			_response?.Invoke(value);
		}
	}
}
