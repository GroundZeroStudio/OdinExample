/****************************************************
    文件：TableColumnWidthAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：属性用于进一步自定义使用“ TableListAttribute” 绘制的表中的列的宽度。
*****************************************************/

using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class TableColumnWidthAttributeExample : MonoBehaviour
    {
        [TableList]
        public List<MyItem> List = new List<MyItem>()
        {
            new MyItem(),
            new MyItem(),
            new MyItem(),
        };

        [Serializable]
        public class MyItem
        {
            [PreviewField(Height = 20)]
            [TableColumnWidth(30, Resizable = false)]
            public Texture2D Icon;

            [TableColumnWidth(60)]
            public int ID;
            [TableColumnWidth(100)]
            public string Name;
        }
    }
}
