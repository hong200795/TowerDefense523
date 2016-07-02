using UnityEngine;
using System.Collections;

public class UILogin : MonoBehaviour 
{
    public GameObject btn_login;
    public GameObject btn_star;
    public UIInput ipt_name;

	// Use this for initialization
	void Start () 
    {
        btn_star.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void BtnLogin()
    {
        btn_login.SetActive(false);
        btn_star.SetActive(true);
    }

    public void BtnStar()
    {
        WindowControllerMgr.Instance.OpenWindow(EWindowID.UILobby);
    }

}
