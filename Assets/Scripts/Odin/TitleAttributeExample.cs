using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Odin.Example
{
	/// <summary>
	/// Title Attribute
	/// 用于在属性 上方生成粗体标题
	/// </summary>
	public class TitleAttributeExample : MonoBehaviour
	{
		[Title("Title and Headers")]
		public string MyTitle = "My Dynamic Title";
		public string MySubtitle = "My Dynamic Subtitle";

		//直接设置标题，或者添加标题和副标题
		[Title("Static title")]
		public int C;
		public int D;

		[Title("Static title", "Static subtitle")]
		public int E;
		public int F;

		//标题样式：是否为粗体和是否含有对应的下划线
		[Title("Non bold title", "$MySubtitle", bold: false)]
		public int I;
		public int J;
		[Title("Non bold title", "With no line seperator", horizontalLine: false, bold: false)]
		public int K;
		public int L;
		//1.设置标题的不同布局
		//2.用特殊标识符$来获取一个属性字段或者函数的返回值作为消息内容
		[Title("$MyTitle", "$MySubtitle", TitleAlignments.Left)]
        public int M;
        public int N;
		[Title("$MyTitle", "$MySubtitle", TitleAlignments.Centered)]
		public int O;
        public int P;
		[Title("$MyTitle", "$MySubtitle", TitleAlignments.Right)]
		public int Q;
		public int R;
		[Title("$MyTitle", "$MySubtitle", TitleAlignments.Split)]
		public int S;
		public int T;

		[Title("Title on a Method")]
		[Button]
		public void DoNothing()
        {

        }

		//使用特殊标识符@将方法体以字符串的形式当实参传入进去
		[Title("@DateTime.Now.ToString(\"dd:MM:yyyy\")", "@DateTime.Now.ToString(\"HH:mm:ss\")")]
		public int Expresion;

		public string Combined { get { return this.MyTitle + " - " + this.MySubtitle; } }
	}
}

