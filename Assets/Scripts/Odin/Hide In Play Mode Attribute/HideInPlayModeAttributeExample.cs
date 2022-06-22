/****************************************************
    文件：HideInPlayModeAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：在Play模式下隐藏对应属性
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class HideInPlayModeAttributeExample : MonoBehaviour
    {
        [Title("Hidden in play mode")]
        [HideInPlayMode]
        public int A;

        [HideInPlayMode]
        public int B;
    }
}
