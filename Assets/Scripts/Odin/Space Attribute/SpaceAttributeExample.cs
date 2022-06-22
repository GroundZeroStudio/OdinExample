/****************************************************
    文件：SpaceAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：自带属性，用于控制字段与字段在检查器中显示的间隔
*****************************************************/

using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public class SpaceAttributeExample : MonoBehaviour
    {
        [Space]
        public int Space;

        // 但是正如其名称所示，PropertySpace也可以应用于属性。.
        [ShowInInspector, PropertySpace]
        public string Property { get; set; }

        // 您还可以控制PropertySpace属性前后的间距。
        [PropertySpace(SpaceBefore = 0, SpaceAfter = 60), PropertyOrder(2)]
        public int BeforeAndAfter;
    }
}
