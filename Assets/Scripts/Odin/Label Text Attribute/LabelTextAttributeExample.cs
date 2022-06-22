/****************************************************
    文件：LabelTextAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：用于更改属性的标签。如果您想要的标签与属性名称不同，请使用此标签。
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class LabelTextAttributeExample : MonoBehaviour
    {
        [LabelText("1")]
        public int MyInt1;

        [LabelText("2")]
        public int MyInt2;

        [LabelText("3")]
        public int MyInt3;

        [InfoBox("Use $ to refer to a member string.")]
        [LabelText("$LabelText")]
        public string LabelText = "Dynamic label text";

        [InfoBox("Use @ to execute an expression.")]
        [LabelText("@DateTime.Now.ToString(\"HH:mm:ss\")")]
        public string DateTimeLabel;
    }
}
