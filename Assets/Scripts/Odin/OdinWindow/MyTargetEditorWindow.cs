/****************************************************
    文件：MyTargetEditorWindow.cs
    作者：Olivia
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

namespace Game
{
    public class MyTargetEditorWindow : OdinEditorWindow
    {
        [MenuItem("My Game/My Target Editor")]
        private static void OpenWindow()
        {
            GetWindow<MyTargetEditorWindow>().Show();
        }

        protected override void Initialize()
        {
            this.WindowPadding = Vector4.zero;
        }

        protected override object GetTarget()
        {
            return Selection.activeObject;
        }
    }
}
