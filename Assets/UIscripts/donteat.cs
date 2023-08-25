using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class donteat : MonoBehaviour
{
  

    public void DontEatSCR()
    {
        SceneManager.LoadScene(sceneName:"chickKillsU");
        Debug.Log("DE");
    }
}
