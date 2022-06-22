/****************************************************
    文件：WrapAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：用于大多数原始属性，当值超出定义范围时，可以包装该值。当您需要一个绕圆的值（例如角度）时，请使用此选项。
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class WrapAttributeExample : MonoBehaviour
    {
        [Wrap(0f, 100f)]
        public int IntWrapFrom0To100;

        [Wrap(0f, 100f)]
        public float FloatWrapFrom0To100;

        [Wrap(0f, 100f)]
        public Vector3 Vector3WrapFrom0To100;

        [Wrap(0f, 360)]
        public float AngleWrap;

        [Wrap(0f, Mathf.PI * 2)]
        public float RadianWrap;
    }
}
