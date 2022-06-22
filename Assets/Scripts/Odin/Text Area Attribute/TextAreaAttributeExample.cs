/****************************************************
    文件：TextAreaAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：Unity自带属性，用于在inspector面板中给字符绘制一个填写区域
*****************************************************/

using UnityEngine;

namespace Game
{
    public class TextAreaAttributeExample : MonoBehaviour
    {
        [TextArea]
        public string content = "";
    }
}
