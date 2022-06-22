/****************************************************
    文件：DisableInPrefabAssetsAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：用于当属性所在的组件是预制体，且预制体在Asset中时禁用属性
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class DisableInPrefabAssetsAttributeExample : MonoBehaviour
    {
        [DisableInPrefabAssets]//在asset中且为预制体时，这个属性被警用
        public GameObject DisabledInPrefabAssets;
    }
}
