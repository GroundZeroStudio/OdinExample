using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Odin.Example
{
	/// <summary>
	/// GUIColor Attribute
	/// 用于任何属性，并更改用于绘制属性的GUI颜色。
	/// </summary>
	public class GUIColorExample : MonoBehaviour
	{
		[GUIColor(0.3f, 0.8f, 0.8f, 1f)]  //RGBA
		public int ColorInt1;

        [GUIColor(0.3f, 0.8f, 0.8f, 1f)]
        public int ColorInt2;

		[ButtonGroup]
		[GUIColor(0, 1, 0)]
		void Apply()
        {
			Debug.Log("应用");
        }

		[ButtonGroup]
		[GUIColor(1, 0.6f, 0.4f)]
		void Cancel()
        {
			print("取消");
        }


		[GUIColor("GetButtonColor")]
		[Button(ButtonSizes.Gigantic)]
		static void IAmFabulous()
        {

        }

		static Color GetButtonColor()
        {
			Sirenix.Utilities.Editor.GUIHelper.RequestRepaint();
			return Color.HSVToRGB(Mathf.Cos((float)UnityEditor.EditorApplication.timeSinceStartup + 1f) * 0.225f + 0.325f, 1, 1);
        }

		[Button(ButtonSizes.Large)]
		[GUIColor("@Color.Lerp(Color.red, Color.green, Mathf.Sin((float)EditorApplication.timeSinceStartup))")]
		static void Expressive_One()
        {

        }

        [Button(ButtonSizes.Large)]
        [GUIColor("CustomColor")]
        private static void Expressive_Two()
        {
        }

#if UNITY_EDITOR
        public Color CustomColor()
        {
            return Color.Lerp(Color.red, Color.green, Mathf.Sin((float)EditorApplication.timeSinceStartup));
        }
#endif
    }
}

