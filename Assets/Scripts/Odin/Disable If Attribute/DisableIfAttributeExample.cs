/****************************************************
    文件：DisableIfAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：用于任何属性，并且可以在检查器中启用或禁用该属性。相关属性时，使用此选项可禁用属性。
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class DisableIfAttributeExample : MonoBehaviour
    {
        public UnityEngine.Object SomeObject;

        [EnumToggleButtons]
        public InfoMessageType SomeEnum;

        public bool IsToggled;

        //指定的属性的值是否与给定的值一致，如果结果为true，则灰态对应的属性
        [DisableIf("SomeEnum", InfoMessageType.Info)]
        public Vector2 Info;

        [DisableIf("SomeEnum", InfoMessageType.Error)]
        public Vector2 Error;

        [DisableIf("SomeEnum", InfoMessageType.Warning)]
        public Vector2 Warning;

        //默认判断bool或者是否为null 为null则是false
        [DisableIf("IsToggled")]
        public int DisableIfToggled;

        [DisableIf("SomeObject")]
        public Vector3 EnabledWhenNull;

        [DisableIf("@this.IsToggled && this.SomeObject != null || this.SomeEnum == InfoMessageType.Error")]
        public int DisableWithExpression;
    }
}
