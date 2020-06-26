using UnityEngine;
using UnityEngine.Events;
using System;
using Helvest.ScriptableData;

namespace Helvest.ScriptableData
{
	public class ListenerVoid : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventVoid _ScriptableEvent;
		[SerializeField]
		private UnityEvent _response;

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
