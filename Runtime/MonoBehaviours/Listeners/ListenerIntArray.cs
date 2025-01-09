using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerIntArray : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventIntArray _ScriptableEvent;
		[SerializeField]
		private UnityEventIntArray _response;

		private void OnEnable()
		{
			_ScriptableEvent.action += OnEventRaised;
		}

		private void OnDisable()
		{
			_ScriptableEvent.action -= OnEventRaised;
		}

		private void OnEventRaised(int[] value)
		{
			_response?.Invoke(value);
		}
	}
}
