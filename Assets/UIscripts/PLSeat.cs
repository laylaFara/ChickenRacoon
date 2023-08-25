using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLSeat : MonoBehaviour
{
  

    public void EatSCR()
    {
        SceneManager.LoadScene(sceneName:"ChickSad");
        Debug.Log("KE");
    }
}
