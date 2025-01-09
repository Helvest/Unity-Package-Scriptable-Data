using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerString : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventString _ScriptableEvent;
		[SerializeField]
		private UnityEventString _response;

		private void OnEnable()
		{
			_ScriptableEvent.action += OnEventRaised;
		}

		private void OnDisable()
		{
			_ScriptableEvent.action -= OnEventRaised;
		}

		private void OnEventRaised(string value)
		{
			_response?.Invoke(value);
		}
	}
}
