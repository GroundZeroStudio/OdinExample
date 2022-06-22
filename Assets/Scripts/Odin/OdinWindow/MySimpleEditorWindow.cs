/****************************************************
    文件：MySimpleEditorWindow.cs
    作者：Olivia
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

namespace Game
{
    public class MySimpleEditorWindow : OdinEditorWindow
    {
        [MenuItem("My Game/My Simple Editor")]
        private static void OpenWindow()
        {
            GetWindow<MySimpleEditorWindow>().Show();
        }

        public string Hello = "我是笨比";
    }
}
