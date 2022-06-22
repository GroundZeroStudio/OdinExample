using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Odin.Example
{
    /// <summary>
    /// PropertySpace
    /// 与Unity的现有Space属性具有相同的功能，但可以应用于任何属性而不仅仅是字段,而且还可以控制与前后字段的间距
    /// </summary>
    public class PropertySpaceExample : MonoBehaviour
	{
        [Space]
        public int UnitySpace;

        [Space(5)]
        public int UnitySpace1;

        [PropertySpace]
        public int OdinSpace2;

        [ShowInInspector, PropertySpace]
        public int Property { get; set; }

        [PropertySpace(SpaceBefore = 30, SpaceAfter = 30)]
        public int BeforeAndAfter;
        [PropertySpace(SpaceBefore = 30, SpaceAfter = 30)]
        public int BeforeAndAfter1;
	}
}

