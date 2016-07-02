using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class WindowControllerMgr : Singleton<WindowControllerMgr> 
{
    private Transform tf_mainUI;
    private List<GameObject> m_windowList = new List<GameObject>();
    private Dictionary<EWindowID, GameObject> m_windowDic = new Dictionary<EWindowID, GameObject>();
    public Dictionary<EWindowID, GameObject> WindowDic
    {
        get { return m_windowDic; }
        set { m_windowDic = value; }
    }
    private EWindowID m_lastWindowID = EWindowID.Max;


    ////////////////////////////////////////////////////////////Function
    public WindowControllerMgr()
    {
        if(GameMain.Instance.UIRoot != null)
        {
            tf_mainUI = GameMain.Instance.UIRoot.transform.Find("MainUI");
        }
    }
    public void OpenWindow(EWindowID eWindow_)
    {
        GameObject objWindow = null;
        if (m_windowDic.ContainsKey(eWindow_))
        {
            objWindow = m_windowDic[eWindow_];
        }
        else
        {
            objWindow = ResourcesLoadMgr.Instance.LoadUI(UINameDefine.Instance.WindowName[eWindow_], tf_mainUI);
            m_windowDic[eWindow_] = objWindow;

            DoLastWindow(eWindow_);
        }
    }

    public void DoLastWindow(EWindowID eWindow_)
    {
        if(m_lastWindowID != EWindowID.Max && m_windowDic.ContainsKey(eWindow_))
        {
            m_windowDic[m_lastWindowID].SetActive(false);
        }

        m_lastWindowID = eWindow_;
    }


}
