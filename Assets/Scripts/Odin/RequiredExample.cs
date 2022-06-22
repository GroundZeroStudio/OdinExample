using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Odin.Example
{
	/// <summary>
	/// Required Attribute
	/// 用于任何对象属性，如果对应属性没有赋值，则在检查器中出现对应的提示消息。
	/// </summary>
	public class RequiredExample : MonoBehaviour
	{
		[Required]
		public GameObject MyGameObject;

		[Required("自定义错误消息")]
		public Rigidbody MyRigidbody;

		public string DynamicMessage = "Dynamic Message1";
		[Required("$DynamicMessage")]
		public GameObject GameObject_DynamicMessage;

		[Required("$ReturnStringFunction")]
		public GameObject GameObject_DynamicMessage1;
		public string ReturnStringFunction()
        {
			return "我是一个方法的返回值";
        }

		[Required("$DynamicMessage", InfoMessageType.None)]
		public GameObject GameObject_None;

        [Required("$DynamicMessage", InfoMessageType.Info)]
        public GameObject GameObject_Info;

        [Required("$DynamicMessage", InfoMessageType.Warning)]
        public GameObject GameObject_Warn;

        [Required("$DynamicMessage", InfoMessageType.Error)]
        public GameObject GameObject_Error;
    }
}

