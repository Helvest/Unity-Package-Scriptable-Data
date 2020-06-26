using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerTransformArray : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventTransformArray _ScriptableEvent;
		[SerializeField]
		private UnityEventTransformArray _response;

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
