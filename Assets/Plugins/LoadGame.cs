using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void loadStart()
    {
        SceneManager.LoadScene("main", LoadSceneMode.Single);
    }
	
	public void loadmainmenu()
    {
	Debug.Log("ye");
        SceneManager.LoadScene("menu", LoadSceneMode.Single);
    }


    
}
