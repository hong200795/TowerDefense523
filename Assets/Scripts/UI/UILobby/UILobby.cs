using UnityEngine;
using System.Collections;

public class UILobby : WindowController 
{

	// Use this for initialization
	public virtual void Start () 
    {
		base.Start ();
	}
	


	public void StarGame()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
		WindowControllerMgr.Instance.DoHideLastWindow ();
	}


    public virtual void OnDestroy()
    {
		base.OnDestroy ();
    }

}
