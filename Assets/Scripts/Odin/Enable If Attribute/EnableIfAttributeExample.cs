/****************************************************
    文件：EnableIfAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：用于任何属性，并且可以在检查器中启用或禁用该属性。相关属性时，使用此选项可启用属性。
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class EnableIfAttributeExample : MonoBehaviour
    {
        public UnityEngine.Object SomeObject;

        [EnumToggleButtons]
        public InfoMessageType SomeEnum;

        public bool IsToggled;

        [EnableIf("SomeEnum", InfoMessageType.Info)]
        public Vector2 Info;

        [EnableIf("SomeEnum", InfoMessageType.Error)]
        public Vector2 Error;

        [EnableIf("SomeEnum", InfoMessageType.Warning)]
        public Vector2 Warning;

        [EnableIf("IsToggled")]
        public int EnableIfToggled;

        [EnableIf("SomeObject")]
        public Vector3 EnabledWhenHasReference;

        [EnableIf("@this.IsToggled && this.SomeObject != null || this.SomeEnum == InfoMessageType.Error")]
        public int EnableWithExpression;
    }
}
