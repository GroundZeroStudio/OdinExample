using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Odin.Example
{
	/// <summary>
	/// Delayed Property Attribute：此特性会延迟在editor中的序列化操作，需确认后保存
	/// </summary>
	public class DelayedPropertyExample : MonoBehaviour
	{
        #region 即时
        [OnValueChanged("ValueChangeCallBack")]
        public int field;

        [ShowInInspector]
        [OnValueChanged("ValueChangeCallBack")]
        public string property { get; set; }
        #endregion

        #region 延时
        [Delayed]  //字段
        [OnValueChanged("ValueChangeCallBack")]
        public int DelayedField;

        [ShowInInspector, DelayedProperty]  //属性
        [OnValueChanged("ValueChangeCallBack")]
        public string DelayedProperty { get; set; }
        #endregion


        public void ValueChangeCallBack()
        {
            print("数值有变化:");
        }
    }
}

