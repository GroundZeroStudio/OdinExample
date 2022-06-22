using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Odin.Example
{
	/// <summary>
	/// Hide Label Attribute
	/// 用于任何属性，并在Inspector中中隐藏标签。使用此选项可隐藏Inspector中的属性标签。也就是把字段的名称隐藏，只留下value
    /// </summary>
    public class HideLabelExample : MonoBehaviour
	{
		public string ShowLabel = "孤城落日斗兵稀";

		[HideLabel]
		public string HideLabel = "隐藏标题";

		[ShowInInspector]
		public string ShowPropertyLabel { get; set; }

		[ShowInInspector][HideLabel]
		public string HidePropertyLabel { get; set; }
	}
}

