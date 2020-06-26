using UnityEngine;

namespace Helvest.ScriptableData
{
	public class ListenerVector3Array : MonoBehaviour
	{
		[SerializeField]
		private ScriptableEventVector3Array _ScriptableEvent;
		[SerializeField]
		private UnityEventVector3Array _response;

		private void OnEnable()
		{
			_ScriptableEvent.action += OnEventRaised;
		}

		private void OnDisable()
		{
			_ScriptableEvent.action -= OnEventRaised;
		}

		private void OnEventRaised(Vector3[] value)
		{
#if UNITY_EDITOR
			if (useDebug)
			{
				Debug.Log(name + " | OnEventRaised: " + value.ToString(), this);
				//Debug.Log(_response.GetPersistentEventCount());
			}
#endif

			_response?.Invoke(value);
		}

#if UNITY_EDITOR
		public bool useDebug = false;
#endif
	}
}
