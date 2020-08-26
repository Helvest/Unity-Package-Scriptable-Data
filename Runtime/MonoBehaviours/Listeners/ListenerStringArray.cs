using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerStringArray : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventStringArray _ScriptableEvent = null;
		[SerializeField]
		private UnityEventStringArray _response = null;

		private void OnEnable()
		{
			_ScriptableEvent.action += OnEventRaised;
		}

		private void OnDisable()
		{
			_ScriptableEvent.action -= OnEventRaised;
		}

		private void OnEventRaised(string[] value)
		{
			_response?.Invoke(value);
		}
	}
}
