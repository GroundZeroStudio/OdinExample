using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu(fileName = "MyScripty_ScriptableObject", menuName = "CreatScriptableObject/MyScripty", order = 100)]
	[TypeInfoBox("TypeInfoBox特性 能以文本的形式显示在顶端")]
	public class MyScripty : ScriptableObject
	{
		public string MyText = ExampleHelper.GetString();
		[TextArea(10, 15)]
		public string Box;
	}
}

