using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerBool : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventBool _ScriptableEvent = null;
		[SerializeField]
		private UnityEventBool _response = null;

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
