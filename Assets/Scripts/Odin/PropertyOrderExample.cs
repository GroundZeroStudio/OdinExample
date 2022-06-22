using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Odin.Example
{
	/// <summary>
	/// PropertyOrder Attribute
	/// 用于任何属性，并允许对属性进行排序。使用此选项可以定义属性的显示顺序。
	/// </summary>
	public class PropertyOrderExample : MonoBehaviour
	{
		[PropertyOrder(1)]
		public int Second;

		[InfoBox("PropertyOrder用于更改Inpsector中属性的顺序")]
		[PropertyOrder(0)]
		public int First;
	}
}

