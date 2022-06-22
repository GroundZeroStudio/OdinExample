/****************************************************
    文件：ValidateInputAttributeExample.cs
    作者：Olivia
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using UnityEngine;
using Sirenix.OdinInspector;

namespace Game
{
    public class ValidateInputAttributeExample : MonoBehaviour
    {
        [ValidateInput("MustBeNull", "这个字段应该为空")]
        public MyScripty DefaultMessage;
        private bool MustBeNull(MyScripty rScript)
        {
            return rScript == null;
        }

        [ReadOnly]
        public string dynamicMessage = "这个物体不应该为空";
        [ValidateInput("CheckGameObject", "$dynamicMessage", InfoMessageType.None)]
        public GameObject NoneTargetObj = null;
        [ValidateInput("CheckGameObject", "$dynamicMessage", InfoMessageType.Info)]
        public GameObject InfoTargetObj = null;
        [ValidateInput("CheckGameObject", "$dynamicMessage", InfoMessageType.Warning)]
        public GameObject WarningTargetObj = null;
        [ValidateInput("CheckGameObject", "$dynamicMessage", InfoMessageType.Error)]
        public GameObject ErrorTargetObj = null;

        private bool CheckGameObject(GameObject rObj)
        {
            return rObj == null;
        }

        [ValidateInput("IfNullIsFalse", "$Message", InfoMessageType.Warning)]
        public string Message = "Dynamic ValidateInput message";
        public bool IfNullIsFalse(string rValue)
        {
            return string.IsNullOrEmpty(rValue);
        }

        [ValidateInput("HasMeshRenderDynamicMessage", "对应函数中已经有消息，所以这个默认消息已经没有用了")]
        public GameObject DynamicMessage;
        private bool HasMeshRenderDynamicMessage(GameObject rGameObject, ref string rErrorMessage)
        {
            if(rGameObject == null) return true;
            if(rGameObject.GetComponentInChildren<MeshRenderer>() == null){
                rErrorMessage = "\"" + rGameObject.name + "\" 必须有一个MeshRender组件";
                return false;
            }
            return true;
        }

        [ValidateInput("HasMeshRenderDynamicMessageAndType", "对应的函数中已经有消息和类型，所以这个默认消息和类型已经没用")]
        public GameObject DynamicMessageAndType;
        [InfoBox("Change GameObject value to update message type", InfoMessageType.Info)]
        public InfoMessageType MessageType;
        private bool HasMeshRenderDynamicMessageAndType(GameObject rGameObject, ref string rErrorMessage, ref InfoMessageType? rMessageType)
        {
            if(rGameObject == null) return true;
            if(gameObject.GetComponentInChildren<MeshRenderer>() == null)
            {
                rErrorMessage = "\"" + rGameObject.name + "\" 必须有一个MeshRender组件";
                rMessageType = this.MessageType;
                return false;

            }
            return true;
        }

        private bool HasMeshRenderDefaultMessage(GameObject rGameObject)
        {
            if(rGameObject == null) return true;
            return rGameObject.GetComponentInChildren<MeshRenderer>() != null;
        }
    }
}
