using System;
using UnityEngine;

namespace Helvest.ScriptableData
{

	public class ScriptableClass<T> : ScriptableObject where T : new()
	{
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

		protected virtual void Init()
		{
			if (_instance != null)
			{
				return;
			}

			_instance = new T();

			Debug.LogWarning(name + " Init");

			OnInit();
		}

		/// <summary>
		/// Call once in the initialization
		/// </summary>
		protected virtual void OnInit() { }
	}
}
