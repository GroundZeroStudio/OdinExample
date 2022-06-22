/****************************************************
    文件：DisableInEditorModeAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：可用于任何属性，并且在不处于播放模式时会禁用该属性。仅在播放模式下希望属性可编辑时，请使用此选项。
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class DisableInEditorModeAttributeExample : MonoBehaviour
    {
        [Title("Disabled in edit mode")]//在Editor模式下灰态对应的属性或字段
        [DisableInEditorMode]
        public GameObject A;

        [DisableInEditorMode]
        public Material B;
    }
}
