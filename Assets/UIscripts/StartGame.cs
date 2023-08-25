using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
  

    public void StartGameScript()
    {
        SceneManager.LoadScene(sceneName:"LvLTut1");
        Debug.Log("Start game");
    }
}
