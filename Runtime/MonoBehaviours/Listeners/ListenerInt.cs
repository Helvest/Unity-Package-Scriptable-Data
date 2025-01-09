using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerInt : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventInt _ScriptableEvent;
		[SerializeField]
		private UnityEventInt _response;

		private void OnEnable()
		{
			_ScriptableEvent.action += OnEventRaised;
		}

		private void OnDisable()
		{
			_ScriptableEvent.action -= OnEventRaised;
		}

		private void OnEventRaised(int value)
		{
			_response?.Invoke(value);
		}
	}
}
