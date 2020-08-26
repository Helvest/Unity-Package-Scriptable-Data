using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerGameObject : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventGameObject _ScriptableEvent = null;
		[SerializeField]
		private UnityEventGameObject _response = null;

		private void OnEnable()
		{
			_ScriptableEvent.action += OnEventRaised;
		}

		private void OnDisable()
		{
			_ScriptableEvent.action -= OnEventRaised;
		}

		private void OnEventRaised(GameObject value)
		{
			_response?.Invoke(value);
		}
	}
}
