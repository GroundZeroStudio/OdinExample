/****************************************************
    文件：PropertyRangeAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：属性创建一个滑块控件，以将属性的值设置在指定范围之间。这等效于Unity的Range属性，但是此属性可以同时应用于字段和属性。
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class PropertyRangeAttributeExample : MonoBehaviour
    {
        [Range(0, 10)]
        public int Field = 2;

        [InfoBox("Odin的PropertyRange属性类似于Unity的Range属性，但也适用于属性.")]
        [ShowInInspector, PropertyRange(0, 10)]
        public int Property { get; set; }

        [InfoBox("您还可以为最小值和最大值中的一个或两个引用成员。.")]
        [PropertyRange(0, "Max"), PropertyOrder(3)]
        public int Dynamic = 6;

        [PropertyOrder(4)]
        public int Max = 100;
    }
}
