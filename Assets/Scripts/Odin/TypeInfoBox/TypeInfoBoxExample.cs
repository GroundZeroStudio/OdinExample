using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Examples;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{

	/// <summary>
	/// TypeInfoBox特性：将信息框添加到Inspector中类型的最顶部。
	/// 使用此选项可将信息框添加到Inspector中类的顶部，而无需同时使用PropertyOrder和OnInspectorGUI属性。
	/// </summary>
	public class TypeInfoBoxExample : MonoBehaviour
	{
		public MyType MyObject = new MyType();

		[InfoBox("双击此段的value值，可在Inspecter中查看对应的ScriptableObject信息")]
		public MyScripty Scripty = null;
        public void Awake()
        {
			Scripty = ExampleHelper.GetScriptableObject<MyScripty>("MyScripty_ScriptableObject");
        }

		[Serializable]
		[TypeInfoBox("TypeInfoBox特性可以放在类型定义上，并将导致在属性的顶端处绘制一个InfoBox。")]
        public class MyType
        {
            public int Value;
        }
	}
}

