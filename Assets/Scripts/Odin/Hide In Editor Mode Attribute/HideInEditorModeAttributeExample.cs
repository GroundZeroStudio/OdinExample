/****************************************************
    文件：HideInEditorModeAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：用于在editor模式中隐藏指定属性，在play模式中显示
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class HideInEditorModeAttributeExample : MonoBehaviour
    {
        [Title("Hidden in editor mode")]//在editor下隐藏属性，运行时显示属性
        [HideInEditorMode]
        public int C;

        [HideInEditorMode]
        public int D;
    }
}
