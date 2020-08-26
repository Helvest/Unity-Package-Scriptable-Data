using System;
using Helvest.ScriptableData;
using UnityEngine;
using UnityEngine.Events;

namespace Helvest.ScriptableData
{
	public class ListenerVoid : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventVoid _ScriptableEvent = null;
		[SerializeField]
		private UnityEvent _response = null;

		private void OnEnable()
		{
			_ScriptableEvent.action += OnEventRaised;
		}

		private void OnDisable()
		{
			_ScriptableEvent.action -= OnEventRaised;
		}

		private void OnEventRaised()
		{
			_response?.Invoke();
		}
	}
}
