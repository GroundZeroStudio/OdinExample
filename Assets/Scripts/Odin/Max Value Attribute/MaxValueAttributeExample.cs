/****************************************************
    文件：MaxValueAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：用于基本字段。它将字段的值限制为最大值。使用此定义字段的最大值。
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class MaxValueAttributeExample : MonoBehaviour
    {
        [MaxValue(0)]
        public int IntMaxValue0;

        [MaxValue(0)]
        public float FloatMaxValue0;

        [MaxValue(0)]
        public Vector3 Vector3MaxValue0;
    }
}
