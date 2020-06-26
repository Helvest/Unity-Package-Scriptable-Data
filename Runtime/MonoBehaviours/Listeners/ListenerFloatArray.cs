using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerFloatArray : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventFloatArray _ScriptableEvent;
		[SerializeField]
		private UnityEventFloatArray _response;

		private void OnEnable()
		{
			_ScriptableEvent.action += OnEventRaised;
		}

		private void OnDisable()
		{
			_ScriptableEvent.action -= OnEventRaised;
		}

		private void OnEventRaised(float[] value)
		{
			_response?.Invoke(value);
		}
	}
}
