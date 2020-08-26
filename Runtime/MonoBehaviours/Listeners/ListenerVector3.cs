using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerVector3 : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventVector3 _ScriptableEvent = null;
		[SerializeField]
		private UnityEventVector3 _response = null;

		private void OnEnable()
		{
			_ScriptableEvent.action += OnEventRaised;
		}

		private void OnDisable()
		{
			_ScriptableEvent.action -= OnEventRaised;
		}

		private void OnEventRaised(Vector3 value)
		{
			if (useDebug)
			{
				//Debug.Log(name + " | OnEventRaised: " + value.ToString(), this);
				Debug.Log(_response.GetPersistentEventCount());
			}

			_response?.Invoke(value);
		}

		public bool useDebug = false;
	}
}
