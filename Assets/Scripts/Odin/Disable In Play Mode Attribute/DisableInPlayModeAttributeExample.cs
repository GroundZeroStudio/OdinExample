/****************************************************
    文件：DisableInPlayModeAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：在play模式下灰态指定属性，editor模式下显示
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class DisableInPlayModeAttributeExample : MonoBehaviour
    {
        [Title("运行模式下禁用属性")]
        [DisableInPlayMode]
        public int A;

        [DisableInPlayMode]
        public Material B;
    }
}
