/****************************************************
    文件：HideInNonPrefabsAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：用于当属性所在的组件在非预制体上面时，则隐藏属性
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class HideInNonPrefabsAttributeExample : MonoBehaviour
    {
        [HideInNonPrefabs] //非预制体时隐藏属性
        public GameObject HiddenInNonPrefabs;
    }
}
