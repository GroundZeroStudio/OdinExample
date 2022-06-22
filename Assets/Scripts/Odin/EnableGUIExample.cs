using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Odin.Example
{
	/// <summary>
	/// Enable GUIAttribute
	/// 可以控制只有Get的属性，在Inspector中是否为可灰态的（但是依然不可编辑），不写则默认为灰态。
	/// </summary>
	public class EnableGUIExample : MonoBehaviour
	{
		[ShowInInspector]
		public int GUIDDisabledProperty { get { return 20; } }

		[ShowInInspector, EnableGUI]
		public int GUIEnabledProperty { get { return 10; } }
	}
}

