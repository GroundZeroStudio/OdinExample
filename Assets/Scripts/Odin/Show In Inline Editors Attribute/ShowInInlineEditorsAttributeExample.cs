/****************************************************
    文件：ShowInInlineEditorsAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：用于在Inline中显示对应的属性
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class ShowInInlineEditorsAttributeExample : MonoBehaviour
    {
        [InfoBox("单击属性值打开一个新的检查窗口，也可以看到这些属性的不同.")]
        [InlineEditor(Expanded = true)]
        public MyInlineScriptableObject InlineObject;
    }
}
