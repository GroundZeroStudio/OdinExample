/****************************************************
    文件：DisableInNonPrefabsAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：用于当属性所在的组件在非预制体上面时，禁用对应的属性
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class DisableInNonPrefabsAttributeExample : MonoBehaviour
    {
        [InfoBox("这些属性只有在检查GameObject的组件时才会起作用。")]

        [DisableInNonPrefabs] // 当不是预制体是灰态此属性
        public GameObject DisabledInNonPrefabs;
    }
}
