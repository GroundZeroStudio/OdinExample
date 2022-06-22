using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Odin.Example
{
	/// <summary>
	/// AssetsOnly： 点击需要序列化的资源字段时，在出现的弹窗中只有Project中的资源文件，不会出现Hierachy（场景）的资源
	/// SceneObjectsOnly： 点击需要序列化的资源字段时，在出现的弹窗中只有Hierachy中的资源文件，不会出现Project中的资源
	/// 注意：例如：预制体等资源在Scene或者Project中都含有，出现的弹窗中也都会含有对应的资源
	/// </summary>
	public class AssetsOnlyExample : MonoBehaviour
	{
        [AssetsOnly]
		public List<GameObject> OnlyPrefabs;

		[AssetsOnly]
		public GameObject SomePrefab;

		[AssetsOnly]
		public Material MaterialAsset;

		[AssetsOnly]
		public MeshRenderer SomeMeshRendererOnPrefab;

		[SceneObjectsOnly]
		public List<GameObject> OnlySceneObjects;

		[SceneObjectsOnly]
		public GameObject SomeSceneObject;

		[SceneObjectsOnly]
		public MeshRenderer SomeMeshRenderer;

	}
}

