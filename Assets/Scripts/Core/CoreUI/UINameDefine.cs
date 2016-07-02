using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


public enum EWindowID
{
    UILogin = 0,
    UILobby = 1,

    Max
}
public class UINameDefine : Singleton<UINameDefine>
{
    //窗体枚举对应的窗体UI名字
    private Dictionary<EWindowID, string> ui_winownName = new Dictionary<EWindowID, string>()
        {
            {EWindowID.UILogin,"UILogin"},
            {EWindowID.UILobby,"UILobby"},
        };

    public Dictionary<EWindowID, string> WindowName
    {
        get { return ui_winownName; }
    }
}
