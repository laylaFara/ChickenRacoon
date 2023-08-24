using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
  

    public void StartGameScript()
    {
        SceneManager.LoadScene(sceneName:"HudMenu");
        Debug.Log("Start game");
    }
}
