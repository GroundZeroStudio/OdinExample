/****************************************************
    文件：HideIfAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：用于任何属性，并且可以在检查器中隐藏该属性。使用此选项可根据对象的当前状态隐藏不相关的属性。
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class HideIfAttributeExample : MonoBehaviour
    {
        public UnityEngine.Object SomeObject;

        [EnumToggleButtons]
        public InfoMessageType SomeEnum;

        public bool IsToggled;

        [HideIf("SomeEnum", InfoMessageType.Info)]
        public Vector3 Info;

        [HideIf("IsToggled")]
        public Vector3 HiddenWhenToggled;

        [HideIf("SomeObject")]
        public Vector3 ShowWhenNull;

        [HideIf("@this.IsToggled && this.SomeObject != null")]
        public int HideWithExpression;
    }
}
