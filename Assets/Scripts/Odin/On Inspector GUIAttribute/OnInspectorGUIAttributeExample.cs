/****************************************************
    文件：OnInspectorGUIAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：可用于任何属性，只要检查器代码正在运行，它将调用指定的函数。使用它为对象创建自定义检查器GUI。
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class OnInspectorGUIAttributeExample : MonoBehaviour
    {
        [OnInspectorGUI("DrawPreview", append: true)]
        public Texture2D Texture;
        private void DrawPreview()
        {
            if (this.Texture == null) return;

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label(this.Texture);
            GUILayout.EndVertical();
        }

        [OnInspectorGUI]
        private void OnInspectorGUI()
        {
            UnityEditor.EditorGUILayout.HelpBox("OnInspectorGUI还可以用于方法和属性", UnityEditor.MessageType.Info);
        }
    }
}
