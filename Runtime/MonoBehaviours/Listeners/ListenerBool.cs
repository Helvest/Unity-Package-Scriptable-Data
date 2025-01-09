using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerBool : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventBool _ScriptableEvent;
		[SerializeField]
		private UnityEventBool _response;

		private void OnEnable()
		{
			_ScriptableEvent.action += OnEventRaised;
		}

		private void OnDisable()
		{
			_ScriptableEvent.action -= OnEventRaised;
		}

		private void OnEventRaised(bool value)
		{
			_response?.Invoke(value);
		}
	}
}
