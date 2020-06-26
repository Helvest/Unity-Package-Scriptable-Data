using System;
using UnityEngine;
using UnityEngine.Events;

namespace Helvest.ScriptableData
{
	[Serializable]
	public class UnityEventBool : UnityEvent<bool> { }

	[Serializable]
	public class UnityEventBoolArray : UnityEvent<bool[]> { }

	[Serializable]
	public class UnityEventByte : UnityEvent<byte> { }

	[Serializable]
	public class UnityEventByteArray : UnityEvent<byte[]> { }

	[Serializable]
	public class UnityEventInt : UnityEvent<int> { }

	[Serializable]
	public class UnityEventIntArray : UnityEvent<int[]> { }

	[Serializable]
	public class UnityEventFloat : UnityEvent<float> { }

	[Serializable]
	public class UnityEventFloatArray : UnityEvent<float[]> { }

	[Serializable]
	public class UnityEventChar : UnityEvent<char> { }

	[Serializable]
	public class UnityEventCharArray : UnityEvent<char[]> { }

	[Serializable]
	public class UnityEventString : UnityEvent<string> { }

	[Serializable]
	public class UnityEventStringArray : UnityEvent<string[]> { }

	[Serializable]
	public class UnityEventVector2 : UnityEvent<Vector2> { }

	[Serializable]
	public class UnityEventVector2Array : UnityEvent<Vector2[]> { }

	[Serializable]
	public class UnityEventVector3 : UnityEvent<Vector3> { }

	[Serializable]
	public class UnityEventVector3Array : UnityEvent<Vector3[]> { }

	[Serializable]
	public class UnityEventVector4 : UnityEvent<Vector4> { }

	[Serializable]
	public class UnityEventVector4Array : UnityEvent<Vector4[]> { }

	[Serializable]
	public class UnityEventQuaternion : UnityEvent<Quaternion> { }

	[Serializable]
	public class UnityEventQuaternionArray : UnityEvent<Quaternion[]> { }

	[Serializable]
	public class UnityEventTransform : UnityEvent<Transform> { }

	[Serializable]
	public class UnityEventTransformArray : UnityEvent<Transform[]> { }

	[Serializable]
	public class UnityEventGameObject : UnityEvent<GameObject> { }

	[Serializable]
	public class UnityEventGameObjectArray : UnityEvent<GameObject[]> { }
}
