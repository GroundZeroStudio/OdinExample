using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Odin.Example
{
    /// <summary>
    /// Custom Value Drawer Attribute 特性，允许用户自定义一个绘制方法，字段将以自定的绘制方式展示在Inspector中，非常灵活。
    /// </summary>
	public class CustomValueDrawerExample : MonoBehaviour
	{
		public float Max = 100, Min = 0;

		[CustomValueDrawer("MyStaticCustomDrawerStatic")]
		public float CustomDrawerStatic;

		static float MyStaticCustomDrawerStatic(float value, GUIContent label)
        {
			return EditorGUILayout.Slider(label, value, 0f, 100f);
        }

		[CustomValueDrawer("MyStaticCustomDrawerInstance")]
		public float CustomDrawerInstance;
		float MyStaticCustomDrawerInstance(float value, GUIContent label)
        {
			return EditorGUILayout.Slider(label, value, Min, Max);
        }

		[CustomValueDrawer("MyStaticCustomDrawerArray")]
		public float[] CustomDrawerArray = new float[] { 3f, 5f, 7f };

		float MyStaticCustomDrawerArray(float value, GUIContent label)
        {
			return EditorGUILayout.Slider(label, value, Min, Max);
        }

        [CustomValueDrawer("HaveLabelNameFunction")]
        public string HaveLabelName;
        [CustomValueDrawer("NoLabelNameFunction")]
        public string NoLabelName;

        public string HaveLabelNameFunction(string tempName, GUIContent label)
        {
            return EditorGUILayout.TextField(tempName);
        }
        public string NoLabelNameFunction(string tempName, GUIContent label)
        {
            return EditorGUILayout.TextField(label, tempName);
        }

    }
}

