/****************************************************
    文件：DisableInInlineEditorsAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：用于在Inline中禁用（灰态）对应的属性
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class DisableInInlineEditorsAttributeExample : MonoBehaviour
    {
        [InfoBox("Click the pen icon to open a new inspector window for the InlineObject too see the difference this attribute make.")]
        [InlineEditor(Expanded = true)]
        public MyInlineScriptableObject InlineObject;
    }

    [CreateAssetMenu(fileName = "MyInline_ScriptableObject", menuName = "CreatScriptableObject/MyInlineScriptableObject")]
    public class MyInlineScriptableObject : ScriptableObject
    {
        [ShowInInlineEditors]
        public string ShownInInlineEditor;

        [HideInInlineEditors]//在绘制的里面不显示
        public string HiddenInInlineEditor;

        [DisableInInlineEditors]//显示但是是灰态
        public string DisabledInInlineEditor;
    }
}
