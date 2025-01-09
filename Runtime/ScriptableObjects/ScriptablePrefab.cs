using System;
using UnityEngine;

namespace Helvest.ScriptableData
{

	/// <summary>
	/// Reference the instance of a GameObject by a ScriptableObject
	/// </summary>
	public class ScriptablePrefab<T> : ScriptableObject where T : Component
	{
		[SerializeReference]
		private GameObject _prefab;

		[NonSerialized]
		protected T _instance;

		public T Instance
		{
			get
			{
#if UNITY_EDITOR
				Init();
#endif
				return _instance;
			}
		}

		[NonSerialized]
		protected GameObject _gameObject;

		public GameObject GameObject
		{
			get
			{
#if UNITY_EDITOR
				Init();
#endif
				return _gameObject;
			}
		}

		[NonSerialized]
		protected Transform _transform;

		public Transform Transform
		{
			get
			{
#if UNITY_EDITOR
				Init();
#endif
				return _transform;
			}
		}

		private void Awake()
		{
#if UNITY_EDITOR
			if (!Application.isPlaying)
			{
				_instance = default;
				return;
			}
#endif

			Init();
		}

		protected void Init()
		{
			if (_instance != null)
			{
				return;
			}

			_gameObject = Instantiate(_prefab);

			_gameObject.TryGetComponent(out _transform);

			_gameObject.TryGetComponent(out _instance);

			Debug.LogWarning(name + " Init", _gameObject);

			OnInit();
		}

		/// <summary>
		/// Call once in the initialization
		/// </summary>
		protected virtual void OnInit() { }
	}
}
