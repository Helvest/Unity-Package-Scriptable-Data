﻿using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerVector2 : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventVector2 _ScriptableEvent = null;
		[SerializeField]
		private UnityEventVector2 _response = null;

		private void OnEnable()
		{
			_ScriptableEvent.action += OnEventRaised;
		}

		private void OnDisable()
		{
			_ScriptableEvent.action -= OnEventRaised;
		}

		private void OnEventRaised(Vector2 value)
		{
			_response?.Invoke(value);
		}
	}
}
