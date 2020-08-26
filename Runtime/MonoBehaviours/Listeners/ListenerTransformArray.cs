﻿using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerTransformArray : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventTransformArray _ScriptableEvent = null;
		[SerializeField]
		private UnityEventTransformArray _response = null;

		private void OnEnable()
		{
			_ScriptableEvent.action += OnEventRaised;
		}

		private void OnDisable()
		{
			_ScriptableEvent.action -= OnEventRaised;
		}

		private void OnEventRaised(Transform[] value)
		{
			_response?.Invoke(value);
		}
	}
}
