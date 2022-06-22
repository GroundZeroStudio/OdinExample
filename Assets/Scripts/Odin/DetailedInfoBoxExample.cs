using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Odin.Example
{
	/// <summary>
	/// Detailed Info Box Attribute
	/// 在Inspector面板中绘制一个信息面板，添加对应标题和详细信息描述，点击时可以显示出对应填写的详细信息
	/// </summary>
	public class DetailedInfoBoxExample : MonoBehaviour
	{
		[DetailedInfoBox("简介信息", "默认情况下VisibleIf为true, 所以此消息框可见", InfoMessageType.None)]
		public string NoneMessage = "无";

        [DetailedInfoBox("简介信息", "默认情况下VisibleIf为true, 所以此消息框可见", InfoMessageType.Info)]
        public string InfoMessage = "无";

        [DetailedInfoBox("简介信息", "默认情况下VisibleIf为true, 所以此消息框可见", InfoMessageType.Warning)]
        public string WarnMessage = "无";

        [DetailedInfoBox("简介信息", "默认情况下VisibleIf为true, 所以此消息框可见", InfoMessageType.Error)]
        public string ErrorMessage = "无";

        [DetailedInfoBox("简洁消息", "默认情况下VisibleIf为True。" +
        "所以此消息框可见.还可以通过一个方法的返回值（bool）来控制消息框是否显示，" +
        "例如在这个函数中判断此字段是否为null，如果为null在出现弹窗提示等。", InfoMessageType.None, VisibleIf = "VisibleFunction")]
        public string HaveVisible = "";

        bool VisibleFunction()
        {
            return true;
        }

        [DetailedInfoBox("简介消息", "还可以通过一个方法的返回值（bool）来控制消息框是否显示，例如在这个函数中判断此字段是否为null，如果为null在出现弹窗提示等。", InfoMessageType = InfoMessageType.None, VisibleIf = "NoVisibleFunction")]
        public string NoVisibleIfMessage = "";
        bool NoVisibleFunction()
        {
            return string.IsNullOrEmpty(NoVisibleIfMessage);
        }
    }
}

