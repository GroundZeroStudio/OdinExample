/****************************************************
    文件：LabelWidthAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：用于更改属性标签的宽度
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class LabelWidthAttributeExample : MonoBehaviour
    {
        public int DefaultWidth;

        [LabelWidth(50)]
        public int Thin;

        [LabelWidth(250)]
        public int Wide;
    }
}
