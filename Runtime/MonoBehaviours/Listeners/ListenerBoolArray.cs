using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerBoolArray : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventBoolArray _ScriptableEvent;
		[SerializeField]
		private UnityEventBoolArray _response;

		private void OnEnable()
		{
			_ScriptableEvent.action += OnEventRaised;
		}

		private void OnDisable()
		{
			_ScriptableEvent.action -= OnEventRaised;
		}

		private void OnEventRaised(bool[] value)
		{
			_response?.Invoke(value);
		}
	}
}
