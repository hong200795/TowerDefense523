using UnityEngine;
using System.Collections;

public class GameMain : MonoBehaviour 
{
    private static GameMain s_instance;
    public static GameMain Instance
    {
        get { return s_instance; }
    }
    private GameObject m_uiRoot;
    public GameObject UIRoot
    {
        get { return m_uiRoot; }
    }
	// Use this for initialization
	void Start () 
    {
        s_instance = this;
        m_uiRoot = GameObject.FindWithTag("UIRoot");
        if(m_uiRoot == null)
        {
            m_uiRoot = ResourcesLoadMgr.Instance.LoadUI("UIRoot");
        }

        OnDonstroyGameObject();

        InitDataOver();
	}
	
    //所有一开始需要初始化的数据操作结束之后执行
    void InitDataOver()
    {
        WindowControllerMgr.Instance.OpenWindow(EWindowID.UILogin);
    }
    void OnDonstroyGameObject()
    {
        DontDestroyOnLoad(this);
        DontDestroyOnLoad(m_uiRoot);
    }

}

