using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public abstract class WindowController : MonoBehaviour
{
    
    public virtual void Awake()
    {

    }
	// Use this for initialization
    public virtual void Start() 
    {
	
	}


    public void CloseWindow(EWindowID eWindow_)
    {
        Destroy(gameObject);
        WindowControllerMgr.Instance.WindowDic[eWindow_] = null;
        WindowControllerMgr.Instance.WindowDic.Remove(eWindow_);
    }

    public virtual void OnDestroy()
    {

    }
}
