using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerTransform : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventTransform _ScriptableEvent;
		[SerializeField]
		private UnityEventTransform _response;

		private void OnEnable()
		{
			_ScriptableEvent.action += OnEventRaised;
		}

		private void OnDisable()
		{
			_ScriptableEvent.action -= OnEventRaised;
		}

		private void OnEventRaised(Transform value)
		{
			_response?.Invoke(value);
		}
	}
}
