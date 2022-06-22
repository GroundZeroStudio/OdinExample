/****************************************************
    文件：MinValueAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：用于基本字段。它将字段的值限制为最小值。使用此定义字段的最小值。
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class MinValueAttributeExample : MonoBehaviour
    {
        // Ints
        [Title("Int")]
        [MinValue(0)]
        public int IntMinValue0;

        // Floats
        [Title("Float")]
        [MinValue(0)]
        public float FloatMinValue0;

        // Vectors
        [Title("Vectors")]
        [MinValue(0)]
        public Vector3 Vector3MinValue0;
    }
}
