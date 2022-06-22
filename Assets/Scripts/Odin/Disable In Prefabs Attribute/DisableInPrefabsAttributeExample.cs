/****************************************************
    文件：DisableInPrefabsAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：用于当所在的属性的组件在预制体上时，禁用组件
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class DisableInPrefabsAttributeExample : MonoBehaviour
    {
        [DisableInPrefabs]//只要是预制体，就隐藏此属性，不管是否在asset还是hierarchy
        public GameObject DisabledInPrefabs;
    }
}
