/****************************************************
    文件：DisableInPrefabInstancesAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：用于当属性所在的组件在预制体上且预制体在Hierarchy（实例）中时，禁用属性
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class DisableInPrefabInstancesAttributeExample : MonoBehaviour
    {
        [DisableInPrefabInstances]//在hierarchy中为预制体时则禁用此属性
        public GameObject DisabledInPrefabInstances;
    }
}
