using UnityEngine;
using System.Collections;

public class ResourcesLoadMgr : Singleton<ResourcesLoadMgr> 
{
    public GameObject LoadUI(string uiName_,Transform tfParent_ = null)
    {
        string resPath = GolableDefine.Instance.UIPrefabPath + uiName_;
        GameObject objPrefab = LoadAsset<GameObject>(resPath);
        GameObject objUI = null;
        if(objPrefab != null)
        {
            objUI = GameObject.Instantiate(objPrefab) as GameObject;
            if(objUI != null)
            {
                if (tfParent_ != null)
                    objUI.transform.parent = tfParent_;
                objUI.name = uiName_;
                objUI.transform.localPosition = Vector3.zero;
                objUI.transform.localScale = Vector3.one;
                objUI.transform.localRotation = Quaternion.identity;

            }
        }
        else
        {
            Debug.Log("Load Asset Fail: " + resPath);
        }

        return objUI;
    }

    public UnityEngine.Object LoadAsset(string assetPath_)
    {

        return Resources.Load(assetPath_);
    }

    public T LoadAsset<T> (string assetPath_) where T : UnityEngine.Object
    {

        return Resources.Load<T>(assetPath_);
    }

}
