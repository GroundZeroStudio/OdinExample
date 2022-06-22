/****************************************************
    文件：属性所在的组件在预制体上，且预制体在为Asset（在project中）时，隐藏属性.cs
    作者：Olivia
    日期：#CreateTime#
    功能：属性所在的组件在预制体上，且预制体在为Asset（在project中）时，隐藏属性
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class HideInPrefabAssetsAttributeExample : MonoBehaviour
    {
        [HideInPrefabAssets] //在Asset中且是预制体时隐藏
        public GameObject HiddenInPrefabAssets;
    }
}
