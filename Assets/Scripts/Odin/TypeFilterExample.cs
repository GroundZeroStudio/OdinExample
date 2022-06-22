using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Game
{
	/// <summary>
	/// Type Filter 特性：对输入的Value进行自定义过滤，只显示需要的类型
	/// </summary>
	public class TypeFilterExample : MonoBehaviour
	{
		[ShowInInspector]
		[TypeFilter("GetFilteredTypeList")]
		public BaseClass A, B;

		[ShowInInspector]
		[TypeFilter("GetFilteredTypeList")]
		public BaseClass[] Array = new BaseClass[3];


		public IEnumerable<Type> GetFilteredTypeList()
        {
			var t = typeof(BaseClass).Assembly.GetTypes()
				.Where(x => !x.IsAbstract)    //不包括BaseClass
				.Where(x => !x.IsGenericTypeDefinition)	//不包括 C1<>
				.Where(x => typeof(BaseClass).IsAssignableFrom(x)); //排除没有继承BaseClass的类

            t = t.AppendWith(typeof(C1<>).MakeGenericType(typeof(GameObject)));     //添加C1泛型为GameObject 的value
			t = t.AppendWith(typeof(C1<>).MakeGenericType(typeof(AnimationCurve))); //添加C1泛型为AnimationCurve 的value
			t = t.AppendWith(typeof(C1<>).MakeGenericType(typeof(List<float>)));    //添加C1泛型为List<float> 的value

			return t;
        }



        public abstract class BaseClass
        {
			public int BaseField;
        }

		public class A1 : BaseClass { public int _A1; }
		public class A2 : A1 { public int _A2; }
		public class A3 : A2 { public int _A3; }
        public class B1 : BaseClass { public int _B1; }
        public class B2 : B1 { public int _B2; }
        public class B3 : B2 { public int _B3; }
		public class C1<T> : BaseClass { public T C; }
    }
}

