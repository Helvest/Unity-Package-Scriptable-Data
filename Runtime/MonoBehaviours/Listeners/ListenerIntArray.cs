using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerIntArray : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventIntArray _ScriptableEvent = null;
		[SerializeField]
		private UnityEventIntArray _response = null;

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
